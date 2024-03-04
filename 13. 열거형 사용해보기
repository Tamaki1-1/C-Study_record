using System;

class 열거형
{

    enum 색상
    {
        Red, // 정수는 0
        Blue, // 정수는 1
        Yellow // 정수는 2
    }


    enum 알파벳
    {
        A,
        B,
        C = 10,
        D,
        E

    }
    static void Main(string[] args)
    {
        Console.WriteLine("13.열거형 사용해보기");
        Console.WriteLine("열거형(enum): 기억하기 어려운 상수들을 기억하기 쉬운 이름 하나로 묶어 관리하는 표현 방식");

        Console.WriteLine("\n");


        Console.WriteLine("13-1 ConsoleColor 열거형으로 전경색 및 배경색 바꾸기");
        
        Console.ForegroundColor = ConsoleColor.Blue; //Consol의 ForegroundColor 열거형 = 전경색 변경
        Console.WriteLine("안녕");
        Console.ResetColor();   //ResetColor = 색상 초기화

        Console.BackgroundColor = ConsoleColor.Red; //BackgroundColor = 배경색
        Console.WriteLine("; _ ;..");
        Console.ResetColor(); // 색상 초기화

        Console.WriteLine("\n");



        Console.WriteLine("13-2 열거형 만들어보기");

        색상 Red = 색상.Red;
        색상 Blue = 색상.Blue;
        색상 Yellow = 색상.Yellow;

        Console.WriteLine($"{Red}, {Blue}, {Yellow}");


        //열거형으로 관련 있는 항목을 묶어서 관리하기

        색상 빨강 = 색상.Red; //빨강 변수에 열거형 red 값 저장
        Console.WriteLine(빨강);

        if (빨강 == 색상.Red)
        {
            Console.WriteLine("赤");
        }


        //열거형 값을 정수형이나 문자열로 사용하기

        색상 노랑 = 색상.Yellow;
        int 색상_순번 = (int)노랑;
        string 색상_문자열 = Convert.ToString(노랑);
        Console.WriteLine($"[{색상_순번}], {색상_문자열}");


        //열거형 인덱스 순서 변경하기

     /* enum 알파벳
    {
        A,
        B,
        C = 10,
        D,
        E

    }*/
    Console.WriteLine($"[{(int)알파벳.A}], {Convert.ToString(알파벳.A)}"); // 0, A
        Console.WriteLine($"[{(int)알파벳.B}], {Convert.ToString(알파벳.B)}"); // 1, B
        Console.WriteLine($"[{(int)알파벳.C}], {Convert.ToString(알파벳.C)}"); // 10, C
        Console.WriteLine($"[{(int)알파벳.D}], {Convert.ToString(알파벳.D)}"); // 11, D
        Console.WriteLine($"[{(int)알파벳.E}], {Convert.ToString(알파벳.E)}"); // 12, E


        //열거형과 switch 문 함께 사용하기

        색상 정답 = 색상.Yellow;

        switch (정답)
        {
            case 색상.Red:
                Console.WriteLine("빨강");
                break;
            case 색상.Blue:
                Console.WriteLine("블루");
                break;
            case 색상.Yellow:
                Console.WriteLine("노랑");
                break;
            default:
                Console.WriteLine("기본값 설정 외");
                break;
        }


        //지정된 열거형의 상수 리스트를 배열로 가져오기 (ConsoleColor)

        Type API색 = typeof(ConsoleColor); //ConsoleColor 열거형을 typeof에 저장
        string[] 색깔모음 = Enum.GetNames(API색); //모든 색상 이름을 배열에 저장
        Console.WriteLine(색깔모음.Length);

        foreach (var TANO in 색깔모음)
        {
            Console.WriteLine(TANO);
        }

        //문자열을 특정 열거형으로 변환

        string 색상1 = "Yellow"; //열거형에 없는 상수 문자열을 입력하면 예외0

        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor),색상1); 
        Console.WriteLine("노랑색");
        Console.ResetColor();


    }


}
