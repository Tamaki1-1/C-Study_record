using System;


class int_

{
    static void Main(string[] args)
    {
        Console.WriteLine("3.숫자형 변수");
        Console.WriteLine("숫자를 담을 수 있는 변수. 실수형과 정수형이 있다.\n");

        Console.WriteLine("3-1 정수 데이터의 형식" +
                          "\n 부호가 있는 정수: sbyte, short, int, long" +
                          "\n 부호가 없는 정수: byte, ushort, uint, ulong" +
                          "\n 부호가 있는 정수는 접미사로 s, 없는 정수는 u를 사용한다.");


        int 최소 = -2147483648;
        int 최대 = +2147483647;
        Console.WriteLine("\n3-2 정수형 변수(int)의 크기"); //int 정수형 변수는 +21억 ~ -21억 까지 저장 가능하다.
        Console.WriteLine("int 변수의 최대값 : {0}",최대);
        Console.WriteLine("int 변수의 최소값 : {0}",최소);



        Console.WriteLine("\n3-3 부호가 있는 정수형 변수의 형식들");
        sbyte sbyte_ = 127;
        short short_ = 32767;
        int int__ = 2147483647;
        long long_ = 9223372036854775807;

        Console.WriteLine("sbyte의 최대값: {0}",sbyte_);
        Console.WriteLine("short의 최대값: {0}",short_);
        Console.WriteLine("int의 최대값: {0}",int__);
        Console.WriteLine("long의 최대값: {0}",long_);

        Console.WriteLine("\n3-4 부호가 없는 정수형 변수의 형식들(음수는 사용할 수 없지만, +값이 두배가 된다.");
        byte byte_ = 255;
        ushort ushort_ = 65535;
        uint uint_ = 4294967295;
        ulong ulong_ = 18446744073709551615;
        Console.WriteLine("byte의 최대값: {0}",byte_);
        Console.WriteLine("ushort의 최대값: {0}",ushort_);
        Console.WriteLine("uint의 최대값: {0}",uint_);
        Console.WriteLine("ulong의 최대값: {0}",ulong_);


        Console.WriteLine("\n3-5 실수형 데이터의 형식");
        Console.WriteLine("실수형 변수: float(32bit), double(64bit), decimal(128bit)");

        double PI = 3.141592;
        Console.WriteLine("double을 활용한 파이의 값: {0}", PI);
        float 플로트 = 99.87F;
        Console.WriteLine("float의 값: {0}",플로트);
        decimal decimal_ = 12.34M;
        Console.WriteLine("decimal의 값: {0}",decimal_);
        
        
    }


}
