using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.Collections.Generic;


//28. 속성
class 속성
{
static void Main(string[] args)
{
Console.WriteLine("28. 속성 사용하기");
Console.WriteLine("속성 - 단어 그대로 클래스 속성(특징, 성격, 색상, 크기 등)을 나타낸다.");
Console.WriteLine("괄호가 없는 메서드와 비슷하고 외부(public)에 공개 가능");

Console.WriteLine("★private 성격이 있는 필드를 public 속성으로 외부에 공개할 때 사용됨");
Console.WriteLine();


Console.WriteLine("자동 속성 - 한 줄로 속성을 정의하는 것");
자동속성 auto = new 자동속성(); //클래스의 인스턴스 생성
auto.속성예시 = "한 줄로 속성을 정의합니다"; //set
Console.WriteLine(auto.속성예시); //get //한 줄로 속성을 정의합니다


}
}
class 자동속성
{
public string 속성예시 { get; set; } //속성의 예시
//set(setter)세터 = 값을 설정하는 것
//get(getter)게터 = 값을 읽어오는 것

//자동 속성
}


//28-1 접근자와 전체 속성 - 특별한 계산식이 필요할 때 사용
//전체 속성 - 정의된 속성을 전체 속성이라고 한다.
//접근자 - get, set과 같이 접근할 수 있는 기능을 제공함

class 메인
{
static void Main(string[] args)
{
전체속성 속성 = new 전체속성(); //클래스의 인스턴스 생성
속성.Name = "전체 속성"; //get
Console.WriteLine(속성.Name); //set //전체 속성
}
}

class 전체속성
{
private string name;
public string Name
{
get { return name; } //get (필드의 값을 읽어 옴)
set { name = value; } //set (필드의 값을 저장)
}
}


//28-2 자동으로 구현된 속성

class 자동으로_구현된_속성
{
private string name;
public string Name //필드와 속성을 함께 사용하는 "전체 속성"
{
get
{
return name; //필드의 값을 외부로 공개
}

set
{
name = value; //외부에서 전달된 값을 필드에 초기화
}
}

//자동으로 구현된 속성
public string Color { get; set; } //자동으로 구현된 속성
public int Code { get; set; } //자동으로 구현된 속성2

}

class 메인
{
static void Main(string[] args)
{
//전체 속성
자동으로_구현된_속성 속성 = new 자동으로_구현된_속성(); //인스턴스 생성
속성.Name = "전체 속성"; //set //전체 속성
Console.WriteLine(속성.Name); //get


//자동으로 구현된 속성
자동으로_구현된_속성 자동구현속성 = new 자동으로_구현된_속성(); //인스턴스 생성
자동구현속성.Code = 1; //set
자동구현속성.Color = "자동구현 속성"; //set
Console.WriteLine($"{자동구현속성.Code} - {자동구현속성.Color}"); //get //1 - 자동구현 속성
}
}



//28-3 자동 속성 이니셜라이저
//속성을 선언과 동시에 기본값으로 초기화할 수 있음

class 이니셜라이저
{
public static string 이니셜 { get; set; } = "초기화"; //속성을 선언과 동시에 초기화



public static Guid Id { get; set; } = Guid.NewGuid(); //유일한 값을 생성하는 함수
public static string UserName { get; set; } = "타마키"; //유저의 이름

static void Main(string[] args)
{
Console.WriteLine(이니셜); //초기화
Console.WriteLine(이니셜라이저.이니셜); //초기화

Console.WriteLine($"{이니셜라이저.UserName}님의 시리얼코드: {이니셜라이저.Id}"); //타마키님의 시리얼코드: 77eb8dc6-53c8-483e-9c83-180d73dee7d8
}
}



//28-4 읽기 전용 속성(get)과 쓰기 전용 속성(set)
//private set 절을 사용해 설정(set)이 불가능한 읽기 전용 속성을 만들 수 있음

class 읽기전용
{
public string getだけ { get; private set; } = "읽기만 가능합니다.";
}
class 읽기_전용_속성
{

static void Main(string[] args)
{
읽기전용 읽기전용속성 = new 읽기전용(); //인스턴스 생성
Console.WriteLine(읽기전용속성.getだけ);

//<Error> 읽기전용속성.getだけ = "쓰기는 안돼?"; //에러 발생
}
}



//28-5 속성의 여러가지 유형 살펴보기

class 여러가지
{
private string Color; //필드


public 여러가지() //생성자로 필드 초기화
{
this.Color = "빨간색";
}

public string 메서드() //메서드로 필드 초기화
{
this.Color = "파란색";
string color = this.Color;
return this.Color;
}


public string 매개변수_메서드(string 색상) //매개변수 메서드로 필드 초기화
{
this.Color = 색상;
return this.Color;
}

public string 속성 //전체 속성으로 필드 초기화
{
get
{
return this.Color;
}

set
{
this.Color = value;
}
}

public string 읽기전용 //읽기 전용 속성
{
get
{
return this.Color;
}
}

public string 쓰기전용 //쓰기 전용 속성
{
set
{
this.Color = "분홍색";
}
}

public string 축약형속성 { get; set; } //축약형 속성 or 자동 속성

}

class 메인
{
static void Main(string[] args)
{
//1. 매개변수가 없는 메서드
여러가지 색깔 = new 여러가지(); //인스턴스 생성
Console.WriteLine(색깔.메서드()); //읽기 전용 속성과 흡사함

//2. 매개변수가 있는 메서드
여러가지 색깔2 = new 여러가지(); //인스턴스 생성
Console.WriteLine(색깔.매개변수_메서드("보라색")); //필드의 값을 초기화(set), 출력까지(get) 있음

//3. 전체 속성을 사용
여러가지 색깔3 = new 여러가지(); //인스턴스 생성
색깔.속성 = "하얀색"; //get
Console.WriteLine(색깔.속성); //set

//4. 읽기 전용 속성
여러가지 색깔4 = new 여러가지(); //인스턴스 생성
Console.WriteLine(색깔4.읽기전용); //빨간색 //읽기만 가능(get)

//5. 쓰기 전용 속성
여러가지 색깔5 = new 여러가지(); //인스턴스 생성
색깔5.쓰기전용 = "검은색"; //set //쓰기만 가능
//<Error> Console.WriteLine(색깔5.쓰기전용); //쓰기만 가능함

//6. 축약형 속성
여러가지 색깔6 = new 여러가지();
색깔6.축약형속성 = "분홍색";
Console.WriteLine(색깔6.축약형속성);


}
}


//28-6 속성을 사용한 클래스의 멤버 설정 및 참조하기
//cs파일이 3개 있음.

//ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
//첫번째 cs 파일: PropertyNote.Car.cs

using System;


namespace PropertyNote
{
public class Car
{
public static string Color; //public 필드로 속성처럼 사용

private static string Type;
public static string Type_ //public한 속정 정의
{
get
{
return Type;
}
set
{
Type = value;
}
}

public Car()
{
Color = "빨간색";
Type = "스포츠카";
}
}
}

//ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
//두번째 cs 파일: PropertyNote.Person.cs

using System;


namespace PropertyNote
{
public class Person
{
private int _BirthYear;
public string Name { get; set; }

public int BirthYear //쓰기 전용 속성: 전체 속성으로 계산식 사용
{
set
{
if (value >= 1900)
{
_BirthYear = value;
}
else
{
_BirthYear = 0;
}
}
}

public int Age //읽기 전용 속성
{
get
{
return (DateTime.Now.Year - _BirthYear);
}
}

public Person(string name) //매개변수가 있는 생성자
{
this.Name = name; //Name 속성에 넘겨준 name 매개변수 값 저장
}
}
}

//ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
//세번째 cs 파일: Program.cs

using System;


namespace PropertyNote
{
class PropertyNote
{
static void Main(string[] args)
{
Car.Color = "빨간색"; //필드(public 사용)
Car.Type_ = "세단"; //속성 사용
Console.WriteLine($"{Car.Color} {Car.Type_}"); //빨간색 세단

// Person 클래스(인스턴스) 사용
Person person = new Person("타마키"); //생성자로 이름 초기화
person.BirthYear = (DateTime.Now.Year - 21); //21살로 고정 ////2024 - 2003 = 21
Console.WriteLine($"이름: {person.Name}, 나이: {person.Age}");
}
}
}
//ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

//28-7 화살표 연산자로 속성과 메서드를 줄여서 표현하기

class Counter
{
private int 카운트; //필드

public int 카운트_
{
get => 카운트; //읽기
set => 카운트 = value; //쓰기
}

public void 카운팅시스템() => 카운트_++; //카운트 시스템
}

class 메인
{
static Counter counter; //정적 필드
static void Main(string[] args)
{

counter = new Counter(); //인스턴스 생성
counter.카운팅시스템(); //카운트
Console.WriteLine(counter.카운트_); //1
counter.카운팅시스템();
Console.WriteLine(counter.카운트_); //2


Counter counter1 = new Counter(); //인스턴스 생성
counter1.카운팅시스템();
Console.WriteLine(counter1.카운트_); //1
counter1.카운팅시스템();
Console.WriteLine(counter1.카운트_); //2
}
}


//28-8 게터와 세터에 화살표 연산자 사용

class 게터와세터
{
public string 이름_ { get; set; }
public DateTime 탄생일 { get; set; }
public int 나이 //읽기 전용 속성 : 계산식 전체 속성
{
get => (DateTime.Now - 탄생일).Days / 365 + 1;
}

static void Main(string[] args)
{
게터와세터 게터 = new 게터와세터();
게터.이름_ = "마이크로소프트"; //이름_ 속성 set
게터.탄생일 = new DateTime(1975, 01, 01); //탄생일 속성 set

Console.WriteLine($"이름: {게터.이름_}\n나이: {게터.나이}");

//이름: 마이크로소프트
//나이: 50

}
}


//28-9 개체 이니셜라이저 (개체 = 인스턴스)

class 개체_이니셜라이저
{
public int _id { get; set; }
public string _name { get; set; }

static void Main(string[] args)
{
//1. 속성을 사용하여 개체 초기화
개체_이니셜라이저 이니셜 = new 개체_이니셜라이저();
이니셜._id = 1; 이니셜._name = "C#";
Console.WriteLine($"{이니셜._id} - {이니셜._name}"); //1 - C#


//2. 개체 이니셜라이저를 사용하여 개체 초기화
개체_이니셜라이저 개체 = new 개체_이니셜라이저() { _id = 2, _name = "ASP.NET" };
Console.WriteLine($"{개체._id} - {개체._name}"); //2 - ASP.NET

}
}


//28-10 개체로 초기화하는 세가지 방법

class 세가지
{
public int _Id { get; set; }
public string _Name { get; set; }

public 세가지()
{
_Id = 2;
_Name = "매개변수가 없는 생성자로 초기화";
}

public 세가지(int id, string name)
{
_Id = id;
_Name = name;
}
}

class 메인
{
static void Main(string[] args)
{
//1. 개체로 초기화
세가지 속성 = new 세가지(); //개체(인스턴스) 생성
속성._Id = 1; 
속성._Name = "개체로 초기화";
Console.WriteLine($"{속성._Id} - {속성._Name}"); //1 - 개체로 초기화


//2. 생성자로 초기화

//매개변수가 없는 생성자로 초기화
세가지 생성자 = new 세가지();
Console.WriteLine($"{생성자._Id} - {생성자._Name}"); //2 - 매개변수가 없는 생성자로 초기화

//매개변수가 있는 생성자로 초기화
세가지 매개변수_생성자 = new 세가지(3, "매개변수가 있는 생성자로 초기화");
Console.WriteLine($"{매개변수_생성자._Id} - {매개변수_생성자._Name}"); //3 - 매개변수가 있는 생성자로 초기화


//3. 개체 이니셜라이저를 사용해서 초기화
세가지 개체 = new 세가지() { _Id = 4, _Name = "개체 이니셜라이저를 활용해 초기화" };
Console.WriteLine($"{개체._Id} - {개체._Name}"); //4 - 개체 이니셜라이저를 활용해 초기화
}
}


//28-11 속성 이름과 메서드 이름을 nameof 연산자로 가져오기

class Car
{

//속성
public int _색상 { get; set; }
public string _차종 { get; set; }

//메서드
public void 메서드()
{
Console.WriteLine("안녕하세요");
}
}

class 메인
{
static void Main(string[] args)
{
//속성의 이름 출력
Car car = new Car();
Console.WriteLine($"속성 이름: {nameof(car._색상)}, {nameof(car._차종)}"); //속성 이름: _색상, _차종

//메서드의 이름 출력
Console.WriteLine(nameof(car.메서드)); //메서드

}
}


//28-12 익명 형식(무명 형식) - 특정 클래스로 형식을 만들 필요 없이 간단히 속성을 생성함

class 메인
{
static void Main(string[] args)
{
var person = new { id = 1, name = "타마키" }; //new 키워드 뒤에는 var의 타입 추론을 이용하여 자동으로 형식을 결정
Console.WriteLine($"{person.id} - {person.name}"); // 1 - 타마키


//익명 형식은 배열 형식으로도 사용가능
var info = new[]
{
new {name = "타마키", age = 24}, //참고로 전부 속성 형식임
new {name = "; _ ;..", age = 7}
};
Console.WriteLine($"{info[0].name}의 나이: {info[0].age}"); //타마키의 나이: 24
Console.WriteLine($"{info[1].name}의 나이: {info[1].age}"); //; _ ;..의 나이: 7
}
}



//28-13 익명 형식과 덕 타이핑(duck typing)

class 메인
{
static void Main(string[] args)
{
//1. 익명 형식으로 속성 만들기
var duck = new { id = 1, name = "오리" };
Console.WriteLine($"{duck.id}, {duck.name}"); //1, 오리


//2. 또 다른 익명 형식을 대입
duck = new { id = 2, name = "오리 2" };
Console.WriteLine($"{duck.id}, {duck.name}"); //2, 오리 2


//3. 처음에 선언한 형태가 아닌 id에 실수형 데이터 넣어보기
//<Error> duck = new { id = 3.23, name = "오리 3" };  //처음 선언된 duck 개체와 달라서 오류 발생


//4. Name 속성을 제외한 채 개체를 할당해 보기
//<Error> duck = new { id = 4 }; //처음과 "개체"가 달라서 예외 발생


//5. 처음에 없던 Email 속성 추가해서 할당해보기
//<Error> duck = new { id = 5, name = "오리 5", email = "tamaki3131@naver.com"}; //속성을 추가해도 에러 발생


//6. 처음에 선언할 때 동알한 개체 형태로 값을 할당하면 정상적으로 할당됨
duck = new { id = 6, name = "오리 6" };
Console.WriteLine($"{duck.id}, {duck.name}"); //6, 오리 6
}
}


//28-14 생성자로 속성에 대한 유효성 검사 구현하기

class Car
{
public string _이름 { get; private set; } //읽기 전용 속성(외부에서 초기화 불가)
public Car(string 이름) //매개변수가 있는 생성자
{
if (string.IsNullOrEmpty(이름))
{
//빈 값이면 강제로 예외 발생
throw new ArgumentException(); //throw = 강제 예외 발생 구문
}
this._이름 = 이름; //유효성 검사가 완료되면 값 대입
}

static void Main(string[] args)
{
Car car = new Car("에에");
Console.WriteLine(car._이름); //속성 반환

Car car1 = new Car("");
Console.WriteLine(car1._이름); //에러 발생Unhandled exception. System.ArgumentException: Value does not fall within the expected range.

}
}


//28-15 메서드로 속성 값 초기화하기
//summary는 XML 읽기전용으로 아래 문장에 설명문을 추가한다.

///<summary>
///애완동물
///</summary>
class 펫
{
    ///<summary>몸무게</summary>
    public int 몸무게 { get; set; }

    ///<summary>먹이를 주면 몸무게 증가</summary>
    public void 먹이(int 먹이)
    {
        this.몸무게 += 먹이;
    }


    //펫의 크기
    public int X { get; set; } = 50;
    public int Y { get; set; } = 200;


    public void 크기()
    {
        Console.WriteLine($"X: {this.X}, Y: {this.Y}"); //펫의 크기 출력 메서드
    }
}

class 메인
{
    static void Main(string[] args)
    {
        펫 pet = new 펫();
        pet.몸무게 = 50; //몸무게 속성 get
        Console.WriteLine($"펫의 기본 몸무게: {pet.몸무게}"); //펫의 기본 몸무게: 50

        pet.먹이(10); //먹이 10만큼 주기
        Console.WriteLine($"펫의 현재 몸무게: {pet.몸무게}"); //펫의 현재 몸무게: 60
        pet.먹이(50); //먹이 50만큼 주기
        Console.WriteLine($"펫의 현재 몸무게: {pet.몸무게}"); //펫의 현재 몸무게: 110


        //크기 출력
        Console.Write("펫의 크기: "); // 펫의 크기: X: 50, Y: 200
        (new 펫()).크기(); //인스턴스 생성 안하고 출력하는 문장

        Console.Write("펫의 크기: "); // 펫의 크기: X: 50, Y: 200
        pet.크기(); //생성된 인스턴스로 출력
    }
}



//28-16 속성에서 ?.와 ?? 연산자를 함께 사용하기
// ?. 연산자 = null이면 체이닝하지 않음
// ?? 연산자 = 해당 값이 있으면 있는 값 출력, 값이 있다면 오른쪽 항 출력


class 모델_클래스
{
    public string _이름 { get; set; }
    public string _의미 { get; set; }
}

class 빈값탐색
{

    
    static void Main(string[] args)
    {
        모델_클래스 정보 = new 모델_클래스();
        정보._이름 = "카나시이";
        정보._의미 = "슬프다";

        모델_클래스 정보2 = new 모델_클래스();
        

        Console.WriteLine($"{정보?._이름 ?? "Error"}은(는) 한국어로 {정보?._의미 ?? "Error"}입니다."); //카나시이은(는) 한국어로 슬프다입니다.

        Console.WriteLine($"{정보2?._이름 ?? "Error"}은(는) 한국어로 {정보2?._의미 ?? "Error"}입니다."); //Error은(는) 한국어로 Error입니다.


    }
}


