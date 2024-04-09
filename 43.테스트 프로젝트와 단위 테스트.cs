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

//43-1 테스트 코드 작성 및 실행하기

//MS Test 프로젝트 =>
//Dul.Tests 프로젝트

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dul.Tests
{
    [TestClass]
    public class AssertDemo
    {
        [TestMethod]
        public void AssertAreEqualTest() //우클릭 후 테스트 실행
        {
            //Assert.AreEqual(
            //  expected: "비교할 첫 번째 개체",
            //  actual: "비교할 두 번째 개체");
            Assert.AreEqual(1234, 1234); //테스트 통과
        }
    }    
}


//CreatorTest.cs
using Microsoft.VisualStudio.TestTools.UnitTesting; //테스트 구문


namespace Dul.Tests
{
    [TestClass]
    public class CreatorTest
    {
        [TestMethod]
        public void GetNameTest()
        {
            // Arrange(정렬), Setup
            const string expected = "RedPlus";

            // Act(동작), Execute
            var actual = Creator.GetName();

            // Assert(어설션), Verify
            Assert.AreEqual(expected, actual);
        }
    }
}

//Dul.Math.Abs.Test.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dul.Tests.Mathematics
{
    [TestClass]
    public class DulMathTest
    {
        [TestMethod]
        public void AbsTest()
        {
            //Arrange, Setup
            var expected = 1234;

            //Act, Execute
            var actual = Dul.Math.Abs(1234);

            //Assert, Verify
            Assert.AreEqual(expected, actual);
        }
    }
}

//StringLibraryTest.cs
using Dul;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dul.Tests
{
    [TestClass]
    public class StringLibraryTest
    {
        [TestMethod]
        public void CutStringTest()
        {
            // Arrange, Setup
            var expected = "안녕하...";

            // Act, Execute
            var actual = "안녕하세요.".CutStringUnicode(6);

            // Assert, Verify
            Assert.AreEqual(expected, actual);
        }
    }
}

//DateTimeUtilityTest.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Versioning;

namespace Dul.Tests
{
    [TestClass]
    public class DateTimeUtilityTest
    {
        [TestMethod]
        public void ShowTimeOrDateTest()
        {
            //(현재 시간 == 오늘 날짜) => 01:01:01 형태
            var now = DateTime.Now;
            var expeted = now.ToString("hh:ss:mm");

            //Assert 클래스의 주요 메서드를 사용하여 테스트 통과 확인
            Assert.AreEqual(expeted, DateTimeUtility.ShowTimeOrDate(now));

        }

        [TestMethod]
        public void ShowTimeOrDateTestOther()
        {
            //(현재 시간 != 오늘 날짜) => 2019-12-20 형태
            var prev = DateTime.Now.AddDays(-7);
            //Assert 클래스 없이 직접 실행하는 경우는 테스트 바로 통과

            //yyyy-MM-dd 형태
            Console.WriteLine(DateTimeUtility.ShowTimeOrDate(prev, "yyyy-mm-dd"));

            //yy-MM-dd 형태
            Console.WriteLine(DateTimeUtility.ShowTimeOrDate(prev, "yy-MM-dd"));
        }
    }
}
