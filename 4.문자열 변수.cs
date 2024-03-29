using System;



class 文字
{

    static void Main(string[] args)
    {
        Console.WriteLine("4.문자 데이터 형식: char");
        Console.WriteLine("기본적으로 문자 데이터 형식은 단일 유니코드로서 한 글자만 저장 할 수 있다.");

        Console.WriteLine("\n4-1 char 데이터 형식 선언");
        char A = 'a';
        char B = 'b';
        Console.WriteLine(A);
        Console.WriteLine(B);

        Console.WriteLine("\n4-2 문자열 데이터 형식: string");
        Console.WriteLine("문자열 데이터를 저장하는 변수이다.");

        Console.WriteLine("\n4-3 string  데이터 형식 변수 선언");
        string 이름 = "박새로이";

        Console.WriteLine("안녕하세요. {0}입니다.", 이름);

        Console.WriteLine("\n4-4 @ 기호로 여러 줄의 문자열을 저장 할 수 있다.");
        string 골뱅이 = @"
                        안녕하세요.
                        반갑습니다.";
        Console.WriteLine(골뱅이);

        Console.WriteLine("\n4-5 문자열 보간법이란?");
        Console.WriteLine("$\"{변수}\" 이와 같이 자리 표시자를 사용하지 않고 문자열을 묶을 때 주로 활용하는 기능");

        string hi = "hello";
        Console.WriteLine($"{hi}");

        Console.WriteLine("\n4-6 논리 데이터 형식(bool)");
        Console.WriteLine("논리 데이터 형식은 예/아니요, 참/거짓의 정보를 저장합니다. true or false");

        bool 독도는_한국땅 = true;
        bool 대마도는_한국땅 = false;
        Console.WriteLine($"대마도는 한국땅입니까? {대마도는_한국땅}");  //문자열 보간법의 활용
        Console.WriteLine($"독도는 한국땅입니까? {독도는_한국땅}");

        Console.WriteLine("\n4-7 문자열도 상수 데이터가 존재한다.(const)");

        const string 닷넷최고 = "닷넷최고"; //숫자형 데이터와 마찬가지로 절대 변하지 않는다.
        Console.WriteLine(닷넷최고);
        

    }
}
