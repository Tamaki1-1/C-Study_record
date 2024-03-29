using System;


class Operator
{
    static void Main(string[] args)
    {

        Console.WriteLine("6.연산자의 개요 및 단항, 산술 연산자 사용하기\n\n");

        Console.WriteLine("6-1 단항 연산자의 종류 (피연산자 연산자)(+, -)");
        int 단항1 = 0;                //int 단항1 변수 선언
        단항1 = ++단항1;              //단항 연산자 +로 단항1에 1 더하기
        Console.WriteLine(단항1);     //단항1 값 출력 = 0

        단항1 = --단항1;              //단항 연산자 -로 단항1에 1 빼기
        Console.WriteLine(단항1);     //단항1 값 출력 = 0
        Console.WriteLine("\n");


        Console.WriteLine("6-2 변환 연산자 - ()로 데이터 형식 변환");

        int 변환1 = (int)3.14;        //실수형 데이터를 "변환 연산자"로 int로 선언해 소숫점은 제거

        Console.WriteLine(변환1);     //변환1 출력 = 3
        double 변환2 = (double)변환1; //변환1을 double 데이터로 변횐
        Console.WriteLine(변환2);     //변환2 출력 = 3    // 실수는 제거되어 3만 남게 됨.
        Console.WriteLine("\n");


        Console.WriteLine("6-3 산술 연산자 - 사칙 연산");
        Console.WriteLine("연산자   의미          예시"); 
        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("+        더하기        A + B");
        Console.WriteLine("-        빼기          A - B");
        Console.WriteLine("*        곱하기        A * B");
        Console.WriteLine("/        나누기        A / B");
        Console.WriteLine("%        나머지        A % B");
        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        int 산술1 = 3;    //int 산술1 = 3;
        int 산술2 = 5;    //int 산술2 = 5;
        int 산술3 = 산술1 + 산술2;    //산술 연산자로 산술1 + 산수2의 값인 8을 산술3에 저장
        Console.WriteLine($"산술1과 산술2의 합: {산술3}");   //출력

        // 문자열 산술 연산자로 결합할 수 있다.
        string 문자열결합1 = "안녕";   //string 문자열결합1 선언
        string 문자열결합2 = "하세요"; //string 문자열결합2 선언
        Console.WriteLine(문자열결합1 + 문자열결합2); //"안녕"+"하세요"를 결합한다.
        Console.WriteLine("\n");


        Console.WriteLine("6-4 할당 연산자 - 오른쪽에 있는 값을 왼쪽 변수에 할당하는 연산자");

        int 할당1 = 100;
        int 할당2 = 200;

        할당1 += 할당2; //할당1 + 할당2 의 값을 왼쪽에 할당
        Console.WriteLine(할당1);
        할당1 -= 할당2; //할당1 - 할당2의 값을 왼쪽에 할당
        Console.WriteLine(할당1);
        할당1 *= 할당2; //할당1 * 할당2의 값을 왼쪽에 할당
        Console.WriteLine(할당1);
        할당1 /= 할당2; //할당1 / 할당2의 값을 왼쪽에 할당
        Console.WriteLine(할당1);
        할당1 %= 할당2;
        Console.WriteLine(할당1);
        Console.WriteLine("\n");


        Console.WriteLine("6-5 증감 연산자 - (++, --)");
        int 증감1 = 100;          //int 형식의 증감1 변수 선언. 값은 100
        ++증감1;                  //증감1에 1을 증가시킨다.
        Console.WriteLine(증감1); //증감1의 값 출력
        --증감1;                  //증감1에 1을 감소시킨다.
        Console.WriteLine(증감1); //증감1의 값 출력

        /*전위 증감 연산자와 후위 증감 연산자
         
        전위 증감 연산자 = ++int로 선언하며, 다른 계산식보다 증감 연산자를 우선순위로 둔다.
        후위 증감 연산자 = int++로 선언하며, 다른 계산식보다 증감 연산자를 후순위로 둔다.
        
        */
        ++증감1;  // 전위 증감 연산자 증감 1 + 1
        --증감1;  // 전위 증감 연산자 증감 1 - 1
        증감1--;  // 후위 증감 연산자 증감 1 - 1
        증감1++;  // 후위 증감 연산자 증감 1 + 1



    }

}
