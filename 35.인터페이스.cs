using System;
using System.Collections.Generic;


class 인터페이스
{

    static void Main(string[] args)
    {
        Console.WriteLine("35.인터페이스(interface)");
        Console.WriteLine("표준 규약을 정하고 따를 수 있도록 강제함");
        Console.WriteLine("- 실행 가능한 코드와 데이터를 포함하고 있지 않다.");
        Console.WriteLine("- 다른 클래스에 멤버 이름을 미리 정의할 때 사용");
        Console.WriteLine("- 메서드, 속성, 인덱서 및 이벤트를 정의 가능");
        Console.WriteLine("- 전 세계 표준과 같은 기능");
        Console.WriteLine("- 다중 상속이 가능하다");
        Console.WriteLine("- 항상 public 키워드가 암묵적으로 합류");
        Console.WriteLine("- 인터페이스의 이름은 대문자 I로 시작");
        Console.WriteLine("- 인스턴스화 불가능 (클래스를 통해서 해야됨)");
    }
}


//35-1 인터페이스로 특정 멤버가 반드시 구현되어야 함을 보증

namespace interfaceNote
{
    interface ICer
    {
        void Go(); //메서드 시그니처만 제공
    }

    class Car : ICer
    {
        public void Go()
        {
            Console.WriteLine("상속한 인터페이스에 정의된 모든 멤버를 반드시 구현해야 된다.");
        }
    }

    class interfaceNote
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Go();
        }
    }
}


//35-2 인터페이스 형식 개체에 인스턴스 담기

public interface IRepository //멤버 하나를 갖는 인터페이스 정의
{
    void Get();
}

public class Repository : IRepository
{
    public void Get()
    {
        Console.WriteLine("Get 메서드를 구현해야 합니다.");
    }
}

class InterfacePractice
{
    static void Main(string[] args)
    {
        //인터페이스 형식 개체에 인스턴스 담기
        IRepository repository = new Repository();
        repository.Get();
    }
}



//35-3 생성자의 매개변수에 인터페이스 사용하기
//매개변수로 사용하면 인터페이스를 상속하는 모든 클래스의 인스턴스를 받을 수 있음

namespace interfaceDemo
{
    interface IBattery
    {
        string GetName();
    }

    class Good : IBattery
    {
        public string GetName()
        {
            return "Good";
        }
    }

    class Bad : IBattery
    {
        public string GetName()
        {
            return "Bad";
        }
    }

    class Car
    {
        private IBattery _battery; //인터페이스 형식 필드

        public Car(IBattery battery)
        {
            _battery = battery; //생성자로 필드 값 초기화
        }

        public void Run() //출력 메서드
        {
            Console.WriteLine($"배터리 상태가 {_battery.GetName()}입니다!!!");
        }
    }

    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            Car car = new Car(new Good());
            car.Run(); //배터리 상태가 Good입니다!!!

            new Car(new Bad()).Run(); //개체 만들기와 동시에 메서드 실행
            //배터리 상태가 Bad입니다!!!

        }
    }
}


//35-4 인터페이스를 사용한 다중 상속 구현하기

namespace InterfaceInheritance
{
    interface IAnimal
    {
        void Eat();
    }

    interface IDog
    {
        void Yelp();
    }

    class Dog : IAnimal, IDog //다중 상속 
    {
        public void Eat() => Console.WriteLine("먹다.");
        public void Yelp() => Console.WriteLine("짖다");
    }

    class InterfaceInheritance
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(); //개체 생성
            dog.Eat(); //먹다.
            dog.Yelp(); //짖다
        }
    }
}



//35-5 명시적인 인터페이스 구현하기
//다중 상속에서 동일한 이름의 멤버를 명시해서 구분

interface IDog
{
    void Eat();
}

interface ICat
{
    void Eat();
}

class Pet : IDog, ICat //다중 상속 인터페이스
{
    void IDog.Eat() => Console.WriteLine("Dog Eat");
    void ICat.Eat() => Console.WriteLine("Cat Eat");
}

class InterfaceExplicit
{
    static void Main(string[] args)
    {
        //pet 개체를 인터페이스 형식으로 변환해서 구분
        Pet pet = new Pet(); //인스턴스 생성
        ((IDog)pet).Eat(); //Dog Eat
        ((ICat)pet).Eat(); //Cat Eat


        //따로따로 인스턴스를 생성해서 구분
        IDog dog = new Pet();
        dog.Eat(); //Dog Eat
        ICat cat = new Pet();
        cat.Eat(); //Cat Eat
    }
}



//35-6 IEnumerator 인터페이스 사용하기

class IEnumeratorDemo
{
    static void Main(string[] args)
    {
        string[] names = { "닷넷 코리아", "비주얼아카데미" };


        //foreath 문으로 출력
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }


        //IEnumerator 인터페이스를 사용한 데이터 출력: foreath 문과 동일
        IEnumerator list = names.GetEnumerator();
        while (list.MoveNext())
        {
            Console.WriteLine(list.Current);
        }


        
    }
}



//35-7 IDisposable 인터페이스 사용하기
//using 개체를 다 사용하고 마지막으로 호출해서 정리하는 역할을 한다.

class IDisposableDemo
{
    static void Main(string[] args)
    {
        Console.WriteLine("[1] 잘가");

        
        //특정 프로세스를 종료하면 자동으로 닫기 수행
        using (var t = new Toilet())
        {
            Console.WriteLine("[2] 사용");
        }
    }

}

public class Toilet : IDisposable
{


    public void Dispose()
    {
        Console.WriteLine("[3] 닫기");
    }
}


//35-8 인터페이스를 사용하여 멤버 이름 강제로 적용하기


namespace InterfaceFriends
{
    
    //1 인터페이스
    public interface IStandard
    {
        void Run();
    }

    //2 추상 클래스
    public abstract class KS
    {
        public abstract void Back();
        public void Left() => Console.WriteLine("좌회전");
    }


    //3 분할 클래스
    public partial class MyCar : KS
    {
        public override void Back() => Console.WriteLine("후진");
    }

    public partial class MyCar
    {
        public void Right() => Console.WriteLine("우회전");
    }

    
    //4 봉인(최종) 클래스
    //상속을 줄 수 없는 클래스

    public sealed class Car : MyCar, IStandard
    {
        public void Run() => Console.WriteLine("전진");
    }


    class InterfaceFriends
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Run(); //전진
            car.Left(); //좌회전
            car.Right(); //우회전
            car.Back(); //후진
        }
    }


}
