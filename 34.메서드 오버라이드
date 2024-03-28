using System;
using System.Runtime.CompilerServices;


class 오버라이드
{
    static void Main(string[] args)
    {
        Console.WriteLine("34.메서드 오버라이드");
        Console.WriteLine("부모 클래스에 만든 메서드를 자식 클래스에서 다시 새롭게 만들어 사용하는 것");
        Console.WriteLine("클래스 관계를 따지는 상속 개념에서 부모 클래스에 이미 만든 메서드를 동일한 이름으로 " +
                        "\n자식 클래스에서 다시 정의(재정의)해서 사용한다는 개념");

        Console.WriteLine("-메서드를 새롭게 정의한다는 뜻");
        Console.WriteLine("-오버라이드, 오버라이딩이라는 표현은 동일");
        Console.WriteLine("-virtual 키워드로 선언해 놓은 메서드는 자식 클래스에서 override 키워드로 재정의해서 사용 가능");
    }

    
}


//34-1 상속 관계에서 메서드 오버라이드

public class Parant
{
    public void Say() => Console.WriteLine("부모_안녕하세요");
    public void Run() => Console.WriteLine("부모_달리다");
    public virtual void Walk() => Console.WriteLine("부모_걷다");
}

public class Child : Parant
{
    public void Say() => Console.WriteLine("자식_안녕하세요.");
    //new 키워드로 재정의
    public new void Run() => Console.WriteLine("자식_달리다");

    public override void Walk() => Console.WriteLine("자식_걷다");
}

class main
{
    static void Main(string[] args)
    {
        Child child = new Child();
        child.Say(); // 자식_안녕하세요.
        child.Run(); // 자식_달리다
        child.Walk();// 자식_걷다
    }
}


//34-2 메서드 오버로드와 오버라이드
//오버로드는 여러 번 정의하는 것
//오버라이드는 다시 정의하는 것
//ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
class 오버로드
{
    static void Print(int number) => Console.WriteLine(number);
    static void Print(ref int number) => Console.WriteLine(++number);

    static void Main(string[] args)
    {
        int number = 100;

        Print(number); //100
        Print(ref number); //101 //ref로 값 전달
        Print(number); //101
       
    }
}

//ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
public class 오버라이드_부모
{
    public virtual void Work() => Console.WriteLine("프로그래머");
}
public class 오버라이드_자식 : 오버라이드_부모
{
    public override void Work() => Console.WriteLine("프로게이머");
}

class 메인
{
    static void Main(string[] args)
    {
        오버라이드_자식 자식 = new 오버라이드_자식();
        자식.Work(); //프로 게이머

        new 오버라이드_부모().Work(); //프로그래머
    }
}

//ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ


//34-3 가상 메서드(virtual) - 재정의해서 사용하도록 허용한다는 키워드

class Animal
{
    public virtual void Eat() => Console.WriteLine("Animal Eat");
}

class Cat : Animal
{
    public override void Eat() => Console.WriteLine("Cat Eat"); //override로 재정의
}

class 메인
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.Eat();

        Cat cat = new Cat();
        cat.Eat();

    }
}


//34-4 메서드 오버라이드 봉인(sealed) - 오버라이드해서 사용하지 못하게 함

class Parent
{
    public virtual void Work() => Console.WriteLine("프로그래머");
}

class Child : Parent
{
    //sealed(봉인) - 오버라이드 불가능
    public override sealed void Work() => Console.WriteLine("프로게이머");
}

class GrandChild : Child
{
    //<Error> sealed 키워드가 붙은 메서드는 재정의가 불가능하다.
    public override void Work() => Console.WriteLine("; - ;..."); 
}


//34-5 ToString() 메서드 오버라이드
// - 기본적으로 클래스의 이름 값을 반환합니다.
// - 정수형처럼 대표되는 값은 그 값을 문자열로 변환해서 출력
// - 대표되는 속성 또는 값을 외부에 인스턴스 이름으로 출력할 때는 ToString() 메서드를 재정의해서 사용해야 됨


namespace ClassToString
{
    class Person
    {
        private string name; //필드
        public Person(string 이름)
        {
            this.name = 이름; //필드를 매개변수로 초기화
        }

        public override string ToString()
        {
            return $"[Person의 클래스: {this.name}]";
        }
    }

    class ClassToString
    {
        static void Main(string[] args)
        {
            Person person = new Person("박새로이");
            //개체를 문자열로 출력하면 ToString()이 호출됨
            Console.WriteLine(person); //[Person의 클래스: 박새로이]
        }
    }
}


//34-6 메서드 오버라이드로 메서드 재사용하기
//부모 클래스의 메서드 이름을 다시 쓰고 싶다면 메서드 오버라이드 기능을 이용합니다.

namespace MethodOverridePractice
{
    public class ParentClass
    {
        public virtual void Hi1() => Console.WriteLine("기본: 안녕하세요.");
        public void Hi2() => Console.WriteLine("기본: 반갑습니다.");
        public void Hi3() => Console.WriteLine("기본: 또 만나요.");
    }

    public class ChildClass : ParentClass
    {
        public override void Hi1() => Console.WriteLine("파생: 안녕하세요");
        public new void Hi2() => Console.WriteLine("파생: 반갑습니다");

        public new void Hi3() => base.Hi3(); //부모 클래스의 멤버에 접근
    }

    class Parent
    {
        public void Say() => Console.WriteLine("부모가 말하다");
        public void Hi() => Console.WriteLine("부모가 인사하다");
        public virtual void Walk() => Console.WriteLine("부모가 걷다");
    }

    class Child : Parent
    {
        public void Say() => Console.WriteLine("자식이 말하다");
        public new void Hi() => Console.WriteLine("자식이 인사하다"); //new = 새롭게 정의
        public override void Walk() => Console.WriteLine("자식이 걷다"); //override = 재정의
    }

    class MethodOverridePractice
    {
        static void Main(string[] args)
        {
            ChildClass childClass = new ChildClass();
            childClass.Hi1(); //파생: 안녕하세요
            childClass.Hi2(); //파생: 반갑습니다
            childClass.Hi3(); //기본: 또 만나요.

            Child child = new Child();
            child.Say(); //자식이 말하다
            child.Hi(); //자식이 인사하다
            child.Walk(); //자식이 걷다
        }
    }
}
