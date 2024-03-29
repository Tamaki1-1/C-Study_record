using System;


class collection
{
    static void Main(string[] args)
    {

        Console.WriteLine("\n10.컬렉션 - 데이터 여러 개를 담을 수 있는 그릇");

        //컬렉션의 종류 (배열, 리스트, 사전)

        var array = new int[] { 1, 2, 3, 4 }; // 배열 미리보기

        var list = new List<string>() { "A", "B", "C" }; //리스트 미리보기

        var dictionary = new Dictionary<int, string> { //사전 미리보기
            {0,  "a" }, 
            {1 , "b" }, 
            {2,  "c"}};


        Console.WriteLine("\n10-1 일차원 배열 알아보기 (데이터 여러 개를 저장하는 데이터 구조)");

        string[] 배열 = new string[3]; // 3칸의 데이터 그릇 생성 0, 1, 2
        배열[0] = "안녕하세요";
        배열[1] = "こんにちは！";
        배열[2] = "hello";

        Console.WriteLine(배열[0]);   //배열[0] 출력
        Console.WriteLine(배열[1]);   //배열[1] 출력


        //for 함수를 활용해 배열을 전부 출력하기

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"나라별 인사법: {배열[i]}");
        }

        //foreach문을 활용해 출력하기

        foreach (var xx in 배열)
        {
            Console.WriteLine(xx);
        }

        //국어, 영어, 수학의 점수의 합계와 평균를 뽑아내기

        int[] 점수 = new int[3];
        점수[0] = 68; //국어
        점수[1] = 51; //영어
        점수[2] = 86; //수학

        int 합계 = 점수[0] + 점수[1] + 점수[2];
        double 평균 = 합계 / 3.0f;

        Console.WriteLine($"합계는: {합계}, 평균은 {평균:F2}");



        Console.WriteLine("\n10-2 이차원 배열 사용해보기");
        int[,] 이차원 = new int[2, 2];
        이차원[0, 0] = 1;
        이차원[0, 1] = 2;
        이차원[1, 0] = 3;
        이차원[1, 1] = 4;

        //for함수로 이차원 배열의 전체를 출력해보기

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine(이차원[i,j]);
            }
        }


        //이차원 배열을 선언과 동시에 초기화하기
        int[,] 이차원1 = { { 1, 2, 3}, { 4, 5, 6 } };


        for (int i = 0; i <= 2; i++)
        {
            for (int j = 0; j <= 2; j++)
            {
                Console.WriteLine(이차원1[i,j]);

            }

        }

        //이차원 배열을 활용해 국어, 수학, 영어의 점수 합계와 평균을 출력하는 프로그램

        int[,] 점수1 = {
            {75, 89, 90, 0, 0},
            {60, 92, 30, 0, 0},
            {91, 59, 69, 0, 0 } };

        Console.WriteLine("국어\t수학\t영어\t합계\t평균");

        for (int i = 0; i <= 2; i++) //합계와 평균에 값 대입
        {
            점수1[i, 3] = 점수1[i, 0] + 점수1[i, 1] + 점수1[i, 2]; //합계 넣기
            점수1[i, 4] = 점수1[i, 3] / 3;
        }

        for (int t = 0; t <= 3; t++)
        {

            for (int j = 0; j <= 5; j++)
            {
                Console.Write($"{점수1[t,j]}\t");
            }
            Console.WriteLine();
        }



    }


}
