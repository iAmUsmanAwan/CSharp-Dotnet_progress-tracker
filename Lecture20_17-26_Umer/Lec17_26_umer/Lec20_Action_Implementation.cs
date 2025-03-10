using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Lec17_26_umer
{

    //Built-in delegate that can store methods which return void.
    //Why? → Use when no return value is needed.
    public static class Lec20_Action_Implementation
    {
        public static void HowToUseAction()
        {
            //Action<string> print = msg => Console.WriteLine(msg);
            //print("Hello, Action!");  // Output: Hello, Action!

            Action<string, int, bool> print = (msg, k, c) =>
            {
                Console.WriteLine(k);
                Console.WriteLine(c);
                Console.WriteLine(msg);


                //Bas aik kaam nahi kar sktay idhr Action me 
                //return something;
                // BSDK abhi kaha hai return nahi kr sktay aur yehi main diff hai iska (FUNC) sa

            };
            print("Hello, Action!",99,true);  // Output: Hello, Action!



            return;
        }
    }
}
