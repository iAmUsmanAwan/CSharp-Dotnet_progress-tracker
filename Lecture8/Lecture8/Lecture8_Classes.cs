using System;

namespace Lecture8
{ 
    public class A {
        // Private
        private int xPrivate = 123;
        public int xPublic = 150;
        protected int xProtected = 100;
        internal int xInternal = 200;
        protected internal int xPI = 300;
        private protected  int xPP = 300;


        public void Print()
        {
            Console.WriteLine(this.xPrivate);
            Console.WriteLine(this.xPublic);
            Console.WriteLine(this.xProtected);
            Console.WriteLine(this.xInternal);
            Console.WriteLine(this.xPI);
            Console.WriteLine(this.xPP);

        }
    }

    public class B :A {
        public void Print()    
        {
            //Console.WriteLine(this.xPrivate);
            Console.WriteLine(this.xPublic);
            Console.WriteLine(this.xProtected);
            Console.WriteLine(this.xInternal);
            Console.WriteLine(this.xPI);
            Console.WriteLine(this.xPP);



            var aObj = new A();
            var bObj = new B();

            //aObj.xProtected = 10;  // here we can not access protected by creating the object of parent class
            bObj.xProtected = 21;

            aObj.xPI = 44;
            bObj.xPI = 55;

            //aObj.xPP = 44;  // will not be accessed through base class object
            bObj.xPP = 55;


        }
    }

    //public class C {
    //}

    class Driver :A
    {
        public void Test() 
        {
            var aObj = new A();
            var bObj = new B();
            var dObj = new Driver();

            //aObj.xPrivate = 10;  // Error
            //bObj.xPrivate = 21;  // Error

            aObj.xPublic = 10; 
            bObj.xPublic = 21;
            

            //aObj.xProtected = 10;  // protected will not be available here because this class was not inherited
            //bObj.xProtected = 21;  // protected will not be available here because this class was not inherited

            aObj.xInternal = 22;
            bObj.xInternal = 33;

            aObj.xPI = 44;
            bObj.xPI = 55;

            //aObj.xPP = 44;  // will not be accessed
            //bObj.xPP = 55;  // will not be accessed

            //aObj.xProtected = 44;  
            //bObj.xProtected = 55;   // ???????????????
            dObj.xProtected = 55;


        }
    }


    //class Driver {
    //    public void test()
    //    {
    //        var aObj = new A();
    //        var bObj = new B();
    //        var cObj = new C();
    //    }
    //}



}