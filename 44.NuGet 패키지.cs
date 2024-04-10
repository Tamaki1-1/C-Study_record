using System;
using Dul;

class Program
{
    static void Main(string[] args)
    {
        //Creator 호출 테스트
        Console.WriteLine(Creator.GetName());

        //Math 호출 테스트
        Console.WriteLine(Dul.Math.Abs(-1234)); //Math 클래스의 Abs()와 충돌 방지

        //StringLibrary 호출 테스트
        Console.WriteLine("안녕하세요".CutStringUnicode(6));

        //DateTimeUtility 호출 테스트
        Console.WriteLine(DateTimeUtility.ShowTimeOrDate(DateTime.Now));

        //RedPlus
        //1234
        //안녕하...
        //11:26:27
    }
}
