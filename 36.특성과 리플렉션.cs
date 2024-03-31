#define RELEASE //전처리기 지시문으로 RELEASE 기호 정의
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


class 특성
{
    static void Main(string[] args)
    {
        Console.WriteLine("36.특성");
        Console.WriteLine("정의: 프로그램에서 형식, 멤버, 다른 엔터티에 대한 추가 선언 정보를 지정할 수 있습니다.");
        Console.WriteLine("- 작성한 프로그램 코드에 설명을 추가로 붙이는 것");
        Console.WriteLine("- 프로그램에 메타데이터를 추가합니다.");
        Console.WriteLine("- 데코레이터와 애너테이션 성격을 지닙니다.");
        Console.WriteLine("- 꾸밈자 역할을 합니다.");
        Console.WriteLine("- 여러 구성 요소에 추가 정보를 제공합니다.");

        //[Obsolete]
        //public class OldClass {}

        Console.WriteLine("* 닷넷에 내장된 특성");
        Console.WriteLine("Obsolete와 Conditional같은 기본 제공 특성");

        Console.WriteLine("* 사용자 지정 특성");
        Console.WriteLine("사용자가 새로운 특성을 만들 수 있고,\n" +
                          "Attribute 클래스를 상속하는 클래스로 사용자 지정 특성을 만들 수 있다.");
    }

}


//36-1 Obsolete 특성 사용하기
//기존 하위 호환성을 위해 코드를 남겨 놓지만,
//사용하지 않도록 권장하는 목적

class 특성
{
    static void OldMember() => Console.WriteLine("Old Member");
    static void NewMember() => Console.WriteLine("new Member");

    [Obsolete] static void ObsMember() => Console.WriteLine("Obs Member");

    [Obsolete("경고 메세지")] static void ObsMember2() => Console.WriteLine("Obs Member 2");

    [Obsolete("실행 불가능", true)] static void ObsMember3() => Console.WriteLine("Obs Member 3");

    static void Main(string[] args)
    {
        OldMember();
        NewMember();
        ObsMember(); //경고 메세지: 특성이 사용되지 않았습니다.
        ObsMember2(); //경고 메세지: 특성이 사용하지  않았습니다. '; _ ;'
        ObsMember3(); //에러 발생
    }
}



//36-2 특성의 매개변수
//위치 매개변수: 특성에 전달되는 매개변수는 위치에 따라 구분됩니다.
//이름 매개변수: 특성에 구현된 속성 또는 필드(public)에 값을 전달할 때 사용됨
//ex: [WebServer(namespace="http://wwww.hawaso.com/")] - WebServer 특성에 Namespace 속성 값 전달



//[Conditional] 특성 사용하기
//특정 기호에 따라 실행 여부를 결정할 수 있다.

public class ConditionalDemo
{
    static void Main(string[] args)
    {
        DebugMethod(); //디버그 환경에서만 표시
        ReleaseMethod(); //릴리스 환경에서만 표시
        kanaMethod(); //X 실행되지 않음.
    }

    [Conditional("DEBUG")] //DEBUG 기호를 가지는 경우 실행
    static void DebugMethod() => Console.WriteLine("디버그 환경에서만 표시");

    [Conditional("RELEASE")] static void ReleaseMethod() //RELEASE 기호가 있는 경우 실행
        => Console.WriteLine("릴리스 환경에서만 표시");

    [Conditional("카나시이")]
    static void kanaMethod() => Console.WriteLine("카나시이가 있는 환경에서만 표시");

    //상단에 드롭다운 리스트로 Debug와 RELEASE를 구분 지을 수 있다.

}


//36-3 특성을 사용하여 메서드 호출 정보 얻기
//[Caller] 특성 - 메서드를 호출한 호출자 정보를 얻는 특성

class CallerInformetion
{
    static void Main(string[] args)
    {
        TraceMessage("여기서 무엇인가 실행..");
    }

    public static void TraceMessage(string massage,
                         [CallerMemberName] string membername = "",
                         [CallerFilePath] string sourceFilePath = "",
                         [CallerLineNumber] int sourceLineNumber = 0)
    {
        Console.WriteLine($"실행 내용: {massage}");
        Console.WriteLine($"멤버 이름: {membername}");
        Console.WriteLine($"소스 경로: {sourceFilePath}");
        Console.WriteLine($"실행 라인: {sourceLineNumber}");

          //실행 내용: 여기서 무엇인가 실행..
          //멤버 이름: Main
          //소스 경로: C:\C#\36.특성과 리플렉션\36.특성과 리플렉션\Program.cs
          //실행 라인: 100
    }
}



//36-4 Attribute 클래스를 상속하여 사용자 지정 특성 만들기

public class SampleAttribute : Attribute //Attribute를 상속하여 사용자 지정 특성 만들기
{
    public SampleAttribute()
    {
        Console.WriteLine("사용자 지정 특성 사용됨");
    }

    [Sample] //여기다가 적용
    public class CustromAttriButeTest { }

    class AttributePractice
    {
        static void Main(string[] args)
        {
            //ustromAttriButeTest 클래스에 적용된 특성 가져오기
            Attribute.GetCustomAttributes(typeof(CustromAttriButeTest));
        }
    }
}



//36-5 매개변수가 있는 사용자 지정 특성 만들기

//1. AttributeUsage 특성을 사용하여 특성에 제약 조건 등 설정

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]

public class NickNameAttribute : Attribute
{
    public string Name { get; set; } //속성
    public NickNameAttribute(string name) { this.Name = name; }
}


//2. AllowMultiple로 여러 번 설정 가능
[NickName("길벗")]
[NickName("RedPlus")]
class NickNameAttributeTest
{
    static void Main(string[] args)
    {
        ShowMetaData(); //out put = 길벗, 길벗, RedPlus, RedPlus
    }

    static void ShowMetaData()
    {
        Attribute[] attributes = Attribute.GetCustomAttributes(typeof(NickNameAttributeTest));

        foreach (var item in attributes)
        {
            //is 연산자를 사용하여 커스텀 어트리뷰트의 Name 속성 출력
            //is = 변환이 가능하면 true, 아니면 false
            if (item is NickNameAttribute)
            {
                NickNameAttribute ais = (NickNameAttribute)item;
                Console.WriteLine(ais.Name);
            }

            //as 연산자를 사용하여 커스텀 어트리뷰트의 Name 속성 출력
            //as = 변환이 가능하면 변환을 수행하고, 아니라면 null을 반환
            NickNameAttribute bis = item as NickNameAttribute;
            if (item != null)
            {
                Console.WriteLine(bis.Name);
            }
        }
    }
}



//36-6 리플렉션
//Type = 클래스 형식, 인터페이스 형식, 배열 형식, 값 형식, 열거형 형식, 형식 매개 변수, 제네릭 형식 정의 
//       개방형 생성 제네릭 형식이나 폐쇄형 생성 제네릭 형식에 대한 형식 선언을 나타냅니다.

//Assembly = 특정 어셈블러 정보를 얻는 클래스

class 리플렉션
{
    static void Main(string[] args)
    {
        Console.WriteLine("리플렉션은 동적으로 특정 어셈블로 또는 형식에 대한 메타데이터를 Type 개체로 반환하는 것을 의미");
        string r = "Reflection";
        Type t = r.GetType(); 
        Console.WriteLine(t); //System.String


        //Assembly 클래스를 사용하여 특정 어셈블리 정보 얻기
        System.Reflection.Assembly assembly = typeof(System.Random).Assembly;
        Console.WriteLine(assembly); //System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e


        //Random 클래스의 멤버 리스트를 가져와 2개만 보여주기
        Console.WriteLine(typeof(Random).GetMembers().Take(3)); //System.Linq.Enumerable+ListPartition`1[System.Reflection.MemberInfo]
    }
}



//36-7 특정 클래스의 메서드와 속성을 동적으로 호출하기

namespace ReflectionGetMembers
{
    class Test
    {
        public static void TestMethod() { }
    }

    class ReflectionGetMembers
    {
        static void Main(string[] args)
        {
            Type T = typeof(Test); //Test 클래스에 대한 것을 Type 개체로 가져오기
            Console.WriteLine(T); //ReflectionGetMembers.Test

            
            //원하는 멤버를 조건에 따라 가져오기 (Public or Instance)
            MemberInfo[] members = T.GetMembers(BindingFlags.Public | BindingFlags.Instance);

            foreach (var item in members)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}



//36-8 Type 클래스로 클래스의 멤버 호출하기

namespace ReflectionGetMethod
{
    public class MemberClass
    {
        public string Name { get; set; } = "길벗출판사"; // 자동 속성
        public string GetName() //메서드
        {
            return Name + ", " + DateTime.Now.ToShortTimeString(); //현재시간 출력
        }
    }

    class ReflectionGetMethod
    {
        static void Main(string[] args)
        {
            MemberClass memberClass = new MemberClass(); //인스턴스 생성
            Type t = memberClass.GetType(); //t에 Memberclass의 타입을 저장

            //속성 읽어 오기 및 속성 호출
            PropertyInfo pi = t.GetProperty("Name"); //t의 속성정보 가져오기
            Console.WriteLine($"속성 호출 : {pi.GetValue(memberClass)}"); //GetValue - 값 가져오기

            //메서드 읽어 오기 및 메서드 호출
            //Invoke() - 동적으로 메서드를 호출
            MethodInfo mi = t.GetMethod("GetName"); //속성 호출 : 길벗출판사
            Console.WriteLine($"메서드 호출 : {mi.Invoke(memberClass, null)}"); //메서드 호출 : 길벗출판사, 오후 10:39

            //참고: C# 4.0 이상에서는 dynamic 개체로 쉽게 멤버를 동적으로 호출
            //*이 방법을 선호함. 간단하게 동적으로 호출 가능
            dynamic d = new MemberClass(); //var와 다르게 유동적으로 변경 가능한 dynamic
            Console.WriteLine($"속성 호출 : {d.Name}"); //속성 호출 : 길벗출판사
            Console.WriteLine($"메서드 호출 : {d.GetName()}"); //메서드 호출 : 길벗출판사, 오후 10:39
        }
    }
}

//36-9 특정 속성에 적용된 특성 읽어 오기

namespace ReflectionGetProperty
{
    class Person
    {
        [Obsolete] public string Name { get; set; }
    }

    class ReflectionGetProperty
    {
        static void Main(string[] args)
        {
            //Name 속성의 정보 얻기
            PropertyInfo p = typeof(Person).GetProperty("Name");

            //Name 속성에 적용된 특성 읽어 오기
            object[] attributes = p.GetCustomAttributes(false);
            foreach (var item in attributes)
            {
                //특성의 이름들 출력
                Console.WriteLine(item.GetType().Name); //ObsoleteAttribute
            }
        }
    }

    
}


//36-10 Type과 Activator 클래스로 개체의 인스턴스를 동적 생성하기
//Type.GetType()메서드로 특정 클래스의 Type 개체를 가져올 수 있고,
//이를 다시 Activator 클래스의 CreateInstance() 메서드로
//동적으로 문자열로 지정된 클래스의 인스턴스를 생성 할 수 있다.

namespace TypeAndActivator
{
    public class MyClass
    {
        public void Test()
        {
            Console.WriteLine("MyClass의 Test() 메서드가 실행됩니다.");
        }
    }

    class TypeAndActivator
    {
        static void Main(string[] args)
        {
            //Type.GetType() 메서드에 지정한 클래스 형식을 가져옴
            Type type = Type.GetType("TypeAndActivator.MyClass");

            //Activator.CreateInstance() 메서드로 지정된 형식의 인스턴스 생성
            dynamic objtype = Activator.CreateInstance(type);

            objtype.Test(); //MyClass의 Test() 메서드가 실행됩니다.
        }
    }
}

