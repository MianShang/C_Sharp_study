using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


///라이브러리에 있는 Framwork(Modulle)사용
///using + System + () 가 모여서 하나의 문장을 이룬다. 

///namespace project_1 은 하나의 프로젝트
namespace project_1
{
    ///class는 하나의 설계도
    class Program
    {
        ///var global = 52;
        ///main 전에 사용해서 전역변수 임으로 var사용이 불가능하다.
       
        static void Main(string[] args)
        {
            /*
                        ///주의할것 !!!출력은 Console.WriteLine이다.
                        ///using static System.Console로 Console 입력을 생략했다.

                        WriteLine("int = {0}",sizeof(int));
                        WriteLine("double = {0}",sizeof(double));
                        WriteLine("float = {0}",sizeof(float));
                        WriteLine("bool = {0}",sizeof(bool));
                        WriteLine("short = {0}",sizeof(short));
                        WriteLine("char = {0}",sizeof(char));

                        ///var 키워드 : 변수의 자료형을 자동으로 지정
                        ///var 키워드는 사용의 조건
                            ///① 지역 변수이어야 한다. -> 지역변수 : 메서드 내부에 선언되어 있는 변수
                            ///② 변수 선언과 동시에 초기화를 수행해야한다.

                                var number1 = 0; ///var자료형이 int자료형으로 읽힘.
                                var number2 = 100L; ///var자료형이 Long 자료형으로 읽힘 
                                var number3 = 100.13; ///var자료형이 double자료형으로 읽힘
                                var number4 = 100.13f; ///var자료형이 float자료형으로 읽힘

                        ///입력 문자열 string 자료형이다.
                            Console.ReadLine();

                        /// 문자열에서 + 는 문자열 연결 연산자이다.
                            string input1 = Console.ReadLine();
                            Console.WriteLine(input1+input1);

                        ///숫자와 문자열 덧셈
                            Console.WriteLine(52+273);
                        /// -> + 가 덧셈연산자로 읽혔다.
                            Console.WriteLine("52"+273); ///-> 52273 문자열 연결 연산자로 바뀌어서 연결되었다.
           

            ///자료형 변환
                ///① 강제 자료형 변환
                    var a1 = 10.5;
                    var a2 = (int)10.5;
                    Console.WriteLine(a1);
                    Console.WriteLine(a2);

            ///다른 자료형을 숫자로 변환
                ///② 문자열을 숫자로 변환
                    Console.WriteLine("52");
                    Console.WriteLine(int.Parse("52")); ///Parse -> 문장이있으면 분석하라는 뜻이다. 분석을해서 바꾸는 뜻 -> "parsse시켜주세요"
                    Console.WriteLine("'52' GetType() = "+("52").GetType());
                    Console.WriteLine("int.parse('52') GetType () = "+int.Parse("52").GetType());
                    Console.WriteLine("'52.273' GetType() = "+float.Parse("52.273"));
                    Console.WriteLine("float.parse('52.273') GetType () = " + float.Parse(("52.273")).GetType());

            ///③ 다른 자료형을 문자열로 변환
                ///기본 자료형을 문자열로 변환
                    Console.WriteLine((52.273).ToString());
                    Console.WriteLine('a' + 'b'); ///195
                    Console.WriteLine(('a').ToString()); /// char 문자는 문자열로 읽을 수 있다. char는 구조체 string 은 class이기 때문
*/

                Console.Write("인치를 입력하세요 : ");
                double inch = double.Parse(Console.ReadLine());
                Console.Write("입력한 "+inch+ "인치의 결과는 : ");
                inch *= 2.54;
                Console.WriteLine(inch + "cm 입니다.");







        }
    }
}
