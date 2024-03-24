using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Collections.Generic;


class 인덱서
{

    static void Main(string[] args)
    {
        Console.WriteLine("29. 인덱서 - 속성 여러개를 하나로 표현하거나 개체를 배열 형식으로 표현할 때 사용");
        Console.WriteLine("indexer tap tap 하면 자동으로 기본 뼈대 코드를 작성");

    }
    public object this[int index] //이름을 지정하지 않고 this 키워드를 사용
    {
        get { }
        set { }
    }
}



//29-1 정수형 인덱서 만들기 (get 키워드만 사용, 읽기 전용)

class Catalog
{
    public object this[int index] //인덱스의 값이 홀수인지 짝수인지 반환하는 인덱서
    {
        get { return (index % 2 == 0) ? $"짝수 반환 {index}" : $"홀수 반환 {index}"; }
    }
}

class 메인
{
    static void Main(string[] args)
    {
        Catalog catalog = new Catalog(); //클래스의 인스턴스 생성

        Console.WriteLine(catalog[0]); //개체이름[인덱스] 형태로 호출 가능
        Console.WriteLine(catalog[1]);
        Console.WriteLine(catalog[2]);
        Console.WriteLine(catalog[4]);
        Console.WriteLine(catalog[7]);

        //짝수 반환 0
        //홀수 반환 1
        //짝수 반환 2
        //짝수 반환 4
        //홀수 반환 7
    }
}


//29-2 인덱서를 사용하여 여러값 주고 받기
//속성과 동일하게 세터로 값을 입력받고, 게터로 값을 반환하는 구조

class 이름
{
    private string Name; //필드
    public string this[int index] //문자열 인덱서
    {
        get { return Name; }
        set { Name = value; }
    }
}

class 메인
{

    static void Main(string[] args)
    {
        이름 개체 = new 이름();
        개체[0] = "타마키";
        Console.WriteLine(개체[0]); //타마키

        개체[1] = "Tamaki";
        Console.WriteLine(개체[1]); //Tamaki

    }
}


//29-3 인덱서를 사용하여 배열 형식의 개체 만들기
//인덱서는 속성에 배열형이라고 보면 됨

public class Car
{
    private string[] _Name;

    public Car(int 길이) //생성자 - 넘어온 값만큼 배열 생성
    {
        _Name = new string[길이];
    }

    public int Name //속성(읽기 전용 속성)
    {
        get { return _Name.Length; } //필드(_Name)의 길이 반환
    }

    public string this[int index] //인덱서: this[] 키워드를 사용한 속서의 확장(배열) 형식
    {
        get { return _Name[index]; }
        set { _Name[index] = value; }
    }
}

class 메인
{
    static void Main(string[] args)
    {
        Car car = new Car(3);
        car[0] = "모닝";
        car[1] = "벨로스터";
        car[2] = "어코드";

        for (int i = 0; i < car.Name; i++)
        {
            Console.WriteLine(car[i]);
            //모닝
            //벨로스터
            //어코드
        }


    }
}

//29-4 배열 형식의 필드를 사용하는 인덱서

class Week
{
    private string[] _요일;

    public Week() //매개변수가 없는 생성자
    {
        Length = 7; //기본값 초기화
        _요일 = new string[Length]; //요소 7개를 가지는 배열 생성
    }

    public Week(int 길이) //매개변수가 있는 생성자
    {
        Length = 길이; //매개변수의 값 만큼 배열 새성
        _요일 = new string[Length];
    }

    public int Length //속성
    {
        get; //7
    }

    public string this[int index]
    {
        get { return _요일[index]; }
        set { _요일[index] = value; }
    }
}

class 메인
{
    static void Main(string[] args)
    {
        Week week = new Week();
        week[0] = "월요일";
        week[1] = "화요일";
        week[2] = "수요일";
        week[3] = "목요일";
        week[4] = "금요일";
        week[5] = "토요일";
        week[6] = "일요일";

        for (int i = 0; i < week.Length; i++)
        {
            Console.WriteLine(week[i]);
        }


        Week week2 = new Week(3); //3개의 요소 배열 생성
        week2[0] = "월요일";
        week2[1] = "화요일";
        week2[2] = "수요일";

        for (int i = 0; i < week2.Length; i++)
        {
            Console.WriteLine(week2[i]);
        }

    }
}


//29-5 문자열 매개변수를 받는 인덱서 사용하기
//특징: 키와 값 쌍으로 데이터를 저장

namespace NickNameDemo
{
    public class NickName
    {
        //필드: 해시 테이블 형식의 필드 생성
        private Hashtable _Name = new Hashtable();

        public string this[string key]
        {
            get { return _Name[key].ToString(); }
            set { _Name[key] = value; }
        }
    }
}

namespace NickNameDemo
{
    class NickNameDemo
    {
        static void Main(string[] args)
        {
            NickName nickName = new NickName(); //인스턴스(개체) 생성
            nickName["; _ ;"] = "카나시이네 카나시이";
            nickName["^ _ ^"] = "우레시이네 우레시이";

            Console.WriteLine($"{nickName["; _ ;"]}, {nickName["^ _ ^"]}"); //카나시이네 카나시이, 우레시이네 우레시이
        }
    }
}


//29-6 반복기와 yield 키워드
//반복기(이터레이터): 배열과 컬렉션 형태의 데이터를 단계별로 실행하는 데 사용할 수 있음
//IEnumerable와 Yield 키워드사용

class YieldReturn
{
    static IEnumerable MultiData() //반복기(이터레이터) 구현
    {
        yield return "Hello";
        yield return "타마키";
        yield return "잘가";
    }

    static void Main(string[] args)
    {
        //반복기를 foreach 문으로 호출해서 사용
        foreach (var item in MultiData())
        {
            Console.WriteLine(item);
        }
    }
}


//29-7 반복기 코드에 for 누프 사용하기

class YieldDemo
{
    static IEnumerable Yielddemo()
    {
        yield return 1; //각각 따로따로 호출 가능
        yield return 2;
        for (int i = 3; i <= 5; i++)
        {
            yield return i; //반복해서 호출 가능 3, 4, 5
        }
    }

    static void Main()
    {
        foreach (var item in Yielddemo())
        {
            Console.Write($"{item}\t");
        }
    }
}


//29-8 이터레이터를 사용하여 배열 값을 foreach 문으로 출력하기

public class Languages
{
    private string[] _languages;

    public Languages(int Length) //매개변수가 있는 생성자
    {
        _languages = new string[Length]; //입력한 값이 필드의 크기
    }

    public string this[int index] //인덱서
    {
        get { return _languages[index]; }
        set { _languages[index] = value; }
    }

    public IEnumerable GetEnumerator()
    {
        for (int i = 0; i < _languages.Length; i++)
        {
            yield return _languages[i];
        }
    }
}


class 메인
{
    static void Main(string[] args)
    {
        Languages languages = new Languages(3); //요소 3을 갖는 개체 생성
        languages[0] = "한국어"; //인덱서를 통해 배열 필드에 값 대입
        languages[1] = "日本語";
        languages[2] = "中国語";

        foreach (var item in languages.GetEnumerator())
        {
            Console.WriteLine(item);
            
        }


    }
}


//29-9 IEnumerable<T>로 컬렉션 형태의 데이터 반환 받기

class 반환
{
    //yield 사용 전: List<T> 형태의 컬렉션 클래스를 임시로 사용하여 결괏값 저장 후 반환
    static IEnumerable<int> Greater1(int[] numbers, int greater)
    {
        List<int> temp = new List<int>(); //임시 리스트 개체
        foreach (var item in numbers)
        {
            if (item > greater)
            {
                temp.Add(item); //데이터를 저장해서 출력
            }
        }
        return temp;
    }

    //yield 사용 후; 추가 클래스 사용 없이 여러 데이터를 yield return으로 반환
    static IEnumerable<int> Greater2(int[] numbers, int greater)
    {

        foreach (var item in numbers)
        {
            if (item > greater)
            {
                yield return item; //yield 키워드를 사용해서 출력
            }
        }
    }



    static void Main(string[] args)
    {
        int[] 숫자 = { 1, 2, 3, 4, 5 };
        //yield 사용 전
        foreach (var item in Greater1(숫자, 3))
        {
            Console.WriteLine(item); //4, 5
        }

        //yield 사용 후
        foreach (var item in Greater2(숫자, 3))
        {
            Console.WriteLine(item); //4, 5
        }
    }
}


//29-10 IEnumerable<T>의 MoveNext() 메서드와 Current 속성
//MoveNext() - 데이터를 하나씩 선택하고, 다음 값이 있다면 true 반환
//Current 속성 - 현재 값 가져오기

class 자고싶다
{
    static IEnumerable GetNumber()
    {
        yield return 1;
        yield return 3;
        yield return 5;
    }

    static void Main(string[] args)
    {
        var num = GetNumber().GetEnumerator();

        Console.WriteLine(num.MoveNext()); //true
        Console.WriteLine(num.Current); //1

        Console.WriteLine(num.MoveNext()); //true
        Console.WriteLine(num.Current); //3

        Console.WriteLine(num.MoveNext()); //true
        Console.WriteLine(num.Current); //5

        Console.WriteLine(num.MoveNext()); //false
        Console.WriteLine(num.Current); //5

        Console.WriteLine(num.MoveNext()); //false
        Console.WriteLine(num.Current); //5
    }
}



