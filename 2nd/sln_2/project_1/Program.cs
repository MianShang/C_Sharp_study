using System;
using static System.Console; /// Console.WriteLine -> WriteLine으로 줄일 수 있음
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// † namespace 영역

namespace project_1 ///프로젝트 이름 어떤 프로젝트를 시작할때 namespace가 있어야한다.
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(275); ///Console.WriteLine 줄바꿈 출력문
                            ///Console.Write 줄안바꾸고 그대로 출력
            Console.WriteLine('A');
            Console.WriteLine("Program");
        }
    }
}
