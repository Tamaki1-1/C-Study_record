using System;


class 메서드와_매개변수
{

    static void Main(string[] args)
    {
        Console.WriteLine("27.메서드와 매개변수");
    }
}



//27-1 public과 private 키워드의 차이

class Dog
{
    public void Eat() //public 외부 공유 가능 메서드
    {
        Console.WriteLine("밥을 먹는다.");
    }

    private void Eat2() //private 타클래스 공유 불가능
    {
        Console.WriteLine("소화를 시킨다.");
    }

    public void Eat3()
    {
        this.Eat2(); //Eat2(private) 메서드 값 반환
    }
}


class 메인
{
    static void Main(string[] args)
    {
        Dog dog = new Dog(); //클래스 인스턴스 생성

        dog.Eat(); //public은 공유 가능

        //dog.Eat2(); <Error> private라 공유 불가능  

        dog.Eat3(); //public 메서드를 통해 호출 가능
    }
}


//27-2 메서드의 매개변수 전달 방식

class 메인
{
    static void Main(string[] args)
    {
        Console.WriteLine("27-2 메서드의 매개변수 전달 방식\n");

        Console.WriteLine("값 전달 방식:              값을 그대로 복사해서 전달하는 방식\n");

        Console.WriteLine("참조 전달 방식(ref):       실제 데이터는 매개변수가 선언된 쪽에서만 저장하고,\n" +
                          "                           호출된 메서드에서는 참조만 하는 형태로 변수 이름만 전달하는 방식\n");

        Console.WriteLine("반환형 전달 방식(out):     메서드를 호출하는 쪽에서 선언만 하고, 초기화하지 않고 전달하면\n" +
                          "                           메서드 쪽에서 해당 데이터를 초기화해서 넘겨주는 방식\n");

        Console.WriteLine("가변형 전달 방식(params):  1개 이상의 매개변수를 가변적으로 받을 때 매개변수를 선언하려면 \n" +
                          "                           params 키워드를 붙임");
    }
}



//27-3 값 전달 방식

class 값_전달_방식
{
    static void Main(string[] args)
    {
        int num = 10;
        Console.WriteLine($"[1] {num}"); //[1] 10

        INT(num); //[2] 20

        Console.WriteLine($"[3] {num}"); //[3] 10 //num은 Main()의 지역 변수이기 때문에 기존 값인 10이 출력된다.
    }

    static void INT(int num)
    {
        num = 20;
        Console.WriteLine($"[2] {num}");
    }
}



//27-4 참조 전달 방식(ref) - 호출한 변수의 값을 수정함


class ParameterRef
{
    static void Main(string[] args)
    {
        int num = 10;
        Console.WriteLine($"[1] {num}"); //[1] 10

        Ref(ref num); //참조 전달 방식(ref)

        Console.WriteLine($"[3] {num}"); //[3] 20
    }

    static void Ref(ref int num) //변수 호출
    {
        num = 20; //호출한 부분에 적용(Main()메서드의 num 변수 값이 변경됨)
        Console.WriteLine($"[2] {num}"); //[2] 20
    }
}



//27-5 반환형 전달 방식(out) - ref와 흡사하지만, out은 호출한 쪽에서 초기화를 안해도 가능하다.

class Out
{
    static void Main(string[] args)
    {
        int num = 2;
        Console.WriteLine($"[1] {num}"); //[1] 2

        Do(out num); //반환형 매개변수 전달 방식(out)

        Console.WriteLine($"[3] {num}"); //[3] 12
    }

    static void Do(out int num) //반환형 전달 방식 매개변수
    {
        num = 12; // ref와 동일하게 호출한 부분에 적용, 초기화 필수
        Console.WriteLine($"[2] {num}"); //[2] 12
    }
}



//27-6 out 키워드를 사용해 날자 형태의 문자열을 날짜형으로 변환

class 날짜변환
{
    static void Main(string[] args)
    {
        DateTime dt;

        if (DateTime.TryParse("2020-01-01",out dt)) //변환이 가능하면 dt 변수에 저장 (true)
        {
            Console.WriteLine(dt); //2020-01-01 오전 12:00:00
        }
        else
        {
            Console.WriteLine("날짜 형식으로 변환이 불가능합니다.");
        }


        //TryParse()메서드로 지역 변수 선언과 초기화가 동시에 가능

        if (DateTime.TryParse("2024-01-19", out DateTime 誕生日)) //var 키워드도 가능
        {
            Console.WriteLine(誕生日); //2024-01-19 오전 12:00:00
        }
        else
        {
            Console.WriteLine("변환이 불가능합니다.");
        }


        Console.WriteLine(誕生日); //변수가 생성됨 //2024-01-19 오전 12:00:00
    }
}


//27-7 가변 길이 매개변수(params) - 배열 매개변수, 말그대로 가변 길이라 원하는 만큼 배열이 생성됨

class 가변_길이_매개변수
{
    static void Main(string[] args)
    {
        SumAll(3, 2); //배열의 합: 5
        SumAll(1, 1, 1, 1, 1, 1, 1, 1); //배열의 합: 8
        SumAll(999, 888, 32323, 1111); //배열의 합: 35321
    }

    static void SumAll(params int[] numbers) //params - 가변 길이 매개변수를 갖는 메서드 만들기
    {
        int sum = 0;

        foreach (var item in numbers)
        {
            sum += item;
        }

        Console.WriteLine($"배열의 합: {sum}");
    }
}



//27-7-1 문자열 배열을 받는 가변 길이 매개변수 사용하기

class 문자열_가변길이
{
    static void Main(string[] args)
    {
        문자열("아이우에오","카키쿠케코","타치츠테토","하히후헤호");
            //아이우에오
            //카키쿠케코
            //타치츠테토
            //하히후헤호
        
    }

    static void 문자열(params string[] munza)
    {
        foreach (var item in munza)
        {
            Console.WriteLine(item);
        }
    }
}


//27-8 식 본문 메서드 사용하기

class SingleExpression
{
    static void Main(string[] args)
    {
        Console.WriteLine(korea_age(23)); //24
        Console.WriteLine(제곱(5));//25
        japanHi();//こんにちは！
    }
    

    static int korea_age(int age) => age + 1; //화살표 기호로 축약 가능(return은 묵시적으로 생략)
    static int 제곱(int A) => A * A;
    static void japanHi() => Console.WriteLine("こんにちは！");
}


//27-9 선택적 매개변수 - 매개변수의 기본값도 있는 함수
//     명명된 매개변수 - 매개변수의 이름을 명명해서 수정

class 선택적_명명된_매개변수
{
    static void Main(string[] args)
    {

        //선택적 매개변수
        Console.WriteLine(add()); //30
        Console.WriteLine(add(3)); // 23
        Console.WriteLine(add(30,50)); //80

        //명명된 매개변수
        Console.WriteLine(add(a: 3)); // 3 + 20 = 23
        Console.WriteLine(add(b: 5)); // 10 + 5 = 15
        Console.WriteLine(add(b: 30, a:1)); //1 + 30 = 31
    }

    static int add(int a = 10, int b = 20) //b는 기본값이 2로 설정됨
    {
        return a + b;
    }
}



//27-10 명명된 매개변수를 사용해서 메서드 오버로드 구현하기

class 메서드_오버로드
{
    static void Main(string[] args)
    {
        over(a: ";_;..."); //;_;...
        over(b: "; _ ;...",a: "aaaaaaa"); //aaaaaaa; _ ;...
        over(c: "; _ ;...", b: "aaaaaaa", a: "あああああああああ"); //あああああああああaaaaaaa; _ ;...
    }

    static void over(string a, string b = "", string c = "")
    {
        Console.WriteLine($"{a}{b}{c}");
    }
}




