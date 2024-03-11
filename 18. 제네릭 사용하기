using System;
using System.Collections.Generic;


class 제네릭
{

    static void Main(string[] args)
    {
        Console.WriteLine("18.제네릭 사용하기");
        Console.WriteLine("제네릭 - 특정 형식을 지정하여 컬렉션에 저장하고 사용할 수 있는 컬렉션");
        Console.WriteLine("Cup of T - 데이터 형식에 따라 해당 개체 성격을 변경하는 구조");



        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("18-1 Stack<T> 제네릭 클래스 사용해보기");

        Stack<string> 스택_문자열 = new Stack<string>(); //Stack 제네릭 클래스의 인스턴스 생성


        스택_문자열.Push("카나시이"); //Push = 데이터 입력 메서드, "스택_문자열"은 String 형식만 담을 수 있다.
        string 이모지 = 스택_문자열.Pop(); //이모지 변수에 카나시이 입력
        Console.WriteLine(이모지); //이모지 값 출력 "카나시이"


        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("18-2 List<T> 제네릭 클래스 사용해보기");

        List<int> ints = new List<int>();
        ints.Add(10); //Add = 데이터 입력 메서드, "ints"는 int 형식만 담을 수 있다.
        ints.Add(20);
        ints.Add(30);

        for (int i = 0; i < ints.Count; i++)
        {
            Console.WriteLine(ints[i]); //10, 20, 30 출력
        }


        foreach (var item in ints)
        {
            Console.WriteLine(item); //10, 20, 30 출력
        }

        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("18-3 Enumerable 클래스로 컬렉션 만들기");

        var 숫자 = Enumerable.Range(1, 10); // 1에서 10까지 정수 컬렉션 생성
        var 숫자2 = Enumerable.Range(0, 10); // 0에서 9까지 정수 컬렉션 생성

        var 숫자3 = Enumerable.Repeat(-1, 10); // -1을 열 번 반복하는 정수 컬렉션 생성

        foreach (var item in 숫자)
        {
            Console.WriteLine(item); // 1, 2, 3.... 10
        }
        Console.WriteLine();
        foreach (var item in 숫자2) // 0, 1, 2.... 10
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        foreach (var item in 숫자3) // -1, -1, -1... -1
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("18-4 Dictionary<T, T> 제네릭 클래스 사용하기");
        Console.WriteLine("키와 값으로 데이터를 저장하고 사용할 수 있는 제네릭 클래스");

        IDictionary<string, string> 딕셔널리 = new Dictionary<string, string>(); //인스턴스 생성
        var 딕셔널리2 = new Dictionary<string, string>(); //var로 줄임 형태로 인스턴스 생성도 가능


        딕셔널리.Add("한국", "김환수");
        딕셔널리.Add("日本", "たまき");

        Console.WriteLine($"{딕셔널리["한국"]}, {딕셔널리["日本"]}"); //김환수, たまき
        딕셔널리.Remove("日本"); // "日本"키 삭제로 값인 "たまき"도 삭제

        딕셔널리["짱개"] = "장첸"; //인덱서를 사용하여 데이터 입력
        Console.WriteLine(딕셔널리["짱개"]); //장첸 출력

        try
        {
            딕셔널리.Add("한국", "???"); //"한국"의 키 값 중복 오류
            Console.WriteLine(딕셔널리["한국"]);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); // An item with the same key has already been added. Key: 한국
        }

        //여러가지 방식으로 Dictionary 개체 값을 출력해보기

        foreach (KeyValuePair<string, string> item in 딕셔널리)
        {
            Console.WriteLine($"{item.Key}, {item.Value}"); 
        }

        foreach (var item in 딕셔널리)
        {
            Console.WriteLine($"{item.Key}, {item.Value}");
        }

        Console.WriteLine(딕셔널리["한국"]);

    }
}
