using System;

class 생성자
{

    static void Main(string[] args)
    {
        Console.WriteLine("25. 생성자 - 개체를 생성하면서 무엇인가를 하고자 할 때 사용하는 메서드");
        Console.WriteLine("- 생성자 이름이 클래스 이름과 동일하다");
        Console.WriteLine("- 생성자는 void를 포함한 반환값을 가지지 않는다");


    }
}


//25-1 매개변수가 없는 생성자


class Car //클래스
{
    public Car() //생성자 (클래스와 이름이 동일)
    {
        Console.WriteLine("생성자"); //인스턴스가 생성될 때 자동으로 Car() 생성자가 실행딘다.
    }

    static void Main(string[] args)
    {
        Car car = new Car(); //실행됨 "생성자"
    }
}



//25-1 매개변수가 없는 생성자 2


class Student
{
    public Student() //매개변수가 없는 인스턴스 생성자
    {
        Console.WriteLine("Student 개체가 생성됩니다.");
    }

    static void Main(string[] args)
    {
        Student student;
        student = new Student(); //인스턴스 생성. 즉 생성자 실행
    }
}


//25-2 매개변수가 있는 생성자 만들기

public class Dog
{
    private string name; //필드
    public Dog(string name) //매개변수가 있는 생성자
    {
        this.name = name; //입력받은 값을 name 필드에 저장
    }
    public string Cry() //반환용 메서드
    {
        return (name + "이(가)멍멍멍");
    }

}

class 메인
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("해피"); //매개변수 입력
        Console.WriteLine(dog.Cry()); //반환 메서드. (해피이(가)멍멍멍)

        Dog 진돗개 = new Dog("이누");
        Console.WriteLine(진돗개.Cry()); //반환 메서드. 이누가 멍멍멍
    }
}


//25-3 매개변수가 여러 개인 생성자 만들기

namespace ConstructorParameter
{
    class My
    {
        private string name;
        private int age;

        public My(string name, int age) //매개변수가 2개인 생성자
        {
            this.name = name; //입력받은 값을 name 필드에 초기화
            this.age = age; //입력받은 값을 age 필드에 초기화
        }

        public void Print() //출력 메서드
        {
            Console.WriteLine($"이름:{this.name}, 나이:{this.age}");
        }
    }

    class 메인
    {
        static void Main(string[] args)
        {
            My my = new My("카나시이", 7); //인스턴스 생성과 동시에 필드 값 초기화
            my.Print(); //이름:카나시이, 나이:7
        }
    }
}


//25-4 매개변수가 있는 생성자로 원의 넓이를 구하는 프로그램 만들기

public class Circle
{
    private int radius; //필드
    public Circle(int radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return radius * radius * Math.PI; //원의 면적을 구하는 공식
    }
}

class 메인
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(10);
        Console.WriteLine(circle.GetArea()); //314.1592653589793

        var cricle2 = new Circle(5);
        Console.WriteLine(cricle2.GetArea()); //78.53981633974483
    }
}


//25-5 클래스에 생성자 여러 개 만들기(매개변수를 달리하여 생성자를 여러개 만들 수 있음)
// -생성자 오버로드

class ConstructorLog
{
    public ConstructorLog() //매개변수가 없는 생성자
    {
        Console.WriteLine("기본 생성자 실행");
    }

    public ConstructorLog(string 메세지) //매개변수가 있는 생성자
    {
        Console.WriteLine($"오버로드된 생성자 실행: {메세지}");
    }
}

class 메인
{
    static void Main(string[] args)
    {
        ConstructorLog constructorLog = new ConstructorLog(); //기본 생성자 실행
        var 생성자오버로드 = new ConstructorLog("안녕"); //오버로드된 생성자 실행: 안녕
    }
}


//25-6 정적 생성자(static)와 인스턴스(public) 생성자

namespace ConstructorAll
{
    public class Person
    {
        private static readonly string name; //필드
        private int age;
        static Person() //static 정적 생성자
        {
            name = "백승수";
        }

        public Person()
        {
            this.age = 21;
        }
        public Person(int age) //인스턴스 생성자
        {
            this.age = age;
        }

        public static void Show()
        {
            Console.WriteLine($"이름: {name}");
        }

        public void Print()
        {
            Console.WriteLine($"나이: {age}");
        }
    }
    class 메인
    {
        static void Main(string[] args)
        {
            Person.Show(); // 정적 생성자 실행 후 Show 메서드 실행
            
            Person person = new Person(); //인스턴스 선언 및 생성자 실행
            person.Print(); //Print 메서드 실행

            (new Person(32)).Print(); //매개변수가 있는 생성자로 실행  
        }
    }
}


//25-7 this() 생성자로 다른 생성자 호출하기

class Say
{
    private string 메세지 = "[1] 안녕하세요";
    public Say()
    {
        Console.WriteLine(this.메세지);
    }

    public Say(string 메세지) : this() // this() 생성자로 자신의 매개변수가 없는 생성자를 먼저 호출
    {
        this.메세지 = 메세지;
        Console.WriteLine(this.메세지);
    }
}

class 메인
{
    static void Main(string[] args)
    {
        Say say = new Say(); //[1] 안녕하세요
        var say2 = new Say("[2] 잘가세요"); //[1] 안녕하세요 //[2] 잘가세요

        
    }
}


//25-8 생성자 포워딩 - this()를 사용하면 생성자를 포워딩 할 수 있으므로 다른 생성자에 값을 전달하기 좋다

class Money
{
    public Money() : this(1000) //아래 생성자로 전송
    {
       //Enepy
    }
    public Money(int money) //매개변수가 있는 생성자
    {
        Console.WriteLine($"현금: {money:#,###}");
    }
}

class 메인
{
    static void Main(string[] args)
    {
        Money money = new Money(); //현금: 1,000
        var money2 = new Money(30000); //현금: 30,000
    }
}


//25-9 생성자를 사용하여 읽기 전용 필드(readonly) 초기화

public class 읽기전용필드
{
    private readonly string 서비스이름; //읽기 전용 필드

    public 읽기전용필드(string 서비스이름) //인스턴스 생성시 읽기 전용 필드 초기화 시키는 생성자
    {
        this.서비스이름 = 서비스이름;
    }

    public void Run() //출력 메서드
    {
        Console.WriteLine($"{서비스이름} 기능을 실행합니다.");
    }
}

class 메인
{
    static void Main(string[] args)
    {
        읽기전용필드 읽기 = new 읽기전용필드("[1] 파일 로그"); //readonly(읽기 전용 필드) 초기화
        var 읽기2 = new 읽기전용필드("[2] DB 로그"); //마찬가지로 초기화
        읽기.Run(); //[1] 파일 로그 기능을 실행합니다.
        읽기2.Run(); //[2] DB 로그 기능을 실행합니다.
    }
}


//25-10 식 본문 생성자 

class Pet
{
    private string name;

    public Pet(string name) => this.name = name;
    public override string ToString() => name; //return은 화살표 연산자로 하면 생략


}

class 메인
{
    static void Main(string[] args)
    {
        Pet pet = new Pet("야옹");
        Console.WriteLine(pet.ToString()); //야옹
    }
}








