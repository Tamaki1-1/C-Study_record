using System;
using System.ComponentModel;

class 튜플
{
    static void Main(string[] args)
    {
        Console.WriteLine("41.튜플 - 값을한번에 하나 이상 전달하거나 제공 받을 때 사용하는 데이터 구조");
        (int x, int y) GetPoint()
        {
            return (10, 20);
        }

        Console.WriteLine(GetPoint().x); //10
        Console.WriteLine(GetPoint().y); //20


        Console.WriteLine("튜플의 장점");
        Console.WriteLine("1.명시적인 형식을 지정할 필요가 없다. 컴파일러 형식을 유추하여 자동으로 형식을 제공");
        Console.WriteLine("2.기존에 사용하던 Tuple 클래스는 Item1, Item2,... 형태로 접근했지만,\n" +
        "튜플을 사용하면 원하는 이름의 속성을 만들 수 있습니다.");


        //튜플 리터럴(괄호를 사용하여 값을 하나 이상 설정하는 것)
        var r = (13, 22, 2);
        Console.WriteLine($"{r.Item1} {r.Item2} {r.Item3}");

        //튜플 리터럴의 여러가지 사용법
        //기본 형태
        var fhd = (1920, 1080);
        Console.WriteLine($"Full HD: {fhd.Item1} * {fhd.Item2}"); //Full HD: 1920 * 1080

        //이름 지정
        var uhd = (Width: 1920, Height: 1080);
        Console.WriteLine($"{uhd.Width} * {uhd.Height}");

        //이름과 형식 지정
        (ushort Width, ushort Height) aa = (1366, 768);
        Console.WriteLine($"{aa.Width} * {aa.Height}");

        //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
        //튜플 반환 - 한 번에 하나 이상을 반환시켜 주는 기능

        //튜플 리턴(Tuple Return) 형식: (int, int)
        static (int, int) Tally1()
        {
            var r = (12, 3); //튜플 리터럴에 값 2개 담기
            return r;
        }
        Console.WriteLine(Tally1()); //(12, 3)

        //튜플 리턴에 이름 값 지정 가능
        static (int Sum, int Count) Tally2() => (45, 6); //람다 식으로 가능

        Console.WriteLine(Tally2()); //(45, 6)

        //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
        //이름이 지정된 튜플
        //튜플 리터럴에는 Item1, Item2 형태보다는 좀 더 의미 있는 이름을 지정
        var boy = (Name: "철수", IsStudent: true, OrderPrice: 1000);
        Console.WriteLine($"{boy.Name}(초등학생: {boy.IsStudent}) - 주문: {boy.OrderPrice}"); //철수(초등학생: True) - 주문: 1000


        //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
        //튜플 반환에 기본값 설정하기
        //default 키워드를 사용하여 튜플의 기본 반환값을 설정하는 방법

        static (int, int) ZeroZero()
        {
            return default;
        }

        var t = ZeroZero();
        Console.WriteLine($"{t.Item1}, {t.Item2}"); //0, 0


        //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
        //튜플 반환값에 이름 지정하기
        //튜플의 반환값에 의미 있는 이름을 지정하는 방법

        static (int first, int second) NameTuple()
        {
            var r = (100, 200);
            return r;
        }

        var ss = NameTuple(); //ss에 튜플으로부터 넘어온 값 저장
        Console.WriteLine($"{ss.first}, {ss.second}"); //100, 200
    }
}



//41-1 튜플 분해(튜플 해체)하기
//- 튜플 반환 값을 원하는 변수로 받아 사용하는 형태

class TupleDeconstructionDescription
{
    static void Main(string[] args)
    {
        var (sum, count) = Tally(); //Tally의 값 저장(매개변수의 순서대로)
        Console.WriteLine($"Sum: {sum}, {count}");


    }
    static (int Sum, int Count) Tally()
    {
        var r = (s: 12, c: 3);
        Console.WriteLine($"{r.s}, {r.c}"); //생성자랑 비슷함
        return r;
    }
}


//41-2 로컬 함수와 튜플 함께 사용하기

class LocalFunctionDescription
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 4, 8 };
        var (sum, count) = Tally(numbers);
        Console.WriteLine($"합계: {sum}, 건수: {count}"); //합계: 15, 건수: 4

    }

    static (int _Sum, int _Count) Tally(int[] value)
    {
        var r = (Sum: 0, Count: 0);
        foreach (var item in value)
        {
            Add(item, 1);
        }
        return r;


        void Add(int s, int c)
        {
            r.Sum += s; //합계
            r.Count += c; //건수
        }
    }
}
