using System;
using System.Threading;
using System.Diagnostics;


class 비동기_프로그래밍
{
    public static void Hi() => Console.WriteLine("Hi");

    static void Main(string[] args)
    {
        Console.WriteLine("45.스레드");
        Console.WriteLine("순차적으로 처리되지 않고, 여러 기능을 동시 다발적으로 실행할 때 사용하는 개념\n");
        Console.WriteLine("System.Threading 네임스페이스를 선언하고, ThreadStart 대리자로 스레드를 선언해야 됨");

        //스레드 선언 방식
        Thread t1 = new Thread(Hi);
        Thread t2 = new Thread(new System.Threading.ThreadStart(Hi));
        t1.Start(); //Threading의 Start() 메서드로 호출
        t2.Start();

        Console.WriteLine("프로세스와 스레드");
        Console.WriteLine("-프로세스: 현재 실행 중인 프로그램을 프로세스라고 한다.");
        Console.WriteLine("-스레드: 운영 체제가 프로세서 시간을 할당하는 기본 단위이다.\n");

        Console.WriteLine("병렬 프로그래밍");
        Console.WriteLine("-여러 스레드를 사용하여 일을 진행하는 방식\n");

        Console.WriteLine("Thread 클래스의 주요 속성 및 메서드");
        Console.WriteLine("-Priority: 스레드의 우선 순위를 결정합니다. ThreadPriority 열거형의" +
                          "Highest, Normal, Lowest 값을 갖습니다.");
        Console.WriteLine("-Abort(): 스레드를 종료시킵니다.");
        Console.WriteLine("-Sleep(): 스레드를 설정된 밀리초(1000분의 1초)만큼 중지시킵니다.");
        Console.WriteLine("-Start(): 스레드를 시작합니다.");



    }

    

}


//45-1 스레드 생성 및 호출하기

class ThreadDemo
{
    static void Other()
    {
        Console.WriteLine("[?] 다른 작업자 일 실행");
        Thread.Sleep(3000); //3초동안 대기
        Console.WriteLine("[?] 다른 작업자 일 종료");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("[1] 메인 작업자 일 시작");

        //Thread 클래스와 ThreadStart 대리자로 새로운 스레드 생성
        Thread other = new Thread(new ThreadStart(Other));
        other.Start(); //새로운 스레드 생성

        Console.WriteLine("[2] 메인 작업자 일 종료");

        //결과
        //[1] 메인 작업자 일 시작
        //[2] 메인 작업자 일 종료
        //[?] 다른 작업자 일 실행
        //[?] 다른 작업자 일 종료
    }
}


//45-2 다중 스레드를 사용한 메서드 함께 호출하기

class ThreadPractice
{
    private static void Ide()
    {
        Thread.Sleep(3000); //3초 딜레이
        Console.WriteLine("[3] IDE : Visual Studio");
    }

    private static void Sql()
    {
        Thread.Sleep(3000); //3초 딜레이
        Console.WriteLine("[2] DBMS : SQL Server");
    }

    private static void Win()
    {
        Thread.Sleep(3000); //3초 딜레이
        Console.WriteLine("[1] OS : Windows Server");
    }

    static void Main(string[] args)
    {
        //스레드
        ThreadStart ts1 = new ThreadStart(Win);
        ThreadStart ts2 = new ThreadStart(Sql);

        Thread t1 = new Thread(ts1);
        Thread t2 = new Thread(ts2);
        Thread t3 = new Thread(new ThreadStart(Ide))
        {
            Priority = ThreadPriority.Highest //우선순위 높게
        };

        t1.Start(); //결과가 매번 다르게 출력됨
        t2.Start();
        t3.Start();


        //프로세스
        Process.Start("Notepad.exe"); //메모장이 실행됨
    }
}


//45-3 스레드 동기화
//여러 스레드가 같은 메서드를 실행하는 동안 다른 스레드도 같은 메서드를
//실행하려고 해서 오류가 발생하는데, 이를 엑세스하지 못하도록 잠그는 기능

class 스레드_동기화
{
    static void Main(string[] args)
    {
        lock (this)
        {
            //스레드 동기화가 필요한 코드 블록
        }
    }
}


//45-4 병렬 프로그래밍
//일반적인 형태인 "동시성(프로세서를 하나만 씀)"과
//병렬 프로그래밍인 "병렬 처리(프로세서를 여러개 씀)"의 차이
//Parallel 클래스를 활용하여 병렬 처리 가능

class 병렬_프로그래밍
{
    static void Main(string[] args)
    {
        //동시성 - 논리 프로세서 1개만 100% 사용됨
        for (int i = 0; i < 200000; i++)
        {
            Console.WriteLine(i);
        }

        //병렬 처리 - 컴퓨터의 자원을 최대한 사용하여, 많은 논리 프로세서를 사용함
        Parallel.For(0, 200_000, (i) => Console.WriteLine(i));
    }
}

