using System;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

class LINQ
{
    static void Main(string[] args)
    {
        Console.WriteLine("20.LINQ - 컬렉션 형태의 데이터를 가공할 때 유용한 확장 메서드를 제공하는 시스템");


        //Sum() - 컬렉션의 합

        int[] 배열 = { 1, 2, 3 };

        int 합계 = 배열.Sum(); //Sum() = 컬렉션에 들어 있는 데이터의 전체 합
        Console.WriteLine(합계); // 1 + 2 + 3 = 6


        //Count() - 컬렉션 배열의 갯수

        int[] 배열2 = { 1, 2, 3, 4, 5 };

        int 카운트 = 배열2.Count(); //5
        Console.WriteLine(카운트); //5

        //Average() - 컬렉션의 평균

        int[] 배열3 = {1,3,4};

        double 평균 = 배열3.Average(); //배열3의 평균값을 저장
        Console.WriteLine($"{nameof(배열3)}의 평균: {평균:#,###.##}"); //2.67 //nameof() - 매개 변수 안에 있는 변수의 "이름"을 불러온다.

        //Max() - 컬렉션 중 최대값

        List<int> 배열4 = new List<int>() { 1, 2, 3 };

        int 최대값 = 배열4.Max();

        Console.WriteLine($"{nameof(배열4)}의 최대값: {최대값}");

        //Min() - 컬렉션 중 최소값

        List<double> 배열5 = new List<double> { 1.2, 3.8, 5.77 };

        double 최소값 = 배열5.Min();

        Console.WriteLine($"{nameof(배열5)}의 최솟값: {최소값}");


        Console.WriteLine("20-1 화살표 연산자와 람다 식으로 조건 처리");

        //식 람다 미리보기 코드
        Func<int, bool> isEven = x => x % 2 == 0; //매개변수에 짝수면 true, 아니면 false
        Console.WriteLine(isEven(3)); //false
        Console.WriteLine(isEven(4)); //true

        //문 람다 미리보기 코드
        Action<string> greet = 이름 => { var 메세지 = $"hello {이름}"; Console.WriteLine(메세지); };
        greet("김환수"); // Hello 김환수


        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("20-2 IEnumerable<T> 형태의 데이터");
        Console.WriteLine("정의: List<T>와 비슷하지만 읽기 전용 컬렉션이다.");
        int[] 인트 = { 1, 2, 3, 4, 5 };
        IEnumerable<int> 조건 = 인트.Where(n => n >= 3); //Where() - 조건에 맞는 배열만 출력

        //3이랑 같거나 큰 배열만 출력
        foreach (var item in 조건)
        {
            Console.WriteLine(item); //3, 4, 5
        }


        //ToList() 메서드로 IEnumerable<T>를 List<T>로 변환 해보기

        int[] 인트2 = { 1, 2, 3, 4, 5 };
        List<int> 조건2 = new List<int>();
        조건2 = 인트2.Where(n => n >= 3).ToList(); //ToList() - List<T> 형태로 받는 메서드

        foreach (var item in 조건2)
        {
            Console.WriteLine(item);
        }

        //Where() 메서드로 조건 처리해보기 

        int[] 인트3 = { 1, 2, 3, 4, 5 };
        List<int> 조건3 = 인트3.Where(x => x % 2 == 0).ToList(); //짝수만 가져옴
        var 인트4 = new List<int> {1, 2, 3, 4, 5 };
        int 조건4 = 인트4.Where(x => x % 2 == 1).Sum(); //홀수의 합계

        foreach (var item in 조건3)
        {
            Console.WriteLine(item); // 2, 4
        }

        Console.WriteLine($"{nameof(조건4)}의 sum: {조건4}"); // 9

        //짝수고 3보다 큰 조건 처리해보기

        int[] 배열1 = {1,2,3,4,5,6,7,8,9,10 };
        var 처리 = 배열1.Where(x => x % 2 == 0 && x > 3);

        foreach (var item in 처리)
        {
            Console.WriteLine(item); //4, 6, 8, 10
        }

        //Where() 메서드를 사용하지 않고 조건 처리

        bool[] 불스 = { true, false, true, false, false };
        Console.WriteLine(불스.Count()); //5
        Console.WriteLine(불스.Count(x => x == true)); //true의 수: 2
        Console.WriteLine(불스.Count(x => x == false));//false의 수 : 3



        //All()과 Any() 메서드로 조건을 판단하기
        //All() - 배열에서 전부 true여야 참, 아니면 false(&&)
        //Any() - 배열에서 하나라도 true면 참, 아니면 false(||)

        bool[] 불스2 = { true, false, true, false, false };
        Console.WriteLine(불스2.All(x => x == true)); //false
        Console.WriteLine(불스2.Any(x => x == true)); //true

        //Any() 메서드로 컬렉션에 특정 요소가 하나라도 있는지 확인

        int[] 배열6 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
        Console.WriteLine(배열6.Any(x => x == 2)); //true
        Console.WriteLine(배열6.Any(x => x == 10)); //false



        //Take()와 Skip() 메서드로 필요한 건수의 데이터 가져와보기
        //Take() - 지정한 양만큼의 배열만 가져옴
        //Skip() - 지정한 수만큼 데이터를 제외한 컬렉션을 반환

        var 데이터 = Enumerable.Range(0, 100); // 0~99

        foreach (var item in 데이터.Take(5)) //데이터에서 5개만 반환
        {
            Console.WriteLine(item); //1, 2, 3, 4, 5
        }

        foreach (var item in 데이터.Skip(10).Take(5)) //10개를 제외하고(Skip) 5개만 반환(Take)
        {
            Console.WriteLine(item); //10, 11, 12, 13, 14, 15
        }


        //Distinct() 확장 메서드로 중복 제거하기

        int[] 중복 = { 1, 1, 1, 2, 2, 2, 2, 3, 3 };
        var 제거 = 중복.Distinct();
        foreach (var item in 제거)
        {
            Console.WriteLine(item); //1, 2, 3
        }
        Console.WriteLine(제거.Count()); //배열의 수: 3


        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("20-3 데이터 정렬과 검색");

        //OrderBy() 메서드로 문자열 컬렉션 오름차순으로 정렬하기
        string[] 색상 = { "빨강", "파랑", "연두" };
        var 정렬 = 색상.OrderBy(x => x);

        foreach (var item in 정렬)
        {
            Console.Write($"{item}    "); //빨강    연두    파랑
        }
        Console.WriteLine();


        //OrderByDescending() 메서드로 문자열 컬렉션 내림차순 정렬하기
        string[] 색상2 = { "빨강", "파랑", "연두", "검정"};
        var 정렬2 = 색상2.OrderByDescending(x => x);

        foreach (var item in 정렬2)
        {
            Console.Write($"{item}    "); //파랑    연두    빨강    검정
        }

        //짝수인 데이터만 내림차순 정렬하기
        var 숫자 = Enumerable.Range(1, 10);
        var 짝수내림차순 = 숫자.Where(x => x % 2 == 0).OrderByDescending(x => x);
        Console.WriteLine();

        foreach (var item in 짝수내림차순)
        {
            Console.Write($"{item}    "); //10    8    6    4    2
        }
        Console.WriteLine();


        //특정 문자열을 포함하는 컬렉션 가져와보기 (Contains() 메서드)
        //Contains() - 매개변수 안에 있는 문자열을 포함하는 리스트를 읽어 온다.

        string[] 색상3 = { "Red", "Green", "Blue", "Black" };
        var 특정_문자열 = 색상3.Where(x => x.Contains("e") || x.Contains("E")).OrderBy(x => x); //e와 E가 포함된 문자열을 가져온다.

        foreach (var item in 특정_문자열)
        {
            Console.WriteLine(item); //Blue Green Red
        }


        //Single()과 SingleOrDefault() 확장 메서드 - 배열에서 조건에 맞는 단 하나만 가져오는 메서드
        //Single() - null 값이면 예외가 발생한다.
        //SingleOrDefault() - 값이 없다면 null을 반환한다.

        string[] 색상4 = { "빨강", "파랑", "연두" };
        var 싱글 = 색상4.Single(x => x == "빨강"); //없는 값일경우 예외 발생
        var 싱글2 = 색상4.SingleOrDefault(x => x == "블랙"); //없는 값이니 null 출력
        var 싱글3 = 색상4.SingleOrDefault(x => x == "빨강"); //있는 값이니 그대로 읽어 온다.

        Console.WriteLine(싱글); //빨강
        Console.WriteLine(싱글2);//null
        Console.WriteLine(싱글3);//빨강


        //First()와 FirstOrDefault() 확장 메서드 - 하나 이상의 데이터 중에서 첫 번째 데이터를 가져온다.
        //First() - 첫 번째 요소가 없으면 에러가 발생한다.
        //FirstOrDefault() - 첫 번째 요소과 없다면 기본값을 반환한다.

        List<string> 색상5 = new List<string> { "빨강!", "파랑!", "블랙!" };
        var 퍼스트 = 색상5.First(); //빨강!  //값이 없다면 예외 발생
        var 퍼스트2 = 색상5.First(x => x == "파랑!"); //값이 없다면 예외 발생

        var 퍼스트3 = 색상5.FirstOrDefault(x => x == "보라!");//값이 없으니 null
        var 퍼스트4 = 색상5.FirstOrDefault(x => x == "블랙!");

        Console.WriteLine(퍼스트); //빨강!
        Console.WriteLine(퍼스트2);//파랑!
        Console.WriteLine(퍼스트3);//null
        Console.WriteLine(퍼스트4);//블랙!
        
    }

}
