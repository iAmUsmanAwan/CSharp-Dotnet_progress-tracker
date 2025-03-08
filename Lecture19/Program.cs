using System;

namespace Lecture19
{
    delegate int MathOperation(int x, int y);
    //delegate void SomeotherMathOperation(int x, int y);
    delegate void MyDelegate();


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Example");

            MathOperation op = Calculator.Add;

            //'int Calculator.Add(int, int)' has the wrong return type
            //SomeotherMathOperation opwqreqwr = Calculator.Add;
            
            //int result = op(6, 5);
            //Console.WriteLine($"Result : {result}");

            op += Calculator.Subtract;  // now refering to subtract also
            op += Calculator.Multiply;  // now refering to multiply also

            int result = op(2, 3);
            Console.WriteLine(result);  // here the value recieved by the last function will be stored  (for void function no value will be returned, so no value will be stored)

            op -= Calculator.Subtract;  // now derefering the Subtract funtion 
            result = op(3, 10);
            Console.WriteLine(result);


            Console.WriteLine("Annonymous Methods Example");   // these will be used only at a particular area (we can add but cannot remove methods because they are anonymous)

            MathOperation op2 = delegate (int x, int y)
            {
                Console.WriteLine("Add");
                return x + y; 
            };
            Console.WriteLine(op2(2, 3));

            op2 += delegate (int x, int y)
            {
                Console.WriteLine("Subtract");
                return x - y;
            };
            Console.WriteLine(op2(5, 3));


            MyDelegate d1 = delegate ()
            {
                Console.WriteLine("i am in anonymous method");
            };
            d1();


            Console.WriteLine("Lambda Statement Example");

            op2 += ( x,  y)  =>   // we can also choose not to mention type , as it will get it from MathOperation delegate
             {
                Console.WriteLine($"Showing by Lambda statement {x} , {y}");
                 return x+y;
            };

            // Lambda Expression   (one line code only)
            op2 += (x, y) =>  x * y;   // last function of delegate which will store value 
                                       // no matter how many function are there and how many values they return, the main function or the point from where the delegate is invoked or called will recieve only last value 

            Console.WriteLine(op2(5, 9));


        }
    }
}
