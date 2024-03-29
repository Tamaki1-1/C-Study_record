#define RELEASE //전처리기 지시문으로 RELEASE 기호 정의
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

/*
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
}*/



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