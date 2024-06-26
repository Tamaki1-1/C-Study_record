using System;


class 예외_처리하기
{
    static void Main(string[] args)
    {
        Console.WriteLine("16. 예외와 예외 처리하기");
        Console.WriteLine("예외: 예외는 프로그램이 실행되는 동안 발생하는 에러를 의미합니다.");

        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("16.1 try~catch~finally 구문");
        Console.WriteLine("try - 혹시 모를 예외가 발생할 만한 구문");
        Console.WriteLine("catch - 예외가 발생했을 때 처리해야 하는 구문");
        Console.WriteLine("finally - 에외가 발생 또는 발생하지 않아도 마무리 관련 처리를 해야 할 구문");

        try //에러가 발생할 만한 구문
        {
         int[] aa = new int[3];
         aa[44] = 123;
        }
        catch //에러가 발생하면 실행됨
        {
            Console.WriteLine("에러가 발생했습니다.");
        }

    }


    
}

class 예외_처리하기2
{

    static void Main(string[] args)
    {
        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("16.2 Exception 클래스로 예외 처리하기");
        try
        {
            int[] aaa = new int[3];
            aaa[5] = 3;
        }
        catch (Exception ex) //Exception(예외 처리 클래스) 
        {
            Console.WriteLine(ex.Message); // Message는 예외 설명을 출력하는 메서드
        }

    }
}

class 예외_처리하기3
{

    static void Main(string[] args)
    {
        Console.WriteLine("16.3 FormatException 클래스 형식의 예외받아 처리하기");

        string 숫자 = "3.14";
        int number = 0;
        try
        {
            number = Convert.ToInt32(숫자);
            Console.WriteLine($"입력한 값 : {number}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"에러 발생: {ex.Message}");
            Console.WriteLine($"{숫자}는 정수여야 합니당.");
        }
    }
}

class 예외처리하기
{

    static void Main(string[] args)
    {
        Console.WriteLine("16-4 예외 처리 연습하기 / cs 파일 여러개 만들기");
        //에러가 나지 않는 코드 작성하기

        int x = 5;
        int y = 3;

        int r = x / y;

        Console.WriteLine(r);
    }
}
class 두번째
{

    static void Main(string[] args)
    {
        //무조건 에러 발생시키기

        int x = 5;
        int y = 0;

        int r = x / y;

        Console.WriteLine(r);
    }
}
class 세번째
{


    static void Main(string[] args)
    {
		// try~catch~finally 구문으로 예외 처리하기

        int x = 3;
        int y = 0;


		try
		{
			int r = x / y;
			Console.WriteLine(r);
		}
		catch
		{
			Console.WriteLine("예외가 발생했습니다.");
		}
		finally //예외가 발생하든 안하든 실행됨
		{
			Console.WriteLine("프로그램을 종료합니다.");
		}
    }
}
class 네번째
{
    static void Main(string[] args)
    {
        //Exception 클래스로 예외 정보 얻기
        int a = 3;
        int b = 0;

        try
        {
            int r = a / b;
            Console.WriteLine(r);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("프로그램을 종료합니다.");
        }

        
    }


}
class 쓰로윙
{

    static void Main(string[] args)
    {
        Console.WriteLine("16-5 throw 구문으로 직접 예외 발생시키기");

        Console.WriteLine("[1] 시작");

		try
		{
			Console.WriteLine("[2] 실행");
			throw new Exception();
		}
		catch (Exception)
		{
			Console.WriteLine("; _ ;.??");
		}
		finally
		{
			Console.WriteLine("프로그램을 종료합니다.");
		}

		//try, catch, finally, throw 모두 사용하기

		try
		{
			throw new Exception("내가 만든 오류");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message); //오류 내용은 "내가 만든 오류"
		}
		finally
		{
			Console.WriteLine("프로그램을 종료하겠습니다.");
		}
    }
}
    
