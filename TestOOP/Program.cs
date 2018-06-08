using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    class M
    {
        public  void A()
        {
            Console.Write("M-A ");
        }

        virtual public void B()
        {
            Console.Write("M-B ");
        }
        public  void    C()
        {
            Console.Write("M-C ");
        }
    }

    class N : M
    {
        public void A()
        {
            Console.Write("N-A ");
        }

        public override void B()
        {
            Console.Write("N-B ");
        }
        
        public  void    C()
        {
            Console.Write("N-C ");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            M m = new M();
            N n = new N();
            M mn = new N();

            m.A();
            n.C();
            mn.C();
            mn.B();
            Console.ReadKey();
        }
    }
}
