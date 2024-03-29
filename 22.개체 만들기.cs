using System;


class 오브젝트코드1 { }

class 개체
{


    static void Main(string[] args)
    {
        Console.WriteLine("22.개체 만들기");
        Console.WriteLine("개체 - new 키워드를 사용하여 새로운 이름으로 만든 것");

        오브젝트코드1 objectcode = new 오브젝트코드1(); //개체 생성
        Console.WriteLine(objectcode.GetHashCode());//54267293 


        

        


    }
}



 //22-1 개체와 인스턴스

class 접속자 //22-1 개체와 인스턴스 예시
{
    public void 오늘접속자() //멤버 혹은 메서드 생성
    {
        Console.WriteLine("오늘은 32명이 접속했습니다.");
    }


}

class 개체
{

    static void Main(string[] args)
    {



        접속자 접속 = new 접속자(); // 클래스의 인스턴스 생성
        접속.오늘접속자(); //개체이름.멤버이름으로 클래스의 멤버 호출


    }
}



//22-2 인스턴스 메서드 만들기 - static이 붙지않는 메서드

class 더하기
{

    public void 합계(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine(sum);
    }
}


class 메인
{

    static void Main(string[] args)
    {
        var sum_ = new 더하기(); //var 형식으로도 인스턴스 생성 가능
        더하기 sum = new 더하기(); //클래스의 인스턴스 생성

        sum.합계(3, 5); //8
        sum_.합계(4, 5); //9

    }
}


//22-3 익명 형식 - 클래스를 선언하지 않고 개체를 만드는 방법

class 익명
{

    static void Main(string[] args)
    {

        var 정보 = new { Name = "카나시이", Age = 7 }; //익명 형식
        var 정보2 = new { Name = "타노시이", Age = 12 };

        Console.WriteLine($"{정보.Name}의 나이 {정보.Age}"); //카나시이의 나이 7
        Console.WriteLine($"{정보2.Name}의 나이 {정보2.Age}"); //타노시이의 나이 12


        var o = new { ID = 1, 노트 = "익명 형식", 조건 = true}; // 익명 형식 or 무명 형식 or 이름이 없는 개체


        if (o.조건) //true니까 실행
        {
            Console.WriteLine($"{o.ID} - {o.노트}"); // 1 - 익명 형식
        }
    }
}



//22-4 정적 멤버와 인스턴스 멤버

class 멤버들
{
    public static void 정적_멤버()
    {
        Console.WriteLine("정적 멤버입니다.");
    }
    public void 인스턴스_멤버() => Console.WriteLine("인스턴스 멤버입니다.");


    static void Main(string[] args)
    {
        멤버들.정적_멤버(); //정적 멤버 호출 (클래스.메서드 형식)


        멤버들 인스턴스 = new 멤버들(); //인스턴스 생성
        인스턴스.인스턴스_멤버(); //인스턴스 멤버 호출(개체.멤버; 형태)


    }

}


//22-5 프로젝트에 클래스를 여러 개 사용하기

class 메인
{
    static void Main(string[] args)
    {

        클래스1.HI(); //정적 메서드

        클래스2 Class = new 클래스2(); //클래스2의 인스턴스 생성
        클래스2.HI1(); //정적 메서드 호출
        Class.HI2(); // 인스턴스 메서드 호출
    }
}



//22-6 ToString() 메서드 오버라이드


class My { }

class Your
{
    public override string ToString()
    {
        return "새로운 반환 문자열 지정";
    }

}

class 메인
{
    static void Main(string[] args)
    {
        My my = new My(); 
        Console.WriteLine(my); //개체를 출력하면 기본은 클래스의 이름이 출력

        Your your = new Your(); 
        Console.WriteLine(your); //override의 효과로 "새로운 반환 문자열 지정"이 출력
    }
}


//22-7 클래스 배열

public class 카테고리
{
    public void 카테고리_(int i)
    {
        Console.WriteLine($"카테고리: {i}");
    }
}

class 메인
{
    static void Main(string[] args)
    {
        카테고리[] 카테고리_배열 = new 카테고리[3]; //클래스 배열 생성 3칸


        카테고리_배열[0] = new 카테고리(); // 각 요소에 인스턴스 생성
        카테고리_배열[1] = new 카테고리();
        카테고리_배열[2] = new 카테고리();

        for (int i = 0; i < 카테고리_배열.Length; i++)
        {
            카테고리_배열[i].카테고리_(i);
        //카테고리: 0
        //카테고리: 1
        //카테고리: 2
        }
    }
}




