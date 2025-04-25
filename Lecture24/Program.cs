﻿using System;
using System.Data;

namespace Lecture24
{
    delegate void MyEventHandler();

    //publisher
    internal class MyButton
    {

        public event MyEventHandler click;    // define an event

        public void OnClick()
        {

            //click.Invoke();
            click();
        }

    }

    internal class MySubscriber
    {


        static public void HandleEvent()
        {

            Console.WriteLine("Click event occured.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyButton button = new MyButton();
            button.click += MySubscriber.HandleEvent;   // after click event, HandleEvent will be called

            button.click += delegate ()    /// anonymous method
            {
                Console.WriteLine("click event second handler");
            };

            button.OnClick();
        }
    }
}