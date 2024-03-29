using System;
using System.Data;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

class 함수
{

    //11. 함수 사용해보기


    //11-1 매개변수가 없는 함수
    //가장 단순한 형태이며 매개변수도 없고, 반환 값도 없다
    
    static void hi()
    {

        Console.WriteLine("안녕하세요");

    }


    static void Main(string[] args)
    {
        hi(); //hi 메서드를 호출한다.

    }
    
    //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    //11-2 매개변수가 있는 함수

    static void dd(string a) // 매개변수 a
    {

        Console.WriteLine(a); //호출한 곳에서 입력받은 string 계열의 데이터를 저장

    }

    static void Main(string[] args)
    {
        dd("; _ ;...");
        dd("悲しいちゃん");
    }
    
    //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    //11-3 반환값이 있는 함수 - return으로 값을 처리 후 되돌려주는 함수
    

    //문자열 데이터를 반환하는 함수
    static string dddd()
    {
        return "나는 반환한다";
    }

    static void Main(string[] args)
    {
        string 리턴 = dddd();
        Console.WriteLine(리턴);
    }

    
    //정수형 반환값이 있는 함수

    static int int_(int x) //매개변수와 반환값이 있는 함수
    {


        return x * x; //입력받은 매개변수를 서로 곱해 돌려준다.

    }

    static void Main(string[] args)
    {
        int 정수 = int_(3); //함수 이름과 원하는 매개변수 값 입력
        Console.WriteLine(정수);

    }
    


    //입력받은 두 수를 더해 반환해주는 함수

    static int kana(int a, int b)
    {

        return a + b;
    }

    static void Main(string[] args)
    {
        int 덧셈 = kana(3, 5);

        Console.WriteLine(덧셈);

    }
    

    //입력받은 두 수 중에 높은 수를 반환 시켜주는 함수

    static int Max(int a, int b)
    {
        int c = 0;
        if (a > b)
        {
            return a;

        }
        else
        {
            return b;
        }
        
    }

    static void Main(string[] args)
    {
        int 타노 = 12;
        int 카나 = 2;

        Console.WriteLine(Max(타노,카나));
    }
    

    //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    //11-4 XML 문서 주석을 사용하기 (설명문)
    /// <summary>
    /// 입력받은 문자열을 화면에 출력시켜주는 함수
    /// </summary>
    /// <param name="a">첫 번째 매개변수</param>

    static void tano(string a)
    {
        Console.WriteLine(a);

    }
    static void Main(string[] args)
    {
        tano("ㅎㅇ");

    }
    


    //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    //11-5 기본 매개변수(선택적 매개변수)

    static void 선택적_매개변수(string A = "いち", int B = 1) //값을 미리 지정해 값을 선택적으로 출력가능하다.
    {

        Console.WriteLine($"{A}, {B}");

    }

    static void Main(string[] args)
    {
        선택적_매개변수();         // 선택적 매개변수 - 기본 값 출력
        선택적_매개변수("타노",3); // 지정 매개변수 - 입력한 값 출력
        선택적_매개변수(B: 3, A: "타노"); //명명된 매개변수 - 이름을 지정하면 위치를 바꿀 수 있다.
    }
    

    //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    //11-6 함수 오버로드: 다중 정의
    //-매개변수를 달리해서 이름이 동일한 함수 여러 개를 정의 할 수 있는 기능

    static void 오버로드()
    {
        Console.WriteLine("매개변수 없는 함수");
    }

    static void 오버로드(int a)
    {
        Console.WriteLine($"{a}, {a.GetType()}");
    }

    static void 오버로드(string a)
    {
        Console.WriteLine($"{a}, {a.GetType()}");
    }

    static void Main(string[] args)
    {
        오버로드(123);
        오버로드("아아아아 ; _ ;....");
        오버로드();
    }
    
    //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    //11-7 재귀 함수 - 함수 자신을 호출하는 것

    //재귀 함수를 사용해 n의 n승의 값 구하는 프로그램 만들기


    static int 재귀(int a, int b)
    {
        if (b == 0)
        {
            return 1;
        }

        return a * 재귀(a, --b);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(재귀(2,10));
    }
    

    //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    //11-8 전역 변수와 지역 변수
    //전역 변수: 클래스와 같은 레벨에서 선언된 변수
    //지역 변수: 함수 내에서 선언된 변수

    static string 전역_변수 = "전역 변수";
    static void Main(string[] args)
    {
        string 지역_변수 = "지역 변수";
        Console.WriteLine(지역_변수); //지역 변수 호출 / 함수 내
        Console.WriteLine(전역_변수); //전역 변수 호출 / 클래스 내
    }

    
    //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    //11-9 화살표 함수 사용하기 - 함수를 축약하는 기능

    static void Main(string[] args)
    {
        화살표();
        화살표2(3, 5);
        Console.WriteLine(화살표3("에","오"));
    }

    static void 화살표() => Console.WriteLine("화살표 함수"); //매개변수가 없는 함수
    static void 화살표2(int a, int b) => Console.WriteLine(a + b); //매개변수가 있는 함수

    static bool 화살표3(string a, string b) => a == b; //반환값이 있는 함수 (return)
    

    //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    //11-10 로컬 함수 - 함수 내에서 함수를 선언

    static void Main(string[] args)
    {

        로컬();
        Console.WriteLine(로컬빼기(3,1));

     void 로컬() //로컬 함수
        {
            Console.WriteLine("안녕하세요");
        }


        int 로컬빼기(int a, int b) => a - b; //로컬 함수에 화살표 넣기


    }
    

}
