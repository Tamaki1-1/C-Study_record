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
