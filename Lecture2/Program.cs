using System;

namespace Lecture2
{
    class Program
    {
        static void Main(string[] args)
        {

// TODO: Data Types:

            string myFirstVariable = "String any!";

            char letter = 'A';  // char for single characters , uses 2 bytes
            
            int number = -20;  // signed int for negative and positive numbers , uses 4 bytes
            uint number2 = 10;  // unsigned int only for positive numbers , uses 4 bytes
            
            float number3 = 10.5f;  // float for decimal numbers , uses 4 bytes
            double number4 = 10.5;  // double for decimal numbers , uses 8 bytes
            decimal number5 = 10.5m;  // decimal for decimal numbers , uses 16 bytes

            bool happy = true;  // bool for true or false , uses 1 byte
            bool sad = false;

            int thisCannotBeNull = 10;
            // thisCannotBeNull = null;  // Error: Cannot convert null to 'int' because it is a non-nullable value type   
            
            //! Nullable types:
            int? thisCanBeNull = null;  // if we want to assign null to a value type as a default, we can use nullable types
            Console.WriteLine(thisCanBeNull);  // space is printed, for null values
            Console.WriteLine(thisCanBeNull.GetValueOrDefault());  // 0 is printed, for null values, as default value of null int is 0
            
            thisCanBeNull = 20;
            Console.WriteLine(thisCanBeNull);  // 20
            Console.WriteLine(thisCanBeNull.GetValueOrDefault());  //  20


            Console.WriteLine(myFirstVariable);
            
            Console.WriteLine("int uses " + sizeof(int) + " bytes");
            Console.WriteLine("uint uses " + sizeof(uint) + " bytes");

            Console.WriteLine("float uses " + sizeof(float) + " bytes");
            Console.WriteLine("double uses " + sizeof(double) + " bytes");
            Console.WriteLine("decimal uses " + sizeof(decimal) + " bytes");

            Console.WriteLine("char uses " + sizeof(char) + " bytes");

// TODO:  Interpolated string:

            Console.WriteLine($"int min value: {int.MinValue} , int max value: {int.MaxValue}");    //* int min value: -2147483648 , int max value: 2147483647

            Console.WriteLine($"uint min value: {uint.MinValue} , uint max value: {uint.MaxValue}");    //* uint min value: 0 , uint max value: 4294967295

            Console.WriteLine($"float min value: {float.MinValue} , float max value: {float.MaxValue}");    //* float min value: -3.4028235E+38 , float max value: 3.4028235E+38

            Console.WriteLine($"double min value: {double.MinValue} , double max value: {double.MaxValue}");    //* double min value: -1.7976931348623157E+308 , double max value: 1.7976931348623157E+308

            Console.WriteLine($"decimal min value: {decimal.MinValue} , decimal max value: {decimal.MaxValue}");    //* decimal min value: -79228162514264337593543950335 , decimal max value: 79228162514264337593543950335
            

// TODO: Double and Decimal comparison:

            Console.WriteLine("Using Doubles:");
            double a = 0.1;
            double b = 0.2;
            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does not equal 0.3");
            }
            // 0.1 + 0.2 does not equal 0.3
            

            Console.WriteLine("Using decimals:");
            decimal aa = 0.1m;
            decimal bb = 0.2m;
            if (aa + bb == 0.3m)
            {
                Console.WriteLine($"{aa} + {bb} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{aa} + {bb} does not equal 0.3");
            }
            // 0.1 + 0.2 equals 0.3, used when accuracy is important

        }
    }
}