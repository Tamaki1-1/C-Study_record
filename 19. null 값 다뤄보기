using System;
using System.Collections;
using System.Collections.Generic;


class 널다뤄줄게
{


    static void Main(string[] args)
    {
        Console.WriteLine("19.null 다루기");

        bool a = ("" == null) ? true : false; //""(빈 값)과 null은 다르다
        Console.WriteLine(a); //false

        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("19-1 null 가능 형식: Nullable<T> 형식");
        Console.WriteLine("bool 형식은 true, false의 값을 가진다.");
        Console.WriteLine("Nullable<T>형식은 true, false, null의 값을 가진다.");


        Nullable<bool> b = null; //기존 bool 형식과 달리 null 값이 가능하다.

        int? 널가능 = null; //줄임 표현으로 ?를 붙이면 null가능 형식이 된다.
        int? 널가능3 = 123;
        double? 널가능2 = null; //double도 마찬가지

        Console.WriteLine(널가능.HasValue); //HasValue 멤버 - 값이 있으면 true, 아니라면 false
        Console.WriteLine(널가능3.Value); //Value 멤버 - 값 반환
        Console.WriteLine(널가능.GetValueOrDefault()); //값 또는 기본값(Default) 반환

        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("19-2 null 병합 연산자(?? 연산자) - 왼쪽 항이 null이 아니라면 해당 값을 반환하고, 아니라면 오른쪽 값을 반환");

        string? 변수 = null;
        string? 메세지 = 변수 ?? "[변수]는 null입니다."; //[변수]가 null이므로 오른쪽 항 출력
        string? 변수2 = "안녕하세요.";
        string? 메세지2 = 변수2 ?? "[변수]는 null입니다."; //[변수]에 값이 있으므로 왼쪽 항 출력
        string? 변수3 = "";
        string? 메세지3 = 변수3 ?? "[변수]는 null입니다."; //""과 null을 다르므로 "" 출력

        Console.WriteLine(메세지); //오른쪽 항 출력
        Console.WriteLine(메세지2); //왼쪽 항 출력
        Console.WriteLine(메세지3); //왼쪽 항 출력



        //null 병합 연산자와 default 키워드

        int? 인트 = null;
        int 변환 = 인트 ?? 100; //100
        int 변환2 = 인트 ?? default; //기본값인 0
        int 변환3 = 인트 ?? default(int); //기본값인 0
        Console.WriteLine($"{변환}, {변환2}, {변환3}");



        //null 병합 연산자와 null 가능 형식을 함께 사용하기
        bool? 병합_연산자 = null;
        bool? 병합_연산자2 = false;

        if (병합_연산자 ?? true) //true
        {
            Console.WriteLine("출력됨"); //출력됨
        }
        if (병합_연산자2 ?? true) // false
        {
            Console.WriteLine("출력됨"); //출력되지 않음
        }

        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("19-3 null 조건부 연산자 (?.)");
        Console.WriteLine("변수의 값이 null이면 ?.연산자를 실행했을 때 null 값을 반환하고,");
        Console.WriteLine("아니라면 ?.연산자 뒤에 오는 메서드를 실행합니다.");

        double? 병수 = null; //값이 없음
        Console.WriteLine(병수?.ToString()); //null

        double? 병수2 = 1.2; //값이 있음
        Console.WriteLine(병수2?.ToString("#.00")); //1.20

        string 메시지 = null;
        string 메시지2 = "안녕하세요";
        int? 크기;

        Console.WriteLine(메시지?.Length); //null
        Console.WriteLine(메시지2?.Length); //5


        //null 조건부 연산자와 컬렉션 클래스

        List<string> 제네릭 = null;

        int? 카운트 = 제네릭?.Count; //제네릭이 null 값이므로 ?.뒤에 있는 멤버는 실행되지 않는다.
        Console.WriteLine(카운트); //null 출력
        Console.WriteLine(제네릭?.Count); //null


        List<string> 제네릭2 = new List<string>();
        제네릭2.Add("카나시이");
        제네릭2.Add("타노시이");
        제네릭2.Add("나츠카시이");

        Console.WriteLine(제네릭2?.Count); //3

        //null 조건부 연산자와 null 병합 연산자 함께 사용하기

        List<string> 리스트 = null;
        Console.WriteLine(리스트?.Count ?? 0); //리스트는 null이므로 병합 연산자(??)의 효과로 오른쪽 항 실행. 즉, 0

        List<string> 리스트2 = new List<string>();
        리스트2.Add("안녕하세요");
        리스트2.Add("잘가세요");

        Console.WriteLine(리스트2?.Count ?? 0); //값이 있으므로 2
        


    }
}
