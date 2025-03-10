using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec17_26_umer
{

    //Func is the modern method to implement delegate
    public static class Lec20_Func_Implementation
    {
        public delegate int MyDelegate(int a , int b);
        public static void f0() { return; }
        public static int f1() { return 0; }
        public static int f2(int a) { return 0; }
        public static int f3(int a, string b) { return 0; }
        public static void f4(int a , int b) { return; }
        //public static int CorrectAsPerFunc(int a , int b) { return 0; }
        public static int CorrectAsPerFunc(int a , int b) { return a+b; }

        public static void HowToUseFunc()
        {
            Func<int, int, int> func;
            //func = f0; //No overload for 'f0' matches delegate 'Func<int, int, int>'
            //...And so on list of errors

            //func = CorrectAsPerFunc;
            //Console.WriteLine( func.Invoke(1, 2));

            MyDelegate del =null;
            del = CorrectAsPerFunc;


            Console.WriteLine(del.Invoke(3, 6));
        }
    }
}
