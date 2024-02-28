using System;


class for_
{
    static void Main()
    {
        Console.WriteLine("9.반복문 사용하기\n");


        Console.WriteLine("9-1 for문으로 반복하기");
        //for문으로 안녕하세요를 3번 출력하기

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("안녕하세요");
        }

        //for문으로 1부터 3까지 반복하여 합계를 구하기

        int 합계 = 0;

        for (int i = 1; i < 5 + 1; i++)
        {
            합계 += i;
            Console.WriteLine(합계);
        }

        //for문으로 1부터 10까지 홀수끼리의 합계를 구하기

        int 합계1 = 0;

        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 1) // 홀수만 거르는 시스템 
            {
                합계1 += i;   // 1, 3, 5, 7, 9
                Console.WriteLine(합계1);
            }
        }

        //다중 for문으로 점차적으로 ★ 찍기

        for (int i = 1; i < 10; i++)
        {

            for (int j = 1; j <= i; j++)
            {
                Console.Write("★");
            }
            Console.WriteLine();
        }


        //for문으로 구구단 출력하기
        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");  // 테두리 바 
        for (int i = 2; i <= 9; i++)    // 단 표시줄
        {
            Console.Write($"{i}단       "); //세로

        }

        Console.WriteLine();

        for (int i = 2; i <= 9; i++) // 구구단의 열
        {

            for (int j = 2; j <= 9; j++) // 구구단의 행
            {
                Console.Write($"{j}*{i}={j * i, 3}   "); // 출력
            }
            Console.WriteLine();
        }
        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");



        Console.WriteLine("\n8-2 while문 사용해보기");

        //while문을 사용해 안녕하세요를 3번 출력하기

        ///while문은 직접 증감식을 만들어야 됨. (안할 시 무한루프)

        int ㅎㅇ = 0; // 카운트

        while (ㅎㅇ < 5) //조건식
        {
            Console.WriteLine("안녕하세요");
            ㅎㅇ++; //증감식
        }



        //while문을 활용해 1~10까지 순서대로 출력하기

        int 카운트 = 1;

        while (카운트 <= 10)
        {
            Console.WriteLine($"카운트: {카운트}");
            카운트++;
        }



        Console.WriteLine("\n8-3 do while문 활용해보기 - 최소 한번은 실행하는 구문");


        //do while를 활용해 안녕하세요를 3번 출력하기 - while가 1회차에 거짓이라도 무조건 한번은 출력한다.
        int 카운트1 = 0;
        do
        {
            Console.WriteLine("ㅎㅇ");
            카운트1++;
        } while (카운트1 < 3);



        Console.WriteLine("\n8-4 foreach를 활용해 배열 반복하기");

        //foreach를 사용해 배열의 값들을 출력해보기

        string[] 배열찡 = { "ABC", "abc" }; //1차원 배열로 2개의 값 선언

        foreach (var 배열 in 배열찡) //배열찡 컬렉션을 매개 변수로 삼고, var 형식 배열로 사용한다.
        {
            Console.WriteLine(배열); //배열의 모든 배열을 출력한다.

        }

        //foreach를 사용해 문자열을 한글자 씩 출력해보기

        string 한글자 = "이랏샤이마세";
        foreach (char 한글자씩 in 한글자)
        {
            Console.Write($"{한글자씩}    "); // 한글자에 담긴 "이랏샤이마세"를 한글자 씩 출력

        }

        Console.WriteLine("\n");
        Console.WriteLine("\n8-5 break, continue, goto를 사용해 반복문 제어하기");
        Console.WriteLine("break의 정의   : 반복문과 switch문을 빠져나오는 용도.");
        Console.WriteLine("continue의 정의: 나머지 코드를 실행하지 않고, 반복문 다음 처리 영역으로 넘어감. ");
        Console.WriteLine("goto의 정의    : 특정 레이블로 지정된 영역으로 이동함. (지금은 사라진듯)");


        //break 문으로 아무것도 하지 않는 프로그램 만들기

        for (int i = 0; i < 5; i++)
        {
            break;  // for문 강제 정지
            Console.WriteLine("안녕하세요"); // ; _ ;..?
        }

        //break 문으로 100번 반복하는 반복문에서 5일 때 종료하는 프로그램

        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine($"카운트: {i}");

            if (i == 5)
            {
                break;
            }
        }


        //continue 문을 활용해 홀수를 건너 뛰고, 짝수 끼리만 더하는 프로그램


        int 합계2 = 0;
        for (int i = 1; i < 10; i++)
        {
            if (i % 2 == 1)
            {
                continue;
            }
            합계2 += i;
            Console.WriteLine(합계2);
        }
    }

}
