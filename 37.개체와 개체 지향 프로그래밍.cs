using System;
using System.Collections;
using System.Collections.Generic;


class 개체지향프로그래밍
{
    static void Main(string[] args)
    {
        Console.WriteLine("37.개체 지향 프로그래밍");
        Console.WriteLine("개체 지향 프로그래밍의 목적ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("1.프로그램을 분석하기 쉬워진다.\n" +
                          "2.프로그램 유지보수가 쉬워진다.\n" +
                          "3.프로그램의 특정 기능을 재사용 할 수 있다.(Class의 개념이라)\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*개체");
        Console.WriteLine("클래스를 사용하여 새로운 형식을 정의하고,\n" +
                          "데이터와 기능을 숨기는 \"캡슐화\" 기능을 제공한다.");
        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        
    }
}


//37-1 현실 세계의 자동차 설계도 및 자동차 개체 흉내 내기

class 개체_지향_프로그래밍
{
    static void Main(string[] args)
    {
        Console.WriteLine("*개체 지향 프로그래밍ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("비유로 \'현실 세계를 프로그래밍 세계로 옮겨 놓는 행위\'가 적절하다.(다른 말로 '모델링'이라고 함)\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*클래스 == 설계도");
        Console.WriteLine("클래스는 개체, 컨트롤, 컴포넌트 등을 만들어 내는 설계도입니다.\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*개체(설계도로 만들어진 개체)");
        Console.WriteLine("현실 세계에서 어떤 특징(속성)을 가지며 어떤 동작(메서드)을 수행할 수 있는 단위 하나를 개체로 표현\n" +
                          "[빨간색 자동차 개체가 좌회전 동작을 한다] - (빨간색 자동차 == 어떤 특징(속성)), (좌회전 동작 == 어떤 동작(메서드))" +
                          "\nㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*필드(부품)");
        Console.WriteLine("필드는 클래스의 부품 역할을 하는 멤버 변수를 의미한다." +
                          "\nㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*생성자(시동 걸기)");
        Console.WriteLine("단어 그대로 개체를 생성하는 메서드이며, 생성자는 클래스 내 필드를 초기화하는 역할을 한다.\n" +
                          "생성자를 사용하는 클래스를 '인스턴스 클래스'라고 한다.\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*메서드(전진, 후진, 좌회전같은 동작)");
        Console.WriteLine("동작을 나타내며, 메서드 오버로드로 이름이 같은 메서드를 만들었고,\n" +
                          "메서드 오버라이드로 부모 클래스의 메서드를 새롭게 정의 할 수 있었다.\n" +
                          "메서드의 전달 방식으로 ref, out, in, params 등을 사용 할 수 있다.\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*속성(차의 색상, 모양같은 특징");
        Console.WriteLine("외부에 공개(public)하려는 부품을 나타낼 수 있고,\n" +
                          "private한 필드를 public한 속성으로 외부에 공개할 때 사용됨\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*인덱서(카탈로그/카테고리) - 속성의 배열형");
        Console.WriteLine("자신이 만든 개체를 배열 형식으로 사용할 수 있게 하는 개념이며\n" +
                          "인덱서는 정수형 인덱스를 사용하는 것과, 문자열 인덱스를 사용하는 것으로 구분함.\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*대리자(대리운전)");
        Console.WriteLine("이름 하나로 여러 메서드를 묶어 실행하는 구조이며, \n" +
                          "이벤트를 만들어 내는 또 다른 중간 단계로 사용된다.\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*이벤트(사건 및 사고)");
        Console.WriteLine("마우스 클릭 이벤트같이 무엇인가 실행된 결과를 의미한다.\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*네임스페이스(클래스 이름의 충돌 방지)");
        Console.WriteLine("클래스 이름의 충돌을 방지하려고 클래스를 묶어 주는 개념으로 사용된다.,\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*인터페이스(표준 설계 역할)");
        Console.WriteLine("메서드 이름 등을 강제로 정의할 수 있고, 큰 프로그램의 골격(뼈대)을 만들어주는 개념\n" +
                          "그리고 부모로 다중 상속이 가능하게 하는 개념이다.\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*특성(클래스 자체에 대한 설명)");
        Console.WriteLine("클래스 자체에 대한 설명(메타데이터)를 붙이는 역할이다.");



    }
}


//37-2 개체지향 프로그래밍의 네 가지 큰 개념

class 핵심_개념
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("1.캡슐화");
        Console.WriteLine("캡슐약처럼 그 안에 내용을 꼼꼼 숨긴다는 뜻이다.(private)" +
                        "\n예를 들어 private 필드를 꽁꽁 숨기는 걸 예로 들 수 있다.\n");

        Console.WriteLine("2.상속");
        Console.WriteLine("부모 클래스의 멤버를 자식 클래스에서 재송하는 개념\n");

        Console.WriteLine("3.다형성");
        Console.WriteLine("메서드는 매개변수에 따라 여러 가지 다양한 형태일 수 있다.");

        Console.WriteLine("4.추상화");
        Console.WriteLine("인터페이스 또는 추상 클래스에서 상속받아 구현하는 설계 관련 개념");
    }
}



//37-3 캡슐화를 사용하여 좀 더 세련된 프로그램 만들기

namespace EncapsulationNote
{
    public class Person
    {
        private string name; //필드
        //메서드: public 메서드 또는 속성으로 외부에 공개
        public void SetName(string n) //set
        {
            this.name = n;
        }
        public void Getname()
        {
            Console.WriteLine(this.name); //get
        }
        public string Getname1()
        {
            return this.name;
        }
    }

    class EncapsulationNote
    {
        static void Main(string[] args)
        {
            Person person = new Person(); //개체 생성

            //set 메서드로 필드 설정
            person.SetName("たまき");

            //get 메서드로 필드 공개
            person.Getname(); //たまき
            Console.WriteLine(person.Getname1()); //たまき
        }
    }
}




//37-4 다형성 기법을 사용하여 프로그램 융통성 높이기


namespace PolymorphismDemo
{
    //추상 클래스 및 기본 클래스
    public abstract class Animal
    {
        public abstract string Cry(); //동물의 "울음" 메서드
    }

    public class Dog : Animal
    {
        public override string Cry() //override 키워드로 재정의
        {
            return "멍멍멍";
        }
    }
    
    public class Cat : Animal
    {
        public override string Cry()
        {
            return "야옹";
        }
    }

    public class Trainer
    {
        public void DoCry(Animal animal) //매개변수에 클래스
        {
            Console.WriteLine(animal.Cry()); //다형성: dynamic(동적)
        }
    }

    class PolymorphismDemo
    {
        static void Main(string[] args)
        {
            //기본 개체 생성 방법
            Console.WriteLine((new Dog()).Cry()); //멍멍멍
            Console.WriteLine((new Cat()).Cry()); //야옹

            //부모 클래스 변수로 개체 생성
            Animal animal = new Dog();
            Console.WriteLine(animal.Cry());
            Animal animal1 = new Cat();
            Console.WriteLine(animal1.Cry());

            //다형성 테스트:
            //동일한 Cry 메서드를 호출하지만,
            //넘겨준 메시지에 따라 서로 다른 유형의 기능 구현
            //그러한 다형성은 메서드 오버라이드로 구현

            Trainer trainer = new Trainer();
            trainer.DoCry(new Dog()); //멍멍멍
            trainer.DoCry(new Cat()); //야옹
        }
    }
}



//37-5 클래스의 멤버 종합 연습: 자동차 클래스 구현하기
//전처리기 지시문: 코드에 주석처럼 입력하여 특별한 효과를 거두는 코드 블록
//ex) #region, #endregion


//네임스페이스: 클래스 이름 충돌 방지
namespace CarWorld
{
    //인터페이스
    interface IStandard { void Run(); } //표준

    //클래스: 설계도
    class Car : IStandard
    {
        
        #region //필드
        private string _name; //필드
        private string[] _names; //배열형 필드
        private readonly int _Length; //읽기 전용 필드
        #endregion

        #region//생성자
        public Car()
        {
            this._name = "좋은 차"; //필드를 기본값으로 초기화
        }
        public Car(string name) //생성자: 시동, 필드 초기화
        {
            this._name = name;
        }
        public Car(int length)
        {
            _Length = length; //읽기 전용 필드는 생성자로 초기화 가능
            _names = new string[length]; //넘어온 값으로 요소 생성
        }
        #endregion

        #region//메서드: 기능/동작
        public void Run() => Console.WriteLine($"{_name} 자동차가 달립니다.");
        #endregion

        #region//속성
        public string name //private 필드 -> 외부 공개
        {
            get => _name;
            set => _name = value;
        }
        public int Length { get => _Length; } //읽기 전용 속성
        #endregion

        #region//소멸자
        ~Car()
        {
            Console.WriteLine($"{_name}자동차가 폐차됨.");
        }
        #endregion

        #region//인덱서
        public string this[int index]
        {
            get { return _names[index]; }
            set { _names[index] = value; }
        }
        #endregion

        #region//이터레이터(반복기)
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _Length; i++)
            {
                yield return _names[i];
            }
        }
        #endregion

        #region//대리자
        public delegate void EventHandler(); //대리자: 다중 메서드 호출.(이벤트 생성의 중간 단계)
        #endregion

        #region//이벤트
        public event EventHandler Click; // 이벤트
        #endregion

        #region//이벤트 처리기
        public void OnClick()
        {
            if (null != Click) // 이벤트 핸들러(조건)
            {
                Click(); //이벤트 실행
            }
        }
        #endregion

        class CarWorld
        {
            static void Main(string[] args)
            {
                //클래스, 생성자, 메서드 테스트
                Car car = new Car(); //개체 생성
                car.Run(); //좋은 차 자동차가 달립니다.(기본 값 출력)
                Car car1 = new Car("똥차"); //매개변수 생성자로 개체 생성
                car1.Run(); //똥차 자동차가 달립니다.

                //속성 테스트
                Car sportsCar = new Car();
                sportsCar.name = "스포츠카";
                sportsCar.Run(); //스포츠카 자동차가 달립니다.

                //인덱서 테스트
                Car cars = new Car(2);
                cars[0] = "1번 자동차";
                cars[1] = "2번 자동차";
                for (int i = 0; i < cars.Length; i++)
                {
                    Console.WriteLine(cars[i]); //1번 자동차, 2번 자동차
                }

                //이터레이터(반복기) 테스트
                foreach (var item in cars)
                {
                    Console.WriteLine(item); ////1번 자동차, 2번 자동차
                }

                //대리자, 이벤트, 이벤트 처리기 테스트
                Car btn = new Car("전기 자동차");
                btn.Click += new Car.EventHandler(btn.Run); //Click 이벤트에 메서드 입력
                btn.Click += new Car.EventHandler(btn.Run);
                btn.OnClick(); //이벤트 처리기 실행

                //전기 자동차 자동차가 달립니다.
                //전기 자동차 자동차가 달립니다.

            }
        }


    }
}
