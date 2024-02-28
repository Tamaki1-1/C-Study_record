using System;
using System.Runtime.InteropServices;

class control
{

    static void Main(string[] args)
    {
        Console.WriteLine("8.조건문의 종류");
        Console.WriteLine("\n");


        Console.WriteLine("8-1 if문 - 조건을 하나 비교");
        Console.WriteLine("-참이면 출력하고, 거짓이면 무시한다.");

        //합격(60점)이면 출력하는 프로그램

        int If = 62;    //점수로 쓸 int 선언
        if (If >= 60)   // If가 크거나 같으면 참
        {
            Console.WriteLine("합격입니다.");    //출력
        }

        //참이면 출력, 거짓이면 출력하지 않는다
        int If2 = 60;

        if (If2 >= 60) //60점 이상일 시 참
        {
            Console.WriteLine("합격입니다.");
        }
        if (If2 >= 80) //80점 이상일 시 참. If2 = 60 이므로 거짓
        {
            Console.WriteLine("우수합니다.");    // if는 거짓을 출력하지 않아 무시함
        }


        //중첩 if문 프로그램 예시

        string 중첩1 = "셋";
        int 중첩2 = 3;

        if (중첩1 == "셋") // 첫 번째 조건
        {
            Console.WriteLine(중첩1);
            if (중첩2 == 3) // 두 번째 조건
            {
                Console.WriteLine(중첩2);
            }
        }
        Console.WriteLine("\n");



        Console.WriteLine("8-2 if~else문 - 조건 분기로 거짓이면 다른 값을 출력");

        //if~else를 활용한 합격여부 시스템
        int 이프엘스1 = 68;

        if (이프엘스1 >= 60) //참일 경우 합격 출력
        {
            Console.WriteLine($"당신의 점수는 {이프엘스1}점이며, 합격입니다.");
        }
        else   // 거짓일 경우 불합격 출력
        {
            Console.WriteLine($"당신의 점수는 {이프엘스1}점이며, 불합격입니다....");
        }

        //중첩 if~else를 활용한 에/아니오/n.. 시스템

        Console.WriteLine("당신은 여자인가요? (y/n)");
        Console.Write("답: ");
        var 임력1 = Console.ReadLine();

        if (임력1 == "y")
        {
            Console.WriteLine("당신은 여자입니다.");
        }
        else
        {
            if (임력1 == "n")
            {
                Console.WriteLine("당신은 남자입니다.");
            }
            else
            {
                Console.WriteLine("당신은 중성입니다.");
            }
        }
        Console.WriteLine("\n");


        Console.WriteLine("8-3 else if문 - 다중if, 조건식 여러개 처리");

        //else if를 활용한 양수 or 음수 or 0 인지 확인하는 시스템

        int 양수1 = -1;

        if (양수1 > 0)    //양수인지 판단
        {
            Console.WriteLine("양수입니다.");
        }
        else if (양수1 < 0) //음수인지 판단
        {
            Console.WriteLine("음수입니다.");
        }
        else
        {
            Console.WriteLine("0입니다.");
        }

        //else if를 활용한 성적 등급 프로그램

        int 점수1 = 0;
        Console.Write("당신의 점수는? ");
        점수1 = Convert.ToInt32(Console.ReadLine());

        if (점수1 >= 90) //90보다 높으면 A
        {
            Console.WriteLine("A");
        }
        else if (점수1 >= 80) //80보다 높으면 B
        {
            Console.WriteLine("B");
        }
        else if (점수1 >= 70) //70보다 높으면 C
        {
            Console.WriteLine("C");
        }
        else if (점수1 >= 60) //60보다 높으면 D
        {
            Console.WriteLine("D");
        }
        else // 60보다 낮으면 F
        {
            Console.WriteLine("F");
        }

        Console.WriteLine("\n8-4 switch문으로 다양한 조건 처리하기");

        //switch문으로 객관식문제 출제하기

        Console.WriteLine("가장 좋아하는 프로그래밍 언어는? ");
        Console.WriteLine("1.C++          2.C#");
        Console.WriteLine("3.Java         4.Nocode");
        Console.Write("답: ");
        var 문제 = Console.ReadLine();

        switch (Convert.ToInt32(문제))
        {
            case 1: // 1번 선택 시
                Console.WriteLine("C++을 선택했습니다.");
                break;
            case 2: // 2번 선택 시
                Console.WriteLine("C#을 선택했습니다");
                break;
            case 3: // 3번 선택 시
                Console.WriteLine("Java를 선택했습니다.");
                break;
            case 4: // 4번 선택 시
                Console.WriteLine("Nocode를 선택했습니다..");
                break;
            default:    //if문의 else와 흡사하다.
                Console.WriteLine("; _ ;....????");
                break;
             }

                //switch문은 문자열로도 가능하다.

                Console.Write("날씨는 어떻습니까?(맑음, 흐림, 비, 눈 中) ");
                string 날씨 = Console.ReadLine();

                switch (날씨)
                {
                    case "맑음":
                        Console.WriteLine("맑아요");
                        break;
                    case "흐림":
                        Console.WriteLine("흐려요");
                        break;
                    case "비":
                        Console.WriteLine("비 와요");
                        break;
                    case "눈":
                        Console.WriteLine("눈 와요");
                        break;

                    default:
                        Console.WriteLine("몰라요");
                        break;
                }
        }
    }
}
