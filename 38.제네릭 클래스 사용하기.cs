using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

class 제네릭_클래스
{
    static void Main(string[] args)
    {
        Console.WriteLine("38.사용자 정의 클래스를 매개변수로 사용하는 제네릭 클래스");
        Console.WriteLine("제네릭: 컬렉션을 다룰 때 필요한 데이터 형식만 사용해서 성능 향상을 가져다 주는 기법.");
    }

    
}


//38-1 컬렉션 이니셜라이저로 제네릭 리스트 초기화하기

class Person
{
    public string Name { get; set; }
}

class 메인
{
    static void Main(string[] args)
    {
        List<Person> list = new List<Person>
        {
            new Person { Name = "카나시이" }, //컬렉션 이니셜라이저로 초기화
            new Person { Name = "우레시이" },
            new Person { Name = "하나시이" }
        };

        foreach (var item in list)
        {
            Console.WriteLine(item.Name); //카나시이, 우레시이, 하나시이
        }
    }
}
}
}


//38-2 제네릭 크래스에 사용자 정의 클래스 사용하기
//List<T> 형태에 사용자 정의 클래스를 매개변수로 사용

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}

class 메인
{
    static void Main(string[] args)
    {
        List<Category> list = new List<Category>()
        {
            //컬렉션 이니셜라이저를 사용하여 카테고리 리스트만들기
            new Category { CategoryId = 1, CategoryName = "리븐"},
            new Category { CategoryId = 2, CategoryName = "자크"},
            new Category { CategoryId = 3, CategoryName = "아트록스"}
        };

        foreach (var item in list)
        {
            Console.WriteLine($"{item.CategoryId} - {item.CategoryName}");
        }
    }
}
}
}


//38-3 제네릭 개체를 초기화하는 세 가지 방법 정리


class 개체_형식
{
    public int Month { get; set; }
    public string Value { get; set; }
}

class 메인
{
    static void Main(string[] args)
    {
        //1. 개체 형식의 리스트 생성: 컬렉션 이니셜라이저로 값 초기화
        List<개체_형식> list = new List<개체_형식>()
        {
            new 개체_형식 {Month = 1, Value = "일"},
            new 개체_형식 {Month = 2, Value = "이"},
            new 개체_형식 {Month = 3, Value = "삼"}
        };

        //2.Add() 메서드로 리스트에 값 추가
        list.Add(new 개체_형식 { Month = 4, Value = "사" });
        list.Add(new 개체_형식 { Month = 5, Value = "오" });
        list.Add(new 개체_형식 { Month = 6, Value = "육" });

        //3.AddRange() 메서드로 리스트에 값들 추가
        List<개체_형식> temp = new List<개체_형식>()
        {
            new 개체_형식 {Month = 7, Value = "칠"},
            new 개체_형식 {Month = 8, Value = "팔"},
            new 개체_형식 {Month = 9, Value = "구"}
        };
        list.AddRange(temp); //temp의 리스트를 list에 추가

        foreach (var item in list)
        {
            Console.WriteLine($"{item.Month}, {item.Value}");
        }
    }
}


//38-4 List<T>의 T에 사용자지정 클래스 설정하기

public class AreaCode
{
    public string Number { get; set; }
    public string AreaName { get; set; }
}
class 메인
{
    static void Main(string[] args)
    {
        List<AreaCode> areas = new List<AreaCode>(); //개체 생성

        AreaCode seoul = new AreaCode();
        seoul.Number = "1";
        seoul.AreaName = "서울";

        AreaCode sejong = new AreaCode();
        sejong.Number = "2";
        sejong.AreaName = "세종";

        areas.Add(seoul); //List 제네릭에 seoul 포함시키기
        areas.Add(sejong); //List 제네릭에 sejong 포함시키기

        foreach (var item in areas)
        {
            Console.WriteLine($"{item.Number} - {item.AreaName}");
        }
    }
}


//38-5 컬렉션 합치기 연습

class First
{
    public string A { get; set; }
    public string B { get; set; }
}

class Second
{
    public string B { get; set; }
    public string C { get; set; }
}

class Merge
{
    public string A { get; set; }
    public string B { get; set; }
    public string C { set; get; }
}

class 메인
{
    static void Main(string[] args)
    {
        List<First> firsts = new List<First>()
        {
            new First { A = "F1A", B = "F1B"},
            new First { A = "F2A", B = "F2B"}
        };

        List<Second> seconds = new List<Second>()
        {
            new Second {B = "S1B", C = "S1C"},
            new Second {B = "S2B", C = "S2C"}
        };


        List<Merge> merges = new List<Merge>();

        for (int i = 0; i < firsts.Count; i++) //first 컬렉션 추가 => for문 사용
        {
            merges.Add(new Merge() { A = firsts[i].A, B = firsts[i].B });
        }

        foreach (var item in seconds)
        {
            merges.Add(new Merge() { B = item.B, C = item.C });
        }

        foreach (var item in merges)
        {
            Console.WriteLine($"{item.A, 5} {item.B, 5} {item.C, 5}");
        }
    }
}


//38-6 사전 제네릭 클래스 소개
//컬렉션 클래스는 리스트와 사전으로 구분 가능

//Dictionary<TKey, TValue>: 일반적인 형태로 저장하고, 정렬되지는 않음
//SortedList<TKey, TValue>: 키로 정렬하고, 정렬된 제이터를 빠르게 출력한다.
//SortedDictionary<TKey, TValue>: 키로 정렬하고, 정렬되지 않은 데이터를 빠르게 출력한다.


//38-7 DicTionary<T> 클래스로 키와 값을 쌍으로 저장하기

class 메인
{
    static void Main(string[] args)
    {
        //딕셔널리 사용해보기
        Dictionary<int, int> pairs = new Dictionary<int, int>(); //딕셔널리 개체 생성
        pairs.Add(1, 100); //값 입력 key, value
        pairs.Add(2, 200);

        foreach (var item in pairs) //출력
        {
            Console.WriteLine($"{item.Key}, {item.Value}");
            //1, 100
            //2, 200
        }


        //1부터 12까지 데이터를 다뤄보기

        Dictionary<int, double> keyValuePairs = new Dictionary<int, double>();

        for (int i = 1; i <= 12; i++) //1부터 12까지 키 값 지정
        {
            keyValuePairs.Add(i, 0.0f);
        }

        keyValuePairs[1] = 323.12;
        keyValuePairs[2] = 33.1;
        keyValuePairs[3] = 333333333.23;

        foreach (var item in keyValuePairs) //foreach지만, for로 변칙적이거나 지정 키까지만 출력도 가능
        {
            Console.WriteLine($"{item.Key}월의 점수: {item.Value}");
            //1월의 점수: 323.12
            //2월의 점수: 33.1
            //3월의 점수: 333333333.23
            //4월의 점수: 0
            //5월의 점수: 0
        }

    }
    
}


//38-8 Dictionary<T> 클래스에 문자열 키 지정하기

class 메인
{
    static void Main(string[] args)
    {
        Dictionary<string, string> nickName = new Dictionary<string, string>();
        nickName.Add("타노시이", "tano");
        nickName.Add("카나시이", "; _ ;..");

        foreach (var item in nickName)
        {
            Console.WriteLine($"{item.Key}의 닉네임: {item.Value}");
        }

        //ContainsKey() 메서드로 키 확인 가능
        if (nickName.ContainsKey("타노시이")) //타노시이 값이 있으면 true
        {
            Console.WriteLine(nickName["타노시이"]); //tano
        }

        if (nickName.ContainsKey("타마키")) //"타마키"라는 key는 없으므로 false
        {
            
            Console.WriteLine("; - ;...???"); //출력 안함
        }
    }
}


//38-9 제네릭 인터페이스

class 제네릭_인터페이스
{
    static void Main(string[] args)
    {
        Console.WriteLine("매개변수 T를 쓰는 제네릭 인터페이스의 종류");
        Console.WriteLine("ICollection<T> 인터페이스: 제네릭 컬렉션 관련 클래스의 부모 역할을 하는 인터페이스 중\n" +
                          "하나인 ICollection<T> 인터페이스는 제네릭 컬렉션을 조작하는 메서드 정의를 제공한다.");
        Console.WriteLine("Count: 요소 개수를 반환한다.\n" +
                          "Add(T): T 개체를 추가합니다.\n" +
                          "Clear(): 항목을 모두 제거합니다.\n" +
                          "Contains(T): 특정 값이 들어 있는지 여부를 확인합니다.\n" +
                          "Remove(T): 맨 처음 발견되는 특정 개체를 제거합니다.\n");

        Console.WriteLine("*IEnumerable<T> 인터페이스: 컬렉션의 데이터를 읽기 전용으로 출력할 때 사용함" +
                          "출력 전용이라면, IEnumerable<T>을 사용하길 권장함.");
    }
}


//38-10 문자열 배열을 사용하는 세가지 방법

class 세가지
{
    static void Main(string[] args)
    {
        //문자열 배열을 선언하는 기본적인 방법
        var a1 = new string[] {"A", "B", "C"};

        //제네릭 List<T> 개체를 생성한 후 문자열 배열을 ToList() 메서드로 변환
        var a2 = new List<string>();
        a2 = a1.ToList(); //배열을 제네릭 List<T>로 변환

        //IEnumerable<T> 개체를 생성한 후 문자열 배열을 바로 대입 가능
        IEnumerable<string> a3 = a1.ToList(); //읽기 전용(수정 불가)

        //IEnumerable<T> 개체를 ToList() 메서드로 List<T>로 변환
        var a4 = a3.ToList(); //이럼 수정 가능

        //IEnumerable<T> 개체는 주로 foreach 문으로 반복 사용
        foreach (var item in a3)
        {
            Console.WriteLine(item); // A B C
        }

        //string[], List<T> 개체는 for 문으로 반복 가능
        for (int i = 0; i < a1.Length; i++)
        {
            Console.WriteLine($"{a1[i]} {a2[i]} {a4[i]}");
        }
    }
}


//38-11 제네릭 클래스 만들기
//클래스를 생성할 때 <T> 형태로 클래스와 클래스의 멤버 성질을 결정 할 수 있다.

public class Cup<T>
{
    public T Content { get; set; } //속성
}

class 메인
{
    static void Main(string[] args)
    {
        Cup<string> aa = new Cup<string>(); //제네릭 클래스의 개체 생성
        aa.Content = "문자열 제네릭 클래스"; //속성에 값 입력

        Cup<int> bb = new Cup<int>(); //제네릭 클래스에 개체 생성
        bb.Content = 123; //속성에 값 입력

        Console.WriteLine($"{aa.Content}, {bb.Content}"); //문자열 제네릭 클래스, 123
    }
}


//38-12 제네릭 클래스의 형식 매개변수로 속성 형식 변경하기

public class Multi<T>
{
    public T Data { get; set; } //속성
}

class 메인
{
    static void Main(string[] args)
    {
        Multi<string> title = new Multi<string>(); //개체 생성
        title.Data = "연봉";

        Multi<long> income = new Multi<long>();
        income.Data = 30_000_000;

        Console.WriteLine($"{title.Data}: {income.Data:#,###}"); //연봉: 30,000,000
    }
}


//38-13 제네릭에 사용자 정의 형식 클래스 전달하기
//제네릭 클래스에 기본 형식이 아닌 사용자 정의 클래스를 지정하는 예제

class Juice { }
class Coffee { }

class Cup<T>
{
    public T Type { get; set; } //속성
}

class 메인
{
    static void Main(string[] args)
    {
        //T 형식 매개변수로 Juice 클래스 전송
        Cup<Juice> cup = new Cup<Juice>(); //Juice의 개체 생성
        cup.Type = new Juice();
        Console.WriteLine(cup.Type.ToString()); //Juice

        Cup<Coffee> cup2 = new Cup<Coffee>() { Type = new Coffee() }; //이니셜라이저로 입력
        Console.WriteLine(cup2.Type.ToString()); //Coffee
    }
}


//38-14 형식매개변수에 대한 제약조건 걸기

public interface IKs { } //인터페이스
public class GoodCar { } //기본 클래스
public class BadCar //매개변수 생성자 클래스
{
    public BadCar(string msg)
    {
        Console.WriteLine("; _ ;");
    }
}
public class OfficeCamper : GoodCar, IKs { } //상속받는 클래스


//where와 struct 키워드로 형식 매개변수 T에 값 형식만 받는 제네릭 클래스 
public class CarValue<T> where T : struct { } //값 형식만

//참조 형식만 받는 제네릭 클래스
public class CarReference<T> where T : class { } //참조 형식만

//기본 생성자가 있는 클래스만 받는 제네릭 클래스
public class CarNew<T> where T : new() { }

//특정 클래스를 상속한 클래스만 받는 제네릭 클래스
public class CarClass<T> where T : GoodCar { }

//특정 인터페이스만 매개변수로 받는 제네릭 클래스
public class CarInterface<T> where T : IKs { }

class 메인
{
    static void Main(string[] args)
    {
        //값 형식만 받는 제네릭 클래스
        CarValue<int> c = new CarValue<int>(); //성공
        CarValue<double> b = new CarValue<double>(); //성공
        //<Error>CarValue<string> a = new CarValue<string>();

        //참조 형식만 받는 제네릭 클래스
        CarReference<string> z = new CarReference<string>();
        CarReference<object> x = new CarReference<object>();
        //<Error>CarReference<int> v = new CarReference<int>();

        //기본 생성자가 있는 클래스만 받는 제네릭 클래스
        CarNew<GoodCar> c1 = new CarNew<GoodCar>(); //성공
        //<Error>CarNew<BadCar> c2 = new CarNew<BadCar>();

        //특정 클래스를 상속한 클래스만 받는 제네릭 클래스
        CarClass<OfficeCamper> a1 = new CarClass<OfficeCamper>();
        //<Error>CarClass<BadCar> a2 = new CarClass<BadCar>();

        //특정 인터페이스만 매개변수로 받을 수 있는 클래스
        CarInterface<IKs> x1 = new CarInterface<IKs>();
        //<Error>CarInterface<GoodCar> x2 = new CarInterface<GoodCar>();

    }
}


//38-15 제네릭의 T 형식 매개변수를 여러 개 사용하기

public class Pair<T, V> //매개변수를 2개 사용
{
    public T First { get; set; }
    public V Second { get; set; }

    public Pair(T first, V second) //생성자로 초기화
    {
        this.First = first;
        this.Second = second;
    }
}

class 메인
{
    static void Main(string[] args)
    {
        Pair<string, bool> pair = new Pair<string, bool>("; _ ;..", true);

        Console.WriteLine($"{pair.First}는 {pair.Second}입니다."); //; _ ;..는 True입니다.
    }
}


//38-16 제네릭 클래스와 제네릭 메서드

public class Hello<T>
{
    public T _message; //필드
    public Hello() //기본 생성자
    {
        _message = default(T);
    }
    public Hello(T message) //매개변수가 있는 생성자
    {
        _message = message;
    }

    public void Say(T message) //제네릭 메서드
    {
        Console.WriteLine(message);
    }

    public T GetMessage() //일반 메서드
    {
        return _message;
    }
}

class 메인
{
    static void Main(string[] args)
    {
        //기본 생성자 출력
        Hello<string> hello = new Hello<string>();
        Console.WriteLine(hello.GetMessage()); //null
        Console.WriteLine((new Hello<int>()).GetMessage()); //0

        //매개변수가 있는 생성자 출력
        Console.WriteLine((new Hello<string>("ㅎㅇ")).GetMessage()); //ㅎㅇ
        Console.WriteLine((new Hello<decimal>(3.14m)).GetMessage()); //3.14

        //전달된 T의 형식에 따라 출력하는 메서드인 Say로 출력
        (new Hello<string>()).Say("Say Hello"); //Say Hello
        (new Hello<int>()).Say(123); //123
    }
}
