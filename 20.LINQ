using System;
using System.Linq;



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


    }

}
