using EMS_BLL;
using EMS_BO;
using EMS_View;
using System;

namespace EMS_ConsoleApplication
{
    delegate void Delegate1();
    delegate void Delegate2(string s);
    delegate string Delegate3(string s);

    delegate int MathOp(int a, int b);


    internal class Program
    {
        static int PerformOperation(MathOp op, int a, int b) 
        {
            return op(a, b) ;
        }

        static void Display()
        {
            Console.WriteLine("Display function displaying");
        }


        static void Display2(string s)
        {
            Console.WriteLine(s);
        }

        static string Display3(string s)
        {
            Console.WriteLine(s);
            return s;
        }

        static void Display4()
        {
            Console.WriteLine("hello from display4");
        }



        static void Main(string[] args)
        {
            Console.WriteLine(PerformOperation(Calculator.add, 4, 5));    // here we have passed a reference of a function as a parameter to another function
            Console.WriteLine(PerformOperation(Calculator.Subtract, 10, 5));



            //Delegate1 d1 = new Delegate1(Display);  // we can decide which display function should be invoked on runtime with delegetes eg ( Display or Display4 )

            Console.WriteLine("Enter 0 to run function1 or 1 to run function4 ");
            string input = Console.ReadLine();
            int i = System.Convert.ToInt32(input);

            Delegate1 d1 = null;   // Delegate is a type that holds a reference to a method 

            if (i==0)
            {
                d1 = Display;
            }
            else
            {
                d1 = Display4;
            }

            d1.Invoke();
            d1();   // same as above

            //Delegate2 d2 = new Delegate2(Display2);  // one way
            Delegate2 d2 = Display2;
            d2("Delegate 2 displaying");

            Delegate3 d3 = Display3;
            string s = d3("text shown by Delegate3");


                    
            
            //Console.WriteLine("--Welcome to Employee Management System!--");

            //EmployeeView view = new EmployeeView();
            
            //view.GetInput();

            //view.Display();


        }
    }
}
