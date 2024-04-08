using System;

class 클래스_라이브러리
{
    static void Main(string[] args)
    {
        Console.WriteLine("42.클래스 라이브러리와 닷넷 스탠다드");
        Console.WriteLine("정의: 재사용 가능한 코드를 DLL 파일로 압축해서 관리하는 기능을 제공");
        Console.WriteLine("특징: 단독으로 실행하지 않고 다른 프로그램에서 참조해서 사용할 수 있는 구조\n");

        Console.WriteLine("클래스 라이브러리 프로젝트의 종류");
        Console.WriteLine("1.클래스 라이브러리(.NET Framework)");
        Console.WriteLine("2.클래스 라이브러리(.NET Core)");
        Console.WriteLine("3.클래스 라이브러리(자마린)");
        Console.WriteLine("4.클래스 라이브러리(.NET Standard)\n");

        Console.WriteLine("닷넷 스탠다드(.NET Standard)");
        Console.WriteLine("닷넷을 사용하는 모든 영역에서 공통으로 쓸 수 있는 API를 모아 놓을 수 있다.\n");


        Console.WriteLine("닷넷 어셈블리 or 어셈블리(assembly)");
        Console.WriteLine("정의: 컴파일된 소스 코드의 결과. DLL파일을 어셈블리라고 표현함");

        

    }
}

//ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
//42-1 닷넷 스탠다드 프로젝트로 자신만의 라이브러리 만들기

//닷넷 스탠다드 - Creator.csㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

//클래스 라이브러리 프로젝트는 Main() 메서드에 Console.WriteLine()처럼 직접 내용을 출력하는게 아닌,
//말 그대로 라이브러리 형태로 주요 API를 담아 놓는 기능을 한다.
//(공통으로 사용할 기능을 클래스 라이브러리에 모아 놓으면 나중에 재사용하기 좋다.)

namespace Dul
{
    public class Creator
    {
        
        public static string GetName()
        {
            return "RedPlus";
        }
    }
}

//닷넷 스탠다드 - Math.csㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

namespace Dul
{
    public class Math
    {
        /// <summary>
        /// 절댓값 구하기
        /// </summary>
        /// <param name="자연수"></param>
        /// <returns>절댓값</returns>
        public static int Abs(int number)
        {
            return (number < 0) ? -number : number;
        }
    }
}

//닷넷 스탠다드 - StringLibraryㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

namespace Dul
{
    public static class StringLibrary
    {
        /// <summary>
        /// 주어진 문자열을 주어긴 길이만큼 잘라서 반환. 나머지 부분은 ...을 붙임
        /// </summary>
        /// <param name="cut">원본 문자열</param>
        /// <param name="length">잘라 낼 길이</param>
        /// <returns>안녕하세요. => 안녕...</returns>
        public static string CutString(this string cut, int length, string suffix = "...")
        {
            if (cut.Length > (length - 3))
            {
                return cut.Substring(0, length - 3) + "" + suffix;
            }

            return cut;
        }

        /// <summary>
        /// 유니코드 이모티콘을 포함한 문자열 자르기
        /// </summary>
        /// <param name="str">한글, 영문, 유니코드 문자열</param>
        /// <param name="length">자를 문자열의 길이</param>
        /// <returns>안녕하세요 => 안녕...</returns>
        public static string CutStringUnicode(this string str, int length, string suffix = "...")
        {
            string result = str;

            var si = new System.Globalization.StringInfo(str);
            var l = si.LengthInTextElements;

            if (l > length - 3)
            {
                return si.SubstringByTextElements(0, length - 3) + "" + suffix;
            }

            return result;
        }
    }
}

//콘솔 앱 - Program.csㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

using System;

namespace Dul.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Creator 호출 테스트
            Console.WriteLine(Dul.Creator.GetName());

            //2. Math 호출 테스트
            Console.WriteLine(Dul.Math.Abs(-1234)); //1234
            Console.WriteLine(Dul.Math.Abs(1234)); //1234

            //3.StringLibrary 호출 테스트
            Console.WriteLine(Dul.StringLibrary.CutString("안녕하세요.",5)); //안녕...
            Console.WriteLine(Dul.StringLibrary.CutStringUnicode("안녕하세요.",5)); //안녕...

            
        }
    }
}

//ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
