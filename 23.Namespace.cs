using System;
using Korea.Seoul;
using In = Korea.Incheon;


namespace _네임스페이스
{
    class 네임스페이스
    {

        static void Main(string[] args)
        {
            Console.WriteLine("23.네임스페이스 - 프로그램 규모가 커질 때 클래스 이름이 충돌하는 것을 방지하도록\n" +
                                                "클래스를 모아서 관리하는 개념");
        }
    }
}


//23-1 네임스페이스를 사용하여 같은 이름의 클래스로 구분


namespace Foo
{
    public class Car
    {
        public void Go()
        {
            Console.WriteLine("[1] Foo 네임스페이스의 Car 클래스 호출");   
        }
    }
}

namespace Bar
{

    public class Car
    {
        public void Go()
        {
            Console.WriteLine("[2] Bar 네임스페이스의 Car 클래스 호출");
        }
    }
}

class NamespaceNote
{

    static void Main(string[] args)
    {
        Foo.Car foo = new Foo.Car(); //Foo의 인스턴스 선언
        foo.Go(); //foo의 go 메서드 출력
        Bar.Car bar = new Bar.Car(); //Bar의 인스턴스 생성
        bar.Go(); //Bar의 go
        
    }
}


//23-2 네임스페이스 선언과 사용하기

namespace Korea
{
    namespace Seoul
    {
        public class Car
        {
            public void Run()
            {
                Console.WriteLine("서울 자동차가 달립니다.");
            }
        }
    }

    namespace Incheon
    {
        public class Car
        {
            public void Run()
            {
                Console.WriteLine("인천 자동차가 달립니다.");
            }
        }
    }
}


namespace main
{
    class 네임스페이스
    {
        static void Main(string[] args)
        {
           Korea.Seoul.Car 서울 = new Korea.Seoul.Car();
           서울.Run();
           Korea.Incheon.Car 인천 = new Korea.Incheon.Car();
           인천.Run();


            //using 지시문 선언

            //using Korea.Seoul;
            //using In = Korea.Incheon;

            Car 서울2 = new Car();
            In.Car 인천2 = new In.Car();

            서울2.Run();
            인천.Run();
        }
    }
}


//23-3 using을 이용한 사용자 정의 데이터 형식 구현하기

namespace TypeDefinitionWithUsing
{
    //이 형식을 Project 별칭으로 줄여서 사용
    using Project = Gilbut.Education.CSharp.Lecture;
    public class 클래스
    {

        static void Main(string[] args)
        {

            Gilbut.Education.CSharp.Lecture lecture = new Gilbut.Education.CSharp.Lecture(); // 기본 호출
            Console.WriteLine(lecture); //Lecture 클래스 호출됨.

            Project lecture1 = new Project();
            Console.WriteLine(lecture1); //Lecture 클래스 호출됨.





        }
    }
}
namespace Gilbut
{
    namespace Education
    {
        namespace CSharp
        {
           public class Lecture
            {
                public override string ToString()
                {
                    return "Lecture 클래스 호출됨.";
                }
            }
        }
    }
}





