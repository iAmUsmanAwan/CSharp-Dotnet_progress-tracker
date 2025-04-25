using System;
using System.Diagnostics;
using System.Threading;
using static System.Console;

namespace Lecture60
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var timer = Stopwatch.StartNew();

            WriteLine($"Main Thread ID - {Thread.CurrentThread.ManagedThreadId}"); // this is the main thread id

            //var TaskA = MethodA().Result;   // when we use .Result, we are blocking the main thread

            //WriteLine($"Task A: {TaskA}");  // when we use .Result, we use like this

            var TaskA = MethodA();
            var TaskB = MethodB();
            var TaskC = MethodC();
            
            WriteLine(await TaskA);   // now we have to make the main function async and of task type
            WriteLine(await TaskB);
            WriteLine(await TaskC);

            WriteLine($"Total time taken: {timer.ElapsedMilliseconds} ms");

        }


        static async Task<int> MethodA()   // to return an int we add int to the Task
        {
            WriteLine("Starting Method A");
            WriteLine($"Method A Thread ID - { Thread.CurrentThread.ManagedThreadId }");
            await Task.Delay(3000);   
            WriteLine("Method A - Ending");
            return 30;
        }
        static async Task<int> MethodB()
        {
            WriteLine("Starting Method B");
            WriteLine($"Method B Thread ID - {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(2000);
            WriteLine("Method B - Ending");
            return 20;
        }
        static async Task<int> MethodC()
        {
            WriteLine("Starting Method C");
            WriteLine($"Method C Thread ID - {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(1000);
            WriteLine("Method C - Ending");
            return 10;
        }


    }
}