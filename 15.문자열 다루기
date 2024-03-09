using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

class 문자열_다루기
{
    static void Main(string[] args)
    {
        Console.WriteLine("15.문자열 관련 주요 속성 및 메서드");
        string 문자열 = "   Hello World!   ";

        Console.WriteLine(문자열.Length); //문자열의 길이 값 출력
        Console.WriteLine(문자열.ToUpper()); //전부 대문자로 변환
        Console.WriteLine(문자열.ToLower()); //전부 소문자로 변환
        Console.WriteLine(문자열.Trim());  //양옆의 공백을 제거
        Console.WriteLine(문자열.Replace("Hello", "안녕"));  //원본 문자열을 대상 문자열로 변경
        Console.WriteLine(문자열.Substring(8)); //지정된 문자열 인덱스부터 길이만큼 반환

        Console.WriteLine("메서드 체이닝 - 문자열 클래스는 여러 번 (.)을 찍어 구분하면서 호출 할 수 있음");
        Console.WriteLine(" Hello World".Trim().Replace("world","세계").Length); // ; _ ;....



        Console.WriteLine("String 클래스에 문자 배열을 전달하면 문자열로 변환 할 수 있음");
        char[] 알파벳 = new char[3] { 'A', 'B', 'C' };
        String 클래스 = new String(알파벳);
        Console.WriteLine(클래스);


        Console.WriteLine("String.Concat()메서드를 사용하여 문자열 연결하기");
        string 콘캣 = String.Concat("안녕", "하세요");
        Console.WriteLine(콘캣);



        Console.WriteLine("문자열을 비교하는 두 가지 방법 정리하기");

        string 비교1 = "HELLO";
        string 비교2 = "hello";

        if (비교1.ToLower() == 비교2.ToLower()) //둘다 소문자로 변환해서 비교해 같은지 확인
        {
            Console.WriteLine("같습니다."); //실행
        }
        if (String.Equals(비교1,비교2,StringComparison.InvariantCultureIgnoreCase)) //Equals는 두 값을 비교하는 메서드. 뒤에 딸려 있는 열거형 때문에 구별하지 않는다.
        {
            Console.WriteLine("같습니다."); //실행
        }



        Console.WriteLine("ToCharArray() 메서드로 문자열을 문자 배열로 변환하기");
        string 문자열1 = "Hello.";
        char[] 배열 = 문자열1.ToCharArray();
        foreach (var 배열열 in 배열)
        {
            Console.WriteLine(배열열);
        }



        Console.WriteLine("Split() 메서드로 문자열 분리하기");
        string 분리 = "빨강, 파랑, 노랑";
        string[] 색상 = 분리.Split(','); // (,)기호로 구분하여 배열 생성
        foreach (var 카나 in 색상)
        {
            Console.WriteLine(카나);
        }


        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("15-1 문자열 처리 관련 주요 API 살펴보기");

        Console.WriteLine("문자열 변수는 초기화하지 않으면 기본적으로 null 값으로 초기화합니다.");
        string 예시 = ""; //빈 문자
        string 예시2 = String.Empty; //빈 문자 메서드
        Console.WriteLine($"{예시},{예시2}");

        string 예시3 = " ABc DeF FEd cbA ";
        Console.WriteLine(예시3.Length);



        //Trim 메서드로 양쪽 공백 제거
        Console.WriteLine(예시3.Trim());//양쪽 부분의 공백 제거
        Console.WriteLine(예시3.TrimStart());// 시작 부분의 공백 제거



        //Index() 메서드 - 문자열의 앞이나 뒷부분부터 검색을 시작하여 지정된 문자의 위치(인덱스)를 알려주는 메서드
        Console.WriteLine(예시3.IndexOf('c')); // ABc 즉 3
        Console.WriteLine(예시3.LastIndexOf('c')); // ABc DeF FEd cbA. 역순이니 즉 13 

        //Substring() 메서드 - 문자열을 특정 인덱스 이후부터 출력하게 할수 있음
        Console.WriteLine(예시3.Substring(5,3)); //DeF
        Console.WriteLine(예시3.Substring(9)); //FEd cbA

        //Remove() 지정한 위치의 문자 또는 문자열을 제거하여 출력
        Console.WriteLine(예시3.Remove(0,5)); // " ABc " 는 제거되서 "DeF FEd cbA"만 출력함

        //String.Format() 메서드로 통화량 또는 세 자리마다 콤마를 찍어보기
        Console.WriteLine(String.Format("{0:C}", 1000)); //\1,000
        Console.WriteLine(String.Format("{0:#,###}", 1000000)); //1,000,000

        //Split() 메서드로 구분자를 통해 문자열에서 배열 뽑아내기
        string[] 스플릿배열 = 예시3.Trim().Split(' '); //예시3 변수에, 양쪽 공백 제거, ' ' 구분자로 구분해 배열 생성
        foreach (var 타노 in 스플릿배열)
        {
            Console.WriteLine(타노);
        }

        //Insert() 메서드로 문자열을 삽입하거나, Remove() 메서드로 제거 할 수 있다.
        string 인사1 = "안녕";
        string 인사_1 = 인사1.Insert(2, "하세요."); //2칸 이후에 "하세요." 삽입
        Console.WriteLine(인사_1);
        string 인사_2 = 인사_1.Remove(2); //2칸 이후에 모두 제거
        Console.WriteLine(인사_2);

        //PadLeft()와 PadRight()를 사용하여 특정 문자를 왼쪽 또는 오른쪽에 채울 수 있다.
        string 패드 = "자고싶다";
        string 패드_1 = 패드.PadLeft(10, '아'); //자고싶다를 포함해 왼쪽에 아로 채워 10칸의 문자열로 만듬 "아아아아아아자고싶다"
        Console.WriteLine(패드_1);
        string 패드_2 = 패드.PadRight(10, '아'); //자고싶다를 포함해 오른쪽에 아로 채워 10칸의 문자열로 만듬 "자고싶다아아아아아아"
        Console.WriteLine(패드_2);

        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("15-2 StringBuilder 클래스를 사용하여 문자열 연결하기");
        Console.WriteLine("-인스턴스 멤버이기에 인스턴스인 개체를 선언해야 호출 할 수 있다.");
        StringBuilder 빌더 = new StringBuilder(); //인스턴스 선언
        빌더.Append("안녕"); //Append 은 Write처럼 문자열을 담는 역할을 한다.
        빌더.Append("하세요");
        빌더.AppendLine("; _ ;..."); //AppendLine은 writeline처럼 문자열 끝에 /r/n을 추가한다.
        빌더.Append("ああああああああああ");
        Console.WriteLine(빌더);

        //메서드 체이닝으로 StrinBuilder 클래스의 여러 메서드를 호출하기
        StringBuilder 빌더2 = new StringBuilder();
        빌더2.Append("안녕").Append("하신가요").Append("??");
        Console.WriteLine(빌더2);

        //StringBuilder 클래스의 여러 메서드를 함께 사용해보기

        StringBuilder 빌더3 = new StringBuilder();
        빌더3.Append("<스크립트>");
        빌더3.AppendFormat("window.alert({0})", DateTime.Now.Year);
        빌더3.Append("<스크립트>");
        Console.WriteLine(빌더3);

        //String과 Stringbuilder의 성능 차이 비교하기

        DateTime 시작 = DateTime.Now;
        String 스트링 = null;

        for (int i = 0; i < 10000; i++)
        {
            스트링 += "안녕하세요!!!!!";
        }
        DateTime 종료 = DateTime.Now;
        double 시간차 = (종료 - 시작).TotalMilliseconds;
        Console.WriteLine(시간차); //50.1078



        StringBuilder 스트링빌더 = new StringBuilder();
        DateTime 시작2 = DateTime.Now;

        for (int j = 0; j < 10000; j++)
        {
            스트링빌더.Append("안녕하세요!!!!!");
        }

        DateTime 종료2 = DateTime.Now;
        double 시간차2 = (종료2 - 시작2).TotalMilliseconds;
        Console.WriteLine(시간차2); //0.0677

    }
    


}
