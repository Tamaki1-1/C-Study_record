using System;


class data
{
    static void Main(string[] args)
    {
        Console.WriteLine("2.데이터를 담는 박스 변수-----------------------\n\n");

        
        Console.WriteLine("2-1 정수형 변수 int 만져보기");
        int 카나시이;
        카나시이 = 7;

        Console.Write("카나시이의 값: ");
        Console.WriteLine(카나시이);

        Console.WriteLine("\n\n2-2 리터럴 사용하기");
        Console.WriteLine("리터럴의 정의: 변수에 직접 정수형 또는 문자열 값을 저장할 수 있는 값");
        Console.WriteLine("정수형 리터럴 - 1234");
        Console.WriteLine("실수형 리터럴 - 123.4F");
        Console.WriteLine("문자형 리터럴 - \'a\'");
        Console.WriteLine("문자열형 리터럴 - \"Hello\"");
        Console.WriteLine("(출력↓)");
        Console.WriteLine(1234);
        Console.WriteLine(3.14);
        Console.WriteLine('A');
        Console.WriteLine("Hello");
        Console.WriteLine("\n");

        Console.WriteLine("2-3 변수 선언과 동시에 초기화하기");
        Console.WriteLine("int A = 7;");
        int A = 7;
        Console.WriteLine("A의 값은 {0}입니다.",A);
        Console.WriteLine("\n*Tip:변수는 한줄에 여러개 선언할 수 있습니다.int A, B, C;\n");
        int B, C, D = 0;

        Console.WriteLine("2-4 형식이 같은 변수를 선언하고 동일한 값으로 초기화");
        int Q, W, E;
        Q = W = E = 10;
        Console.WriteLine("Q = W = E = 10;");
        Console.WriteLine("Q:{0}, W:{1}, E:{2}",Q,W,E);

        Console.WriteLine("\n2-5 상수 사용하기");
        Console.WriteLine("상수: 상수는 절대 변하지 않는 값을 의미합니다.");
        Console.WriteLine("const int 상수 = 100;");
        Console.WriteLine("예시로 「상수 = 25;」로 변경하면 오류가 발생합니다. ");
        const int 상수 = 100;
        Console.WriteLine("최댓값은 {0}입니다.",상수);


        





    }
}
