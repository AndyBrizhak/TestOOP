using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestDelegate
{
    delegate int P(string s);

    class Program
    {


        void M(string s)
        {

        }

        static void Main(string[] args)
        {
            // 1 вариант
            //string s;
            //M((s) => { Console.WriteLine(s); return 0; }, "prog-school.ru");

            //2
            int A(string str) { Console.WriteLine(str); return str.Length; }
            M(A, "GeekBrains.ru");

            //3
            //M(delegate (string s) { Console.WriteLine(s); return 0; }, "GeekBrains.ru");

            //4
            //M((string)=>{ Console.WriteLine(string); return 0; },"GeekBrains.ru");

            //5

            //Func D = new Func(A);
            //M(D, "GeekBrains");
        }

        int A(string str) { Console.WriteLine(str); return str.Length; }
        //void M(P, string str )
        //{

        //}


    }
}
