using System;




class 상속
{
    static void Main(string[] args)
    {
        Console.WriteLine("33. 상속으로 클래스 확장하기");
        Console.WriteLine();

        Console.WriteLine("개체 관계 프로그래밍(object relationship programming)");
        Console.WriteLine("- 클라스 간에 부모와 자식 관계를 설정 할 수 있음");

        Console.WriteLine("\n상속(inheritance)");
        Console.WriteLine("- 부모 클래스에 정의된 기능을 다시 사용하거나 확장 또는 수정하여 자식 클래스로 만드는 것");
        Console.WriteLine("- 부모와 자식 간 관계처럼 게층적인 관계를 표현할 때 사용됨");

        Console.WriteLine("\n상속의 종류");
        Console.WriteLine("-단일 상속");
        Console.WriteLine("-다중 상속");

        Console.WriteLine("\n클래스 상속 구문 - 클래스 이름 뒤에 : 기호와 부모가 되는 클래스 이름을 붙임");
    }

    public class 기본클래스이름 { } //기본(부모) 클래스
    public class 파생클래스이름 : 기본클래스이름 { } //파생(자식)클래스 : 기본(부모)클래스 
}


//33-1 부모 클래스와 자식 클래스
//부모 클래스 => 상속을 주는 클래스
//자식 클래스 => 상속을 받는 클래스
//*부모 클래스의 멤버는 public or protected 엑세스 한정자를 붙여야 사용 가능

namespace InheritanceDemo
{
    class 부모 //기본(부모) 클래스
    {
        public void Foo()
        {
            Console.WriteLine("부모 클래스의 멤버 호출");
        }
    }

    class 자식 : 부모 //파생(자식) 클래스
    {
        public void Bar() => Console.WriteLine("자식 클래스의 멤버 호출");
    }

    class InheritanceDemo
    {
        static void Main(string[] args)
        {
            자식 후레자식 = new 자식(); //파생(자식) 클래스의 인스턴스 생성
            후레자식.Bar(); //자식 클래스의 멤버 호출
            후레자식.Foo(); //부모 클래스의 멤버 호출
        }
    }
}


//33-2 Base 클래스와 Sub 클래스
//부모 클래스 => 기반 클래스, 기본 클래스, 슈퍼 클래스
//자식 클래스 => 파생 클래스, 서브 클래스

public class BaseClass
{
    public void Do() => Console.WriteLine("Base 클래스에서 정의된 메서드");
}

public class SubClass : BaseClass { } // 빈 클래스


class MainClass
{
    static void Main(string[] args)
    {
        SubClass subClass = new SubClass(); //SubClass 개체 생성
        subClass.Do(); //Base 클래스에서 정의된 메서드
    }
}


//33-3 Object 클래스 상속
//모든 클래스는 내부적으로 Object 클래스(조상 클래스)를 상속 받는다.
//기본적으로 생략되어서 사용하지는 않음

public class Parent : System.Object
{
    public void Hi() => Console.WriteLine("안녕하세요");
}

public class Child : Parent
{
    public void Hello() => Console.WriteLine("ㅎㅇ");
}

class 메인
{
    static void Main(string[] args)
    {
        Child child = new Child(); //자식 클래스에 개체 생성
        child.Hi(); //안녕하세요
        child.Hello(); //ㅎㅇ

    }
}


//33-4 부모 클래스 형식 변수에 자식 클래스의 개체 할당하기
//override 키워드 -> Object 클래스의 ToString() 메서드를 재정의하겠다는 의미
//클래스 자신을 호출 시 재정의한 값이 출력

class Developer
{
    public override string ToString()
    {
        return "개발자";
    }
}
class WebDeveloper : Developer
{
    public override string ToString()
    {
        return "웹 개발자";
    }
}

class MobileDeveloper : Developer
{
    public override string ToString()
    {
        return "모바일 개발자";
    }
}

class 메인
{
    static void Main(string[] args)
    {
        WebDeveloper webDeveloper = new WebDeveloper();
        Console.WriteLine(webDeveloper); //웹 개발자

        MobileDeveloper mobileDeveloper = new MobileDeveloper();
        Console.WriteLine(mobileDeveloper); //모바일 개발자

        Developer developer = new Developer();
        Console.WriteLine(developer); //개발자
    }
}


//33-5 상속은 영어로 is a(is an) 관계를 표현
//자동차(자식)은 운송 수단(부모)입니다.

namespace IsAn
{
    class Vehicle { }
    
    class Car : Vehicle{ }

    class Airplane : Vehicle { }

    class IsAn
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(); //운송 수단(탈 것) is a Vehicle

            Car car = new Car(); //자동차 is a Vehicle

            Airplane airplane = new Airplane(); //비행기 is a Vehicle


            //개체를 문자열로 출력하면 ToString() 메서드가 실행 됨 (override로 변경 가능)
            Console.WriteLine($"{vehicle}\n{car}\n{airplane}"); 
            //IsAn.Vehicle
            //IsAn.Car
            //IsAn.Airplane
        }
    }
}



//33-6 this와 this() 그리고 base와 base()
//this - 자신, this() - 자신의 생성자
//base - 부모 클래스, //base() - 부모 클래스의 메서드

//protected(엑세스 한정자) - 자식 클래스에서만 접근 가능

namespace ClassInheritance
{
    public class ParantClass : Object //모든 클래스는 Object 클래스에서 상속(조상 클래스)
    {
        protected void Print1() => Console.WriteLine("부모 클래스에서 정의한 내용");
    }

    public class ChildClass : ParantClass // :(콜론) 기호로 부모 클래스 지정
    {
        public void Print2() => base.Print1(); //자식에서 base 키워드로 부모 요소에 접근
    }

    class Main1
    {
        static void Main(string[] args)
        {
            ParantClass parantClass = new ParantClass(); //부모 클래스 인스턴스 생성
            Console.WriteLine(parantClass); //ClassInheritance.ParantClass

            ChildClass childClass = new ChildClass(); //자식 클래스 인스턴스 생성
            childClass.Print2(); //부모 클래스에서 정의한 내용
        }
    }
}



//33-7 base 키워드를 사용하여 부모 클래스의 생성자 호출하기

namespace ConstructorBase
{
    class Parant
    {
        public Parant(string msg) //매개변수로 넘어온 값 출력
        {
            Console.WriteLine(msg);
        }
    }

    class Child : Parant
    {
        public Child(string msg) : base(msg) { } //base()를 사용하여 부모 클래스의 생성자 호출
    }

    class ConstructorBase
    {
        static void Main(string[] args)
        {
            string 메세지 = "자식 클래스에서 생성자를 호출할 때 부모 클래스의 생성자로 전달";
            Child child = new Child(메세지); //base 부모 클래스의 생성자를 호출
        }
    }
}


//33-8 base 키워드로 부모 클래스의 멤버의 접근

namespace BaseKeyword
{
    public class Car
    {
        private string _name; //필드
        public Car(string name) //생성자
        {
            this._name = name; //this(자신)
        }
        public void Run() => Console.WriteLine($"{this._name}이(가) 달립니다!!"); //출력 메서드

    }
    public class My : Car
    {
        public My() : this("나의 자동차") { } //this() 자신의 클래스 생성자 호출
        public My(string name) : base(name) { } //base() 부모의 클래스 생성자 호출
    }

    public class Your : Car
    {
        public Your() : base("너의 자동차") { } //base() 부모의 클래스 생성자 호출
    }

    
    class main
    {
        static void Main(string[] args)
        {
            My my = new My();
            my.Run(); //나의 자동차이(가) 달립니다!!

            My my2 = new My("나의 자전거");
            my2.Run(); //나의 자전거이(가) 달립니다!!


            //new 키워드로 인스턴스 없이 불러오기
            new Your().Run(); //너의 자동차이(가) 달립니다!!
        }
    }
}



//33-9 생성자 상속하기
//base() - 생성자 상속이라고도 함

namespace ConstructorInheritance
{
    public class Parent
    {
        public string Word { get; set; } //속성
        public Parent(string word) //생성자 (속성에 값 할당)
        {
            this.Word = word;
        }
    }

    public class Child : Parent
    {
        public Child() : this("[1] 매개변수가 없는 생성자 실행") { }

        public Child(string word) : base(word) { } //매개변수가 있는 생성자 (부모도 있으니 자식도 만들어야 됨)

        public void Print1() => Console.WriteLine(base.Word); //base(부모).Word(부모의 속성)
    }

    class ConstructorInheritance
    {
        static void Main(string[] args)
        {
            new Child().Print1(); //[1] 매개변수가 없는 생성자 실행
            new Child("[2] 매개변수가 있는 생성자 실행").Print1(); //[2] 매개변수가 있는 생성자 실행
        }
    }
}



//33-10 봉인 클래스 (sealed class)(최종 클래스)
//다른 클래스에 "상속되지 않게" 할 때 사용하는 클래스
//즉, 부모 클래스로는 사용 못함


class Animal
{
    public void Eat()
    {
        Console.WriteLine("밥을 먹습니다.");
    }
}

sealed class Cat : Animal { } //봉인 클래스(최종 클래스)


////sealed 키워드가 붙은 클래스는 상속될 수 없음
//<Error> class MyCat : Cat { }




//33-11 추상 클래스 (abstract class)
//다른 클래스의 부모 또는 기본 클래스 역할을 한다.
// - 상속할 때 사용하는 클래스
// - 인스턴스화 불가능 (개체 생성 불가)
// - 부모 클래스 역할을 하면서 강제로ㅓ 자식에게 특정 멤버 이름을 물려줌
// - public 같은 엑세스 한정자를 사용함
// - 멤버로 필드, 속성, 생성자, 소멸자, 메서드, 이벤트, 인덱서를 가진다.

public abstract class TableBase
{
    public int ID { get; set; } //속성
    public bool Active { get; set; } //속성
}

//추상 클래스는 부모 역할을 하는데 사용 (강제성 때문에)
public class Child : TableBase
{
    public string Name { get; set; }
}

class Main1
{
    static void Main(string[] args)
    {
        Child child = new Child() { ID = 1, Active = true, Name = "아이" };

        if (child.Active) //true면 실행
        {
            Console.WriteLine($"{child.ID} - {child.Name}"); // 1 - 아이
        }
    }
}



//33-12 추상 클래스를 만들고 상속하기(추상 메서드는 강제성이 생김)

abstract class GeneralManager //추상 클래스
{
    public abstract void SayHumor(); //추상 메서드 - 메서드 본문 생략

    public abstract double GetArea(); //추상 멤버: 추상 메서드
}

class Person : GeneralManager //추상 클래스를 상속받는 자식 클래스
{
    public Person() { }

    //추상 메서드가 있기 때문에 "강제로" 구현해야 됨
    public override void SayHumor() //추상 메서드를 구현함
    {
        Console.WriteLine("1+1은? 노가다!");
    }


    //원의 넓이 구하기
    private int _size; //필드
    public Person(int size) //생성자로 초기화

    {
        this._size = size;
    }

    public override double GetArea()
    {
        return (_size * _size);
    }

}

class 메인
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.SayHumor(); //1+1은? 노가다!

        Person person1 = new Person(5);
        Console.WriteLine(person1.GetArea()); //5 * 5 = 25
    }
}



//33-13 자식 클래스에만 멤버 상속하기
//protected 엑세스 한정자 - 자식 클래스들까지 접근 가능

namespace FieldHiding
{
    class Parent
    {
        //필드 숨김: 필드는 무조건 private으로 설정
        private string _word;

        //protected는 자식 클래스에서만 호출 가능한 멤버
        protected string Word
        {
            get { return _word; } //필드의 값을 외부로 출고 get
            set { _word = value; } //값 받아와서 필드에 저장하기 set
        }
    }

    class Child : Parent
    {
        public void SetWord(string word)
        {
            base.Word = word;
        }

        public string GetWord()
        {
            return base.Word;
        }
    }

    class FieldHiding
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.SetWord("; _ ;...");
            Console.WriteLine(child.GetWord()); //; _ ;...
        }
    }
}



//33-14 기본 클래스의 멤버 숨기기(new)

class Parent
{
    public void Work() => Console.WriteLine("프로게이머");
}

class Child : Parent
{
    //기본 멤버 숨기기: new -> 새롭게 정의, 재정의, 다시 정의
    public new void Work() => Console.WriteLine("프로게이");
}

class 메인
{
    static void Main(string[] args)
    {
        Child child = new Child();
        child.Work(); //new 키워드로 "재정의"하여 프로게이 출력
    }
}






