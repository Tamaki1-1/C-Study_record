using System;
using System.Security.Cryptography.X509Certificates;

class 튜플
{
    static void Main(string[] args)
    {
        Console.WriteLine("41.튜플");
        Console.WriteLine("값을 한번에 하나 이상 전달하거나 제공받을 때 사용하는 데이터 구조");
        Console.WriteLine("클래스를 만들지 않고도 언어 차원에서 값을 여러 개 전달할 수 있다.");

        //튜플의 생성 방식
        (int x, int y) GetPoint()
        {
            return (10, 20);
        }

        Console.WriteLine(GetPoint().x); //10
        Console.WriteLine(GetPoint().y); //20


        //튜플의 장점
        Console.WriteLine("1.명시적인 형식을 지정할 필요가 없습니다. 컴파일러 형식을 유추하여 자동으로 형식을 제공합니다.");
        Console.WriteLine("2.기존의 Tuple 클래스는 Item1, Item2 형태로 접근했지만, 튜플을 사용하면 원하는 이름의 속성을 사용할 수 있다.");


        //튜플 리터럴 - 변수에 괄호를 사용하여 하나 이상의 값을 설정하는 것
        var r = (12, 24, 36);
        Console.WriteLine($"{r.Item1}, {r.Item2}, {r.Item3}"); //12, 24, 36


        //튜플의 여러가지 사용 법

        //기본 형태: item1, item2....
        var fhd = (1920, 1080);
        Console.WriteLine($"{fhd.Item1}, {fhd.Item2}"); //1920, 1080

        //이름 지정
        var uhb = (Width: 3840, Height: 2160);
        Console.WriteLine($"{uhb.Width} * {uhb.Height}"); //3840 * 2160

        //이름과 형식 지정
        (ushort Width, ushort Height) hd = (1366, 768); 
        Console.WriteLine($"{hd.Width} * {hd.Height}"); //1366 * 768
        Console.WriteLine($"{hd.Width.GetType()}"); //System.UInt16


        //튜플 반환 - 한번에 하나 이상을 반환시켜 주는 기능
        
        //튜플 리턴(Tuple Return) 형식: (int, int)
        static (int, int) Tally1()
        {
            var r = (12, 3); //튜플 리터럴에 값 2개 담기
            return r; //튜플 리터럴 반환
        }

        static (int Sum, int Count) Tally2() => (45, 6);

        var t1 = Tally1();
        Console.WriteLine($"{t1.Item1}, {t1.Item2}"); //12, 3

        var t2 = Tally2();
        Console.WriteLine($"Sum: {t2.Sum}, Count: {t2.Count}"); //Sum: 45, Count: 6
    }
}
