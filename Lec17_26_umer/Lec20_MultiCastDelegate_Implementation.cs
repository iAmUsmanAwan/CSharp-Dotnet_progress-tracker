using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lec17_26_umer
{

    //Multicast Delegate(Multiple Methods in One Delegate)
    //A delegate that holds multiple methods.
    //🔹 Why ? → Useful for event handling where multiple methods need to run.
    public static class Lec20_MultiCastDelegate_Implementation
    {
        public static void FirstMethod() => Console.WriteLine("First");
        public static void SecondMethod() => Console.WriteLine("Second");
        public static void HowToUseMultiCastDel()
        {
            Action multi = FirstMethod;
            multi += SecondMethod;  // Adding another method
            multi();  // Calls both methods in order
            multi.Invoke(); //Another way to call the delegates
        }
    }
}



