using System;
using System.Collections;

namespace Lecture26
{
    class MyEventArgs : EventArgs
    {
        public int Count { get; set; }

    }

    delegate void MyEventHandler(object sender, MyEventArgs e);   // to keep track of the publisher, MyEventArgs holds the information about the event
    //delegate void MyEventHandler();

    //publisher
    class MyArrayList : ArrayList    // ArrayList is a generic class
    {
        public event MyEventHandler Added;   // define the event 
        MyEventArgs e = new MyEventArgs();    // we can also create this in the OnAdded function but it is better to create it here
        public MyArrayList()
        {

            e.Count = 0;
        }
        void OnAdded()   // by default private function  {firing the event}
        {
            if (Added != null)
            {
                e.Count = e.Count + 1;   // change the count everytime the event is fired
                Added(this, e);    // we added this to keep track of the publisher,  and e to keep track of the event
            }
        }
        public override int Add(object value)   // overriding the Add method of ArrayList
        {
            OnAdded();   // to fire the event
            return base.Add(value);
        }
    }
    //subscriber
    class Program
    {
        static void MyHandler(object sender, MyEventArgs e)   // here we have to provide the same signature as the delegate
        {
            Console.WriteLine($"object added by {sender.ToString()} and count : {e.Count}");
        }
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();   // creating object of MyArrayList
            //list.Added += () => Console.WriteLine("Object Added");   // register an action against event Added
            list.Added += MyHandler;    // register an action against event Added
            list.Add(1);
            list.Add("1");
            list.Add("1234");

        }
    }
}