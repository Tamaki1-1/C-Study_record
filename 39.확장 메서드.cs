using System;


class 확장_메서드
{

    static void Main(string[] args)
    {
        Console.WriteLine("39.확장 메서드 - 원본 형식을 변경하지 않고 이미 있는 형식에 추가로 기능을 덧 붙일 수 있다.");
        Console.WriteLine("이미 만들어 있는 클래스 기능을 확장하고, 클래스와 구조체, 인터페이스에서 사용할 수 있음.");

        Console.WriteLine("확장 메서드를 만드는 법");
        Console.WriteLine("1.정적 클래스에 정적 메서드로 구현함.");
        Console.WriteLine("2.첫 번째 메서드 매개변수에 this 키워드를 붙임");
        Console.WriteLine("3.같은 범위를 같은 네임스페이스에서 호출할 수 있습니다.");
        Console.WriteLine("4.확장 메서드도 오버로드가 가능합니다.");
    }
}


//39-1 확장 메서드로 문자열 기능 확장하기

static class ExtensionFuntion //조건 1: 정적 클래스
{
    static string Three(this string value) //조건2 정적 메서드, 매개변수에 this
    {
        //특정 문자열 뒤에 이 메서드가 호출되면 문자열 중 3개만 반환
        return value.Substring(0 ,3); //Startindex, Length
    }

    static void Main(string[] args)
    {
        Console.WriteLine("안녕하세요.".Three()); //안녕하
    }
}


//39-2 확장 메서드를 사용하여 기존 형식에 새로운 메서드 추가

namespace ExtensionMethodDemo
{
    public static class MyClass
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', ',','?'},StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    class ExtensionMethodDemo
    {
        static void Main(string[] args)
        {
            string s = "안녕하세요? 확장 메서드.....";
            Console.WriteLine(s.Length); //문자의 갯수
            Console.WriteLine(s.WordCount()); //단어의 갯수
        }
    }
}


//39-3 확장 메서드를 사용하여 형식에 메서드 추가하기
//아무 멤버도 갖지 않은 클래스를 확장 메서드를 참조해서 새로운 메서드를 추가

public class Original { } //빈 클래스

public static class OriginalsExtension
{
    public static void NewMethod(this Original original) //빈 클래스를 매개변수로
    {
        Console.WriteLine("새로운 메서드 추가");
    }
}

class 메인
{
    static void Main(string[] args)
    {
        Original original = new Original();
        original.NewMethod(); //새로운 메서드 추가

        (new Original()).NewMethod(); //새로운 메서드 추가
    }
}

