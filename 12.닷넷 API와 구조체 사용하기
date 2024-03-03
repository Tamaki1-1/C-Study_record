using System;

    struct 구조체
{
    public int 구조체1; //public 키워드로 외부에서 사용 가능하도록 허용
    public int 구조체2;
}

struct 구조체2
{
    public string 이름;
    public int 나이;
    public decimal 자산;
}

struct 구조체3
{
    public string 이름;
    public int 나이;

}

struct 매개변수구조체
{
    public string 이름;
    public int 나이;

}
    
    class Api
    {
        static void Main(string[] args)
        {
            Console.WriteLine("12 - 닷넷 API와 구조체 사용하기");
            Console.WriteLine("클래스: console, string같은 클래스");
            Console.WriteLine("구조체: DateTime 구조체, TimeSpan같은 구조체 형태로 표현하며, 클래스와 거의 동일");
            Console.WriteLine("열거형: Color 열거형 등이 있으며, 특정 목록을 관리할 때 편리");
            Console.WriteLine("네임스페이스: 많은 양의 클래스와 구조체, 열거형을 묶어서 관리");


            Console.WriteLine("\n");

            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("12-1 수학 관련 클래스 Math 사용해보기");

            int 매스 = 5;

            Console.WriteLine(Math.Pow(매스,2)); //Pow는 거듭제곱 메서드 "정수, 제곱"
            Console.WriteLine(Math.Max(매스,3)); // Max 두 수 중에 큰 값 출력
            Console.WriteLine(Math.Min(매스,3)); // Min 두 수 중에 작은 값 출력

            Console.WriteLine("\n");
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("12-2 구조체 만들기");
            Console.WriteLine("변수와 배열을 확장하여 이름 하나로 데이터 형식을 1개 또는 여러 개 보관하는 그릇 역할");{

            구조체 구조체; //구조체 형식의 변수 선언

            구조체.구조체1 = 3; //구조체에 값 담기
            구조체.구조체2 = 5;

            Console.WriteLine($"구조체 불러오기: {구조체.구조체1}, {구조체.구조체2}"); // 3, 5


            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("12-3 구조체를 사용하여 변수 하나로 여러 개를 묶어서 관리");

            구조체2 구조체2; // 구조체2 변수 선언

            구조체2.이름 = "타마키";
            구조체2.나이 = 24;
            구조체2.자산 = 20013423;

            Console.WriteLine($"이름: {구조체2.이름}\n나이: {구조체2.나이}\n자산: \\{구조체2.자산}");



            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("12-4 구조체 배열을 사용하여 여러명의 데이터 출력하기");

            구조체3[] 구조체3 = new 구조체3[2]; //구조체에 배열 선언

            구조체3[0].이름 = "타마키"; // 데이터 입력
            구조체3[1].이름 = "김환수";

            구조체3[0].나이 = 24;
            구조체3[1].나이 = 244;

            for (int i = 0; i <= 구조체3.Length; i++) // 배열 for
            {
                Console.WriteLine($"{구조체3[i].이름}, {구조체3[i].나이}");
                Console.WriteLine($"데이터 인원수: {구조체3.Length}");
            }
    
using System;

struct 매개변수구조체
{
    public string 이름;
    public int 나이;

}

class 구조체
{
    static void Main(string[] args)
    {
        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("12-5 구조체 매개변수 사용");


        string 이름 = "타노시이";
        int 나이 = 12;

        매개변수구조체 구조체4;
        구조체4.이름 = "카나시이";
        구조체4.나이 = 7;

        일반출력(이름, 나이);
        출력(구조체4);
        static void 출력(매개변수구조체 구조체)
    {
        Console.WriteLine($"{구조체.이름},{구조체.나이}");
    }
    static void 일반출력(string 이름, int 나이)
    {
        Console.WriteLine($"{이름}, {나이}");
    }
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("12-6 내장형 구조체 사용해보기");

        Console.WriteLine("DateTime = 날짜 관련 구조체");
        Console.WriteLine($"현재 시간: {DateTime.Now}\n올해: {DateTime.Now.Year}\n밀리초: {DateTime.Now.Millisecond}");






        Console.WriteLine("TimeSpan = 날짜와 시간 차이를 구해 주는 구조체");
        TimeSpan 시간 = Convert.ToDateTime("2024-12-25") - DateTime.Now;
        Console.WriteLine($"{DateTime.Now.Year}년 크리스마스까지 {(int)시간.TotalDays}일 남았다!");



        TimeSpan 지칸 = DateTime.Now - Convert.ToDateTime("2000-1-19");

        Console.WriteLine($"살았던 날: {(int)지칸.TotalDays}");

        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("12-7 문자열 형식의 날짜를 날짜 형식으로 변환 out var, out DateTime");

        if (DateTime.TryParse("2024-12-25", out var ss)) // 변환이 가능하면 참
        {
            Console.WriteLine(ss); // ss 출력
        }
    
    static void Main(string[] args)
 static void Main(string[] args)
    {
        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("12-8 1~8760까지 정수에 해당하는 날짜를 반환하는 함수");

        Console.WriteLine(반환찡(0)); //숫자당 1시간
        Console.WriteLine(반환찡(1));
        Console.WriteLine(반환찡(2));
        Console.WriteLine(반환찡(3));
        Console.WriteLine(반환찡(8760));
        Console.WriteLine(반환찡(8760/2));

    }
    
    
    static DateTime 반환찡(int 숫자)
    {

        return (new DateTime(2019, 1, 1, 0, 0, 0)).AddHours(숫자); //숫자당 한시간 추가

    }
    

    static void Main(string[] args)
    {
        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("12-9 문자 관련 구조체 사용하기 (Char)");

        char A = 'A';
        char B = 'b';
        char C = '1';
        char D = ' ';

        if (Char.IsUpper(A))  // 대문자면 참
        {
            Console.WriteLine("a");
        }

        if (Char.IsLower(B)) // 소문자면 참
        {
            Console.WriteLine("b");
        }

        if (Char.IsNumber(C)) //숫자면 참
        {
            Console.WriteLine("c");
        }

        if (Char.IsWhiteSpace(D)) //공백이면 참
        {
            Console.WriteLine("d");
        }


        string abc = "hIHi"; //문자열 대문자 if

        if (Char.IsUpper(abc[0])) //0 - 첫번째 글자가 대문자인지
        {
            Console.WriteLine("첫글자가 대문자입니다.");
        }
        if (Char.IsUpper(abc[1])) //1 - 두번째 글자가 대문자인지
        {
            Console.WriteLine("두번쨰 글자가 대문자입니다.");
        }


        Console.WriteLine(Char.ToLower(A)); // A = 'A'를 소문자로 변경
        Console.WriteLine(Char.ToUpper(B)); // B = 'b'를 대문자로 변경


        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("12-10 Guid 구조체로 유일한 값 출력하기");
        Console.WriteLine("동일한 값을 가질 확률이 0%인 유일한 값 출력하기");

        string 시리얼넘버 = Guid.NewGuid().ToString();

        Console.WriteLine($"시리얼 넘버: {시리얼넘버}"); //aa07fee2-7422-4983-be3e-7847601bc8f1
        Console.WriteLine($"{Guid.NewGuid().ToString("D")}"); //181ce69c-acf1-4fe5-94f4-893be694ab1a
        Console.WriteLine($"{Guid.NewGuid().ToString("B")}"); //{5cbcc90b-de5a-427d-ba8d-2c219e5ef6c5}
        Console.WriteLine($"{Guid.NewGuid().ToString("P")}"); //(167229ae-102a-4df9-870c-72a37172d423)
        Console.WriteLine($"{Guid.NewGuid().ToString("X")}"); //{0x724dd0f7,0x6b54,0x4b02,{0x9d,0x2b,0x0f,0xea,0xd8,0x84,0x08,0x5d}}
    }
