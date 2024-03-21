using System;


class 소멸자
{

    static void Main(string[] args)
    {
        Console.WriteLine("26-소멸자(종료자) - 클래스의 인스턴스를 사용한 후 최종 정리할 때 실행되는 클래스에서\n" +
                          "                    가장 늦게 호출하는 메서드\n");

        Console.WriteLine("소멸자의 특징: 1.클래스 이름과 동일한 메서드로 앞에 물결 기호인 ~를 붙여 만든다." +
                          "\n               2.생성자와 달리 매개변수를 받을 수 없다." +
                          "\n               3.오버로드를 지원하지 않으며 직접 호출할 수도 없다.");
       

    }

    class Car
    {
        ~Car() //소멸자 - 최종 단계에서 실행됨
        {

        }
    }
}


//26-1 생성자, 메서드, 소멸자 실행 시점 살펴보기

public class 생성자
{
    public 생성자() //생성자
    {
        Console.WriteLine("[1] 생성자");
    }

    public void 메서드() //메서드, 함수
    {
        Console.WriteLine("[2] 메서드");
    }

    ~생성자() //종료자
    {
        Console.WriteLine("[3] 종료자");
    }
}

class 메인
{
    static void Main(string[] args)
    {
        생성자 생성 = new 생성자();
        생성.메서드();

        //[1] 생성자
        //[2] 메서드
        //[3] 종료자

    }
}



//26-2 소멸자를 사용한 클래스 역할 마무리하기

namespace DestructorDemo
{
    public class Car
    {
        private string _name; //필드
        public string GetName()
        {
            return _name;
        }

        public Car() //매개변수가 없는 생성자
        {
            this._name = "벨로스터";
        }

        public Car(string name) //매개변수가 있는 생성자
        {
            this._name = name;
        }

        ~Car() //소멸자
        {
            Console.WriteLine($"{_name}은 폐차...");
        }
    }


    class 메인
    {
        static void Main(string[] args)
        {
            DestructorDemo.Car car = new DestructorDemo.Car(); //매개변수가 없는 생성자 인스턴스
            Console.WriteLine(car.GetName()); //인스턴스에 출력용 메서드(GetName) 호출

            DestructorDemo.Car car2 = new DestructorDemo.Car("모닝"); //매개변수가 있는 생성자 인스턴스 생성
            Console.WriteLine(car2.GetName()); //인스턴스에 출력용 메서드(GetName) 호출


        }
    }
}


//26-3 생성자, 메서드, 소멸자 함께 사용하기


namespace 함께
{
    public class Car
    {
        private string color;
        public Car() //생성자
        {
            color = "검정";
            Console.WriteLine($"{color}색 자동차를 조립합니다.");
        }

        public Car(string 색상) //매개변수가 있는 생성자
        {
            color = 색상;
            Console.WriteLine($"{color}색 자동차를 조립합니다.");
        }

        public void Go()
        {
            Console.WriteLine($"{color}색 자동차가 달립니다!!");
        }

        ~Car()
        {
            Console.WriteLine($"{color}색 자동차가 폐차되었습니다.");
        }
    }



    class main
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Go();

            Car car1 = new Car("빨간");
            car1.Go();

            Car car2 = new Car("하얀");
            car2.Go();
        }
    }
}




