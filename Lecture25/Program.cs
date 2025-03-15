using System;

namespace Lecture25
{
    delegate void PublishMessageDel(string msg);    // delegate named PublishMessageDel, which represents a method that takes a string as input and has a void return type. It acts like a function pointer, allowing us to store and call methods dynamically.

    class Publisher     /// acts as the event generator.
    {

        //public PublishMessageDel publishMessageObj = null;

        public event PublishMessageDel publishevent = null;    // event named publishevent, which is of type PublishMessageDel. This event is used to notify subscribers when a message is published. event is a special type of delegate that only allows subscribers to add/remove methods, preventing direct assignment from outside the class.

        public void PublishMessage(string msg)
        {

            publishevent?.Invoke(msg);    ///  triggering all subscribed methods. If no method is subscribed, Invoke() will cause a NullReferenceException, so it's better to check for null before invoking.   as Null-safe invocation "?."
        }
    }
    //subscribers
    class SendViaEmailSubscriber
    {

        public void Subscribe(Publisher p)     // Subscribe(Publisher p) attaches the SendMessage method to publishevent using +=.
        {

            p.publishevent += SendMessage;
        }
        private void SendMessage(string msg)     // SendMessage prints the received message as an email notification.
        {

            Console.WriteLine($"Send to Email {msg}");
        }


    }

    class SendViaMobileSubscriber     // Similar to SendViaEmailSubscriber, but for mobile notifications.
    {

        public void Subscribe(Publisher p)     
        {
            p.publishevent += SendMessage;


        }
        private void SendMessage(string msg)   
        {
            Console.WriteLine($"Send to Mobile {msg}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisherObj = new Publisher();
            
            /// Creates subscriber objects for email and mobile.
            SendViaEmailSubscriber emailObj = new SendViaEmailSubscriber();
            SendViaMobileSubscriber mobObj = new SendViaMobileSubscriber();

            emailObj.Subscribe(publisherObj);    // Calls Subscribe() methods, attaching SendMessage methods to publishevent.
            mobObj.Subscribe(publisherObj);      // Calls Subscribe() methods, attaching SendMessage methods to publishevent.

            //publisherObj.publishMessageObj = emailObj.SendMessage;
            //publisherObj.publishMessageObj += mobObj.SendMessage;

            publisherObj.PublishMessage("Hello, You have a new notification");   // Calls PublishMessage(), which triggers the event and executes all subscribed methods.

        }
    }
}