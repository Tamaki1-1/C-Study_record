using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

class 동적_형식
{
    static void Main(string[] args)
    {
        Console.WriteLine("40.동적(dynamic) 형식");
        Console.WriteLine("-런타임에 형식이 지정되는 프로그램이 필요할 때 dynamic 키워드가 사용된다.");
        Console.WriteLine("-데이터 형식 자리에 오지만, dinamic은 데이터 형식이 아니다.(dynamic은 특정 데이터 형식을 지칭하지 않음)");
        Console.WriteLine("-var와 비슷하지만, var는 컴파일 할 때 데이터 형식을 결정하고, dynamic은 런타임 때 데이터 형식을 결정");
        Console.WriteLine("-모든 데이터 형식을 선언하는 자리에는 dynamic 키워드를 사용 할 수 있다.");
        Console.WriteLine("-다른 동적 언어와 통신에 유용하다.");

        //dynamic 변수로 런타임할 때 데이터 형식 결정하기
        dynamic x;
        x = 1234; //int
        Console.WriteLine(x); //1234
        Console.WriteLine(x.GetType()); //System.Int32

        x = "dynamic은 동적 형식!"; //string
        Console.WriteLine(x.GetType()); //System.String


        //런타임에 데이터 형식이 결정되는 dynamic 변수
        dynamic y = 1; //컴파일 할때 dynamic, 런타임할 때 int
        dynamic z = "1"; //컴파일 할때 dynamic, 런타임할 때 string

        Console.WriteLine($"y: {y}, {y.GetType()}"); //y: 1, System.Int32
        Console.WriteLine($"x: {z}, {z.GetType()}"); //x: 1, System.String


        //문자열 변수를 string, var, dynamic 키워드로 선언하기

        //1.코드를 작성할 때 문자열로 판단
        string ss = "안녕하세요.";
        Console.WriteLine(ss.Length);

        //2.컴파일할 때 문자열로 판단
        var vs = "안녕하세요.";
        Console.WriteLine(vs.Length);

        //3.런타임할 때 문자열로 판단
        dynamic ds = "안녕하세요.";
        Console.WriteLine(ds.Length);

        //4.런타임할 때 숫자형으로 판단
        ds = 123;
        Console.WriteLine(ds * 10); //1230 //숫자형 연산도 가능



        //동적 바인딩(dynamic binding)
        //런타임할 때 데이터 형식을 결정하는 것

        dynamic now = DateTime.Now; //dynamic에 현재 시간 저장
        int hour = now.Hour;
        Console.WriteLine(hour); //22 - 현재 시간이 출력됨
    }
}


//40-1 확장 메서드와 dynamic
//확장 메서드는 정적 형식에서는 호출 되지만, 동적 형식으로는 호출되지 않는다.

static class DynamicExtensionMethod
{
    static string PreDotNet(this string str)
    {
        return $"...str";
    }

    static void Main(string[] args)
    {
        string 정적 = "DotNet";
        Console.WriteLine(정적.PreDotNet()); //성공

        dynamic 동적 = "Korea";
        Console.WriteLine(동적.PreDotNet()); //에러 발생
        //Unhandled exception. Microsoft.CSharp.RuntimeBinder.RuntimeBinderException: 'string' does not contain a definition for 'PreDotNet'
        //at CallSite.Target(Closure, CallSite, Object)
        //at System.Dynamic.UpdateDelegates.UpdateAndExecute1[T0, TRet](CallSite site, T0 arg0)
        //at DynamicExtensionMethod.Main(String[] args) in C:\C#\39.확장 메서드\39.확장 메서드\Program.cs:line 78
    }
}




