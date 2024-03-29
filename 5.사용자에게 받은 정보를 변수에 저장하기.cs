using System;
using System.Runtime.InteropServices;
#nullable disable

class godayo
{

    static void Main(string[] args)
    {
        Console.WriteLine("5.사용자에게 받은 정보를 변수에 저장하기\n");
        Console.WriteLine("5-1 Console.ReadLine()메서드. (입력)");
        Console.ReadLine();


        Console.WriteLine("\n5-2 입력받은 메세지를 출력하기");
        Console.WriteLine(Console.ReadLine());


        Console.WriteLine("\n5-3 사용자에게 이름을 입력받아 출력하기");
        Console.Write("이름을 입력해 주세요: ");
        string 사용자1 = Console.ReadLine();
        Console.WriteLine($"안녕하세요. {사용자1}님.");


        Console.WriteLine("\n5-4 Console.Read 메서드로 한 글자(char)의 유니코드 호출하기");
        int x = Console.Read();
        Console.WriteLine("입력한 문자의 아스키코드: {0}", x);
        Console.WriteLine("입력한 문자:{0}", Convert.ToChar(x));


        Console.WriteLine("\n5-5 암시적 변환과 묵시적 변환");
        Console.WriteLine("★암시적 변환");
        int 숫자1 = 1234;
        long 숫자2 = 숫자1; //int를 long으로 자동으로 "암시적" 변환됐다.
        Console.WriteLine("\n★묵시적 변환");
        long 묵시적1 = 1234;
        int 묵시적2 = (int)묵시적1; //long을 int로 "묵시적" 변환했다.


        Console.WriteLine("\n5-6 Convert 메서드를 활용하여 형식 변환하기");

        double 실수1 = 12.34;
        string 문자열1 = "";

        문자열1 = Convert.ToString(실수1);
        Console.WriteLine($"실수를 문자열로 변환 -> {Convert.ToString(문자열1)}");
        Console.WriteLine(문자열1.GetType());

        Console.WriteLine("\n5-7 GetType 메서드로 변수 형식 확인");
        int 겟타입1 = 1;
        double 겟타입2 = 1.01;
        string 겟타입3 = "안녕하세요";
        char 겟타입4 = '안';
        object 겟타입5 = new object(); //개체를 생성하는 구문

        Console.WriteLine(겟타입1.GetType());
        Console.WriteLine(겟타입2.GetType());
        Console.WriteLine(겟타입3.GetType());
        Console.WriteLine(겟타입4.GetType());
        Console.WriteLine(겟타입5.GetType());
    }
}
