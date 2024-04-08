using System;

class 테스트_프로젝트
{
    static void Main(string[] args)
    {
        Console.WriteLine("43.자동 테스트의 장점");
        Console.WriteLine("1.에러를 쉽게 찾고 수정할 수 있다." +
                          "2.직접 하나씩 테스트하는 것보다 아주 빠르게 많은 수의 테스트를 진행" +
                          "3.작성한 코드 검증을 할 수 있다.\n");

        Console.WriteLine("MSTest - 비주얼 프로젝트에 기본으로 내장된 테스트 프로젝트");
        Console.WriteLine("Nunit - JUnit 영향을 받은 오픈 소스 단위 테스트 프로젝트");
        Console.WriteLine("xUnit - 닷넷 전용오픈 소스 단위 테스트 프로젝트\n");


        Console.WriteLine("Assert 클래스의 주요 API 미리 살펴보기");
        Console.WriteLine("Assert.IsTrue() - 매개변수 값이 true이면 테스트 통과");
        Console.WriteLine("Assert.IsNull() - 매개변수 값이 null이면 테스트 통과");
        Console.WriteLine("Assert.AreEqual() - 매개변수 값 2개가 같으면 테스트 통과");
        Console.WriteLine("Assert.AreNotEqual() - 매개변수 값 2개가 다르면 테스트 통과");
    }
}
