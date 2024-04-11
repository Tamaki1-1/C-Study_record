using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO.Pipes;


class 비동기_프로그래밍
{
    static void Main(string[] args)
    {
        Console.WriteLine("46.비동기 프로그래밍(async, await 키워드)");
        Console.WriteLine("정의: 메서드 여러 개를 동시에 실행하거나, \n" +
                          "대기 시점을 변경하여 순서를 재정의 할 수 있음.");

        
    }
}


//46-1 동기 프로그래밍(순서대로 실행됨)

class 동기
{
    static void Summ(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }
    static void Main(string[] args)
    {
        Summ(1, 2); //1 + 2 = 3
        Summ(2, 3); //2 + 3 = 5
        Summ(3, 4); //3 + 4 = 7
    }
}


//46-2 비동기 프로그래밍(여러 작업을 한번에 수행)

//"I/O 바인딩된 코드"(CPU 사용량이 많은 코드)

class AsyncMain
{
    static async Task Main(string[] args) //async = 비동기 메서드 시그니처
    {
        await Task.Delay(2000); //await = 비동기로 호출
        Console.WriteLine("비동기 메인 메서드");
    }
}

//async = 비동기 메서드 표시
//await = 현재 코드를 실행할 때까지 대기, 스레드의 Start() 메서드 호출이 필요하지 않음.
//비동기 메서드 반환값 = void, Task, Task<T> 형태



//46-3 간단한 async와 await 키워드 사용 예제
//HttpClient 클래스로 async와 await 키워드가 사용되는 형태를 먼저 익혀두기

class AsyncAwaitSimple
{
    //비동기 메서드를 호출하는 DoAsync() 메서드를 생성할 때는 async 키워드를 붙임
    static async Task DoAsync()
    {
        using (var client = new HttpClient()) //특정 웹 사이트 또는 RESTFul 서비스인 Web API를 호출해서 그 결괏값을 가져옴
        {
            //.NET API의 비동기 메서드를 호출할 때 await 키워드를 붙임
            var r = await client.GetAsync("https://dotnetnote.azurewebsites.net/api/WebApiDemo");
            var c = await r.Content.ReadAsStringAsync();

            Console.WriteLine(c);
        }
    }

    static async Task Main(string[] args) //비동기 메인 메서드
    {
        await DoAsync(); //{"name":"\uBC15\uC6A9\uC900"}
    }
}


//46-4 Task.Run() 메서드로 비동기 메서드 호출하기
//동기 메서드에서 비동기 메서드를 호출

class AsyncAwaitDescription
{
    static void Main(string[] args) //동기 메서드
    {
        Task.Run(DoPrint);
        Console.WriteLine("[?] async await 사용 예제");
        Thread.Sleep(1);

    }

    static async Task DoPrint()
    {
        await PrintNumberAsync();
    }

    static async Task PrintNumberAsync()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 300; i++)
            {
                Console.WriteLine(i + 1);
            }
        });
    }
}


//46-5 Task.FromResult()를 사용하여 비동기로 반환값 전달하기
//Async 메서드가 아닐 때는 Task.FromResult() 메서드로 묶어 반환

public class WeatherForecast //속성 클래스
{
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public int TemperatureF { get; set; }
    public string Summary { get; set; }
}

public class WeatherForecastService
{
    private static string[] summaries = new[] //배열 필드
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild",
        "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {
        var rng = new Random(); //랜덤 클래스 인스턴스 생성
        return Task.FromResult(Enumerable.Range(1, 5).Select(idx => new WeatherForecast
        {
            //속성 값 대입
            Date = startDate.AddDays(idx), //날짜 대입
            TemperatureC = rng.Next(-20, 55), //온도 랜덤 적용
            Summary = summaries[rng.Next(summaries.Length)] //날씨를 랜덤 적용
        }).ToArray()); //배열화
    }
}

class WeatherForecastApp
{
    static async Task Main()
    {
        var service = new WeatherForecastService(); //개체 생성
        var forecasts = await service.GetForecastAsync(DateTime.Now);

        Console.WriteLine("Date\t\tTemp. (C)\t\tTemp. (F)\t\tSummary");
        foreach (var item in forecasts)
        {
            Console.WriteLine($"{item.Date.ToShortDateString()}\t{item.TemperatureC}" +
                $"\t\t\t{item.TemperatureF}\t\t\t{item.Summary}");
        }
        //Date             Temp. (C)              Temp. (F)               Summary
        //2024 - 04 - 12   18                     0                       Hot
        //2024 - 04 - 13   12                     0                       Chilly
        //2024 - 04 - 14   13                     0                       Hot
        //2024 - 04 - 15   29                     0                       Cool
        //2024 - 04 - 16   18                     0                       Warm
    }

    //특정 결괏값을 Task<T>로 돌려주면 Task.FromResulf() 메서드로 묶어 줌
}


//46-6 async와 await를 사용한 C# 비동기 프로그래밍하기
//ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
//동기 프로그래밍(스레드 차단)
//=> 밥을 지을 때 보면서 기다림.

//비동기 프로그래밍(동기 프로그래밍 포함)
//=> 밥을 지으면서 TV를 보면서 기다린다.

//비동기 프로그래밍(동시 작업 시작)
//=> 밥과 국과 달걀 프라이를 같이 하면서 TV를 보면서 기다린다.

//동기 프로그래밍과 비동기 프로그래밍 실행 시간
//=> 동기 프로그래밍과 동기 프로그래밍이 포함된 비동기 프로그래밍은 동일한 시간이 걸림.
//=> 순수 비동기 프로그래밍은 비동기 중에서 가장 오래 걸리는 시간과 비슷함.
//ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

//솔루션 및 공통 사용 프로젝트 만들기
//Dinner.Common 프로젝트 => Cooking.cs
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Dinner.Common
{
    public class Rice { }; //Pass
    public class Soup { }; //Pass
    public class Egg { }; //Pass

    public class Cooking
    {
        //동기 방식의 밥 만들기 메서드
        public Rice MakeRice()
        {
            Console.WriteLine("밥 짓는 중..");
            Thread.Sleep(3000); //3초 대기
            return new Rice();
        }

        //비동기 방식의 밥 만들기 메서드
        public async Task<Rice> MakeRiceAsync()
        {
            Console.WriteLine("밥 생성 중...");
            await Task.Delay(3000); //3초 대기
            return new Rice();
        }


        //동기 방식의 국 만들기 메서드
        public Soup MakeSoup()
        {
            Console.WriteLine("국 생성 중...");
            Thread.Sleep(3000);
            return new Soup();
        }

        //비동기 방식의 국 만들기 메서드
        public async Task<Soup> MakeSoupAsync()
        {
            Console.WriteLine("국 생성중...");
            await Task.Delay(3000);
            return new Soup();
        }



        //동기 방식의 달걀 만들기 메서드
        public Egg MakeEgg()
        {
            Console.WriteLine("달걀 후라이 생성중...");
            Thread.Sleep(3000);
            return new Egg();
        }

        //비동기 방식의 달걀 만들기 메서드
        public async Task<Egg> MakeEggAsync()
        {
            Console.WriteLine("달걀 생성중...");
            await Task.Delay(TimeSpan.FromMilliseconds(3000));
            return await Task.FromResult(new Egg());
        }
    }
}



//Dinner.Sync 프로젝트 => Program.cs
//동기 프로그램은 모든 작업이 실행되는 동안 스레드를 차단하여 단계별로 실행함.
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Dinner.Common;

namespace Dinner.Sync
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch(); //타이머 개체 생성
            stopwatch.Start(); //타이머 시작

            Rice rice = (new Cooking()).MakeRice();
            Console.WriteLine($"밥 준비 완료: {rice.GetHashCode()}");

            Soup soup = (new Cooking()).MakeSoup();
            Console.WriteLine($"국 준비 완료: {soup.GetHashCode()}");

            Egg egg = (new Cooking()).MakeEgg();
            Console.WriteLine($"달걀 준비 완료: {egg.GetHashCode()}");

            stopwatch.Stop();
            Console.WriteLine($"시간: {stopwatch.ElapsedMilliseconds}밀리초");
            Console.WriteLine("동기 방식으로 식사 준비 완료.");
              
        }
        
    }
}

//Dinner.Async 프로젝트 => Program.cs
//의미상으로 비동기 프로그래밍이므로 밥을 만들면서 TV를 볼 수 있음.

using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Dinner.Common;

namespace Dinner.Async
{
    class Program
    {
        static async Task Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //타이머 시작

            Rice rice = await (new Cooking()).MakeRiceAsync(); //스레드 차단: false
            Console.WriteLine($"밥 준비 완료: {rice.GetHashCode()}");

            Soup soup = await (new Cooking()).MakeSoupAsync();
            Console.WriteLine($"국 준비 완료: {soup.GetHashCode()}");

            Egg egg = await (new Cooking()).MakeEggAsync();
            Console.WriteLine($"달걀 준비 완료: {egg.GetHashCode()}");

            stopwatch.Stop();
            Console.WriteLine($"시간: {stopwatch.ElapsedMilliseconds}");
            Console.WriteLine("비동기 방식으로 식사 준비 완료");

            
        }
    }
}
