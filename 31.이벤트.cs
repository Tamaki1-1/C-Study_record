using System;


class eventt
{


    static void Main(string[] args)
    {
        Console.WriteLine("31.이벤트(event) - 특정 상황이 발생할 때 개체 또는 클래스에서 알림을 제공할 수 있도록 하는 멤버");
        Console.WriteLine("ex) 버튼 클릭과 마우스 오버");
        Console.WriteLine("- 이벤트는 개체의 메서드 실행 결과(사고)를 나타냅니다.");
        Console.WriteLine("- 마우스 클릭 이벤트, 마우스 오버 이벤트, 마우스 아웃 이벤트 같은 이벤트 표현");
        Console.WriteLine("- 웹 응용 프로그래밍 및 데스크톱 응용 프로그램에서 많은 이벤트 사용");

        Console.WriteLine();
        Console.WriteLine("이벤트 - 클릭과 마우스 오버 같은 동작 (트리거)");
        Console.WriteLine("이벤트 처리기: 특정 이벤트를 담당하려고 만든 메서드");

    }
}


public class buttonclass
{
    // 대리자 생성
    public delegate void EventHandler(); //메서드를 여러 개 등록 후 호출 가능5.

    //이벤트 선언
    public event EventHandler Click;

    //이벤트 발생 메서드: OnClick 이벤트 처리기(핸들러) 생성
    public void Onclick()
    {
        if (Click == null) //이벤트에 등록된 값이 있는지 확인(생략 가능)
        {
            Click(); //대리자 형식의 이벤트 수행
        }
    }
}

    class EventDemo
    {
        static void Main(string[] args)
        {
            buttonclass buttonclass1 = new buttonclass(); //인스턴스 생성

            //개체의 Click 이벤트에 실행할 메서드들 목록
            buttonclass1.Click += Hi;
            buttonclass1.Click += HI2;

            buttonclass1.Onclick(); //이벤트 처리기(발생 메서드)를 사용한 이벤트 발생: 다중 메서드 호출

        }

        static void Hi() => Console.WriteLine("C#");
        static void HI2() => Console.WriteLine(".NET");
    }
