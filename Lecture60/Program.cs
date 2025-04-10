using System;
using System.Diagnostics;
using System.Threading;
using static System.Console;

namespace Lecture60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();

            var TaskA = MethodA();
            var TaskB = MethodB();
            var TaskC = MethodC();

            Task[] tasks = { TaskA, TaskB, TaskC };
            Task.WaitAll(tasks); // Wait for all tasks to complete

            WriteLine($"Total time taken: {timer.ElapsedMilliseconds} ms");

        }


        static async Task MethodA()   // to make a method async, we need to add the async keyword and Task return type
        {
            WriteLine("Starting Method A");
            //Thread.Sleep(3000);     // Synchronous
            await Task.Delay(3000);   // Asynchronous
            WriteLine("Method A - Ending");
        }
        static async Task MethodB()
        {
            WriteLine("Starting Method B");
            await Task.Delay(2000);
            WriteLine("Method B - Ending");
        }
        static async Task MethodC()
        {
            WriteLine("Starting Method C");
            await Task.Delay(1000);
            WriteLine("Method C - Ending");
        }


    }
}
