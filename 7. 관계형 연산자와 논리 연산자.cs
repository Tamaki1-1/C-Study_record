using System;


class Operator
{


    static void Main(string[] args)
    {
        Console.WriteLine("7.관계형 연산자와 논리 연산자");
        Console.WriteLine("\n");



        Console.WriteLine("7-1 관계형 연산자의 종류");

        int 관계1 = 10;
        int 관계2 = 20;

        Console.WriteLine(관계1 < 관계2);   // < 관계1이 관계2보다 작은지
        Console.WriteLine(관계1 <= 관계2);   // <= 관계1이 관계2보다 작거나 같은지
        Console.WriteLine(관계1 > 관계2);   // > 관계1이 관계2보다 큰지
        Console.WriteLine(관계1 >= 관계2);   // >= 관계1이 관계2보다 크거나 같은지
        Console.WriteLine(관계1 == 관계2);   // == 관계1이 관계2랑 같은지
        Console.WriteLine(관계1 != 관계2);   // != 관계1이 관계2랑 서로 다른지
        Console.WriteLine("\n");



        Console.WriteLine("7-2 논리 연산자의 종류");

        Console.WriteLine(true && false);   // 논리곱 &&은 and로 양 쪽 모두가 참이여야 참으로 간주한다.
        Console.WriteLine(true || false);   // 논리합 ||은 or로 한쪽만 참이여도 참으로 간주한다.
        Console.WriteLine(!true); // 논리부정(단항 연산자) !은 조건식 결과를 반대로 바꿔준다. ex) True -> False

        int 논리1 = 3;
        int 논리2 = 5;
        bool 논리3;

        논리3 = (논리1 == 3) && (논리2 == 3); //왼쪽 = 참 && 오른쪽 = 거짓    양쪽 다 참이 아니므로 거짓
        Console.WriteLine($"&&의 값: {논리3}");

        논리3 = (논리1 == 3) || (논리2 == 3); //왼쪽 = 참 || 오른쪽 = 거짓    하나라도 참이니 참
        Console.WriteLine($"||의 값: {논리3}");

        논리3 = false;
        Console.WriteLine($"!의 값:{!논리3}");//논리3의 기본 값은 false지만, 논리부정으로 뒤집어져 참
        Console.WriteLine("\n");

        Console.WriteLine("7-3 비트 연산자 - 이진수 비트 단위의 연산");
        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("&        논리곱(AND)            둘다 1일 때만 1, 아니면 0");
        Console.WriteLine("|        논리합(OR)             비트 값이 하나라도 1이면 1, 아니면 0");
        Console.WriteLine("^        배타적 논리합(X0R)     서로 다를 때만 1, 아니면 0");
        Console.WriteLine("~        부정(NOT)(단항)        비트 값이 1이면 0, 아니면 1");
        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        byte 이진수1 = 0b1010; //10
        byte 이진수2 = 0b1100; //12

        Console.WriteLine($"{Convert.ToString(이진수1,2)} -> {이진수1}"); //★Convert.Tostring(이진수1,2) 이진수1을 2진수로 출력한다.
        Console.WriteLine($"{Convert.ToString(이진수2,2)} -> {이진수2}"); //★Convert.Tostring(이진수1,2) 이진수1을 2진수로 출력한다.

        Console.WriteLine($"논리곱의 값:{이진수1 & 이진수2}");        // 1010 & 1100 = 1000
        Console.WriteLine($"논리합의 값:{이진수1 | 이진수2}");        // 1010 | 1100 = 1110
        Console.WriteLine($"베타적 논리합의 값:{이진수1 ^ 이진수2}"); // 1010 ^ 1100 = 0110 
        Console.WriteLine($"NOT의 1010 -> {~이진수1}");
        Console.WriteLine($"NOT의 1100 -> {~이진수2}");
        Console.WriteLine("\n");

        Console.WriteLine("7-4 시프트 연산자");
        Console.WriteLine("정의: 정수 데이터가 담겨 있는 메모리의 비트를 왼쪽(<<) 또는 오른쪽(>>)으로 이동시킵니다.");

        int 시프트1 = 10;  //정수 10
        Console.WriteLine(시프트1 << 1);   //시프트1의 값인 10의 이진수 값 1010를 왼쪽으로 1칸 이동시킨다. = 20
        Console.WriteLine(시프트1 >> 2);   //시프트2의 값인 20의 이진수 값을 오른쪽으로 2칸 이동시킨다. = 2

        Console.WriteLine("비트 연산자와 시프트 연산자도 대입 연산자와 함께 사용이 가능하다.");
        int 혼합1 = 20;
        int 혼합2 = 10;

        혼합1 &= 혼합2;     // & 연산자로 둘다 1일경우 1, 아니면 0 계산 후 혼합1에 대입
        Console.WriteLine(혼합1);
        혼합1 |= 혼합2;     // | 연산자로 하나라도 1일경우 1, 아니면 0 계산 후 혼합1에 대입
        Console.WriteLine(혼합1);
        혼합1 ^= 혼합2;     // ^ 연산자로 서로 다를 때 1, 아니면 0 계산 후 혼합1에 대입
        Console.WriteLine(혼합1);
        혼합1 <<= 혼합2;    // << 연산자로 왼쪽으로 혼합2 만큼 이동하고 혼합1에 대입
        Console.WriteLine(혼합1);
        혼합1 >>= 혼합2;    // >> 연산자로 오른쪽으로 혼합2 만큼 이동하고 혼합1에 대입
        Console.WriteLine(혼합1);
        Console.WriteLine(~혼합1); //~(not)연산자로 음수로 전환
        Console.WriteLine("\n");


        Console.WriteLine("7-5 조건(3항) 연산자 - if~else의 축약형이며 참일 때와 거짓일 때 결과를 다르게 반환한다.");


        //일본어 합격 여부 확인 시스템
        int 일본어_점수 = 54;
        string 합격여부 = (일본어_점수 >= 60) ? "합격" : "불합격";
        Console.WriteLine($"당신의 일본어 시험 결과는 {합격여부}입니다.");
        Console.WriteLine("\n");

        //홀짝 검사 시스템

        int 숫자 = 168;
        string 홀짝 = (숫자 % 2 == 0) ? "짝수" : "홀수";
        Console.WriteLine($"당신의 숫자는 {홀짝}입니다.");


        Console.WriteLine("7-6 나열(콤마) 연산자 - 한 줄에 같은 형식의 변수를 여러개 생성할 수 있는 연산자");

        int a = 10, b = 3, c = 5;   //나열 연산자로 int를 한줄에 3개 생성했다
        string A = "안", B = "녕";  //나열 연산자로 string을 한줄에 2개 생성했다.


        
    }
}
