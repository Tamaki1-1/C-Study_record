using System;
using System.Collections; //주요 자료 구조 관련 클래스들 호출

class 컬렉션
{


    static void Main(string[] args)
    {
        Console.WriteLine("17.배열과 컬렉션");

        Console.WriteLine("배열의 종류");
        Console.WriteLine("배열: 일반적으로 숫자처럼 간단한 데이터 형식을 저장한다.");
        Console.WriteLine("리스트: 간단한 데이터 형식을 포함한 개체들을 저장한다.");
        Console.WriteLine("사전: 키와 값의 쌍으로 관리되는 개체들을 저장한다.");

        Console.WriteLine("컬렉션의 종류");
        Console.WriteLine("Stack, Queue, ArrayList");
        Console.WriteLine("컬렉션을 사용하려면 System.Collections 네임스페이스를 선언해야 된다.");



        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("17-1 Array 클래스 - 배열을 사용할 때 유용한 기능을 제공하는 클래스");

        //무작위로 저장된 데이터를 정렬하는 메서드 Sort
        int[] 알레이 = new int[5] { 3, 1, 2, 5, 4 };
        Array.Sort(알레이); //배열을 정렬하는 메서드 Sort
        foreach (var item in 알레이)
        {
            Console.WriteLine(item);
        }

        //배열을 거꾸로 역순으로 반환하는 메서드
        int[] 배열 = new int[3] { 1, 2, 3 };
        Array.Reverse(배열);
        foreach (var item in 배열)
        {
            Console.WriteLine(item);
        }

        //숫자 모양의 문자열 배열을 정수형 배열로 변경할 수 있는 메서드
        string[] 배열2 = new string[3] { "1", "2", "3" };
        Array.ConvertAll(배열2, int.Parse);
        foreach (var item in 배열2)
        {
            Console.WriteLine($"{item}, {item.GetType}");
        }

        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("17-2 Stack 클래스 - 음식을 담는 접시처럼 아래에서 위로 에디터를 쌓는 형태의 후입선출 구조");

        Stack 스택 = new Stack(); //Stack 클래스의 인스턴스 생성

        스택.Push("하나"); //Push = 스택에 데이터 저장
        스택.Push("둘");

        Console.WriteLine(스택.Pop()); //"둘" //Pop = 스택에서 데이터 꺼내기. 나중에 입력된 데이터가 먼저 출력됩니다.
        Console.WriteLine(스택.Pop()); //"하나" 


        try
        {
            Console.WriteLine(스택.Pop); //데이터가 전부 출력 됐으니 오류 발생
        }
        catch (Exception ex)
        {
            Console.WriteLine("스택이 없습니다.");
        }


        스택.Push("하나");
        스택.Push("둘");
        스택.Push("셋");


        //Peek 메서드는 데이터를 삭제하지 않고 가져오면서 스택 가장 위에 있는 데이터를 가져옴

        Console.WriteLine($"{스택.Peek()}, {스택.Count}"); //셋, 3
        Console.WriteLine($"{스택.Peek()}, {스택.Count}"); //셋, 3
        스택.Pop();
        Console.WriteLine($"{스택.Peek()}, {스택.Count}"); //둘, 2
        스택.Pop();
        Console.WriteLine($"{스택.Peek()}, {스택.Count}"); //하나, 1



        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("17-3 Queue 클래스 - Stack와 유사하지만 먼저 들어온 데이터가 먼저 나오는 선입선출 구조");
        
        Queue 큐 = new Queue(); //Queue 클래스의 인스턴스 생성

        큐.Enqueue(10); //Enqueue = 데이터를 입력
        큐.Enqueue(20);
        큐.Enqueue(30);
        Console.WriteLine(큐.Dequeue()); //10 //Dequeue = 데이터를 출력
        Console.WriteLine(큐.Dequeue()); //20
        Console.WriteLine(큐.Dequeue()); //30


        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("17-4 ArrayList 클래스 - 컬렉션 형태의 데이터를 저장하고 관리하는 여러 편리한 API를 제공");

        ArrayList 어레이 = new ArrayList(); //인스턴스 생성

        어레이.Add("C#"); //Object 형식
        어레이.Add("닷넷");

        for (int i = 0; i < 어레이.Count; i++)
        {
            Console.WriteLine($"{어레이[i].ToString()}");
        }


        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("17-4 Hashtable 클래스 - 정수 인덱스 및 문자열 인덱스를 사용할 수 있습니다.");

        Hashtable 해쉬테이블 = new Hashtable();

        해쉬테이블[0] = 123;
        해쉬테이블["이름"] = "카나시이";
        해쉬테이블["나이"] = 7;

        foreach (var item in 해쉬테이블.Keys)
        {
            Console.WriteLine(해쉬테이블[item]);
        }



    }
}
