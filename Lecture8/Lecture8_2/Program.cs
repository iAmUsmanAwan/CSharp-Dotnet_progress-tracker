using System;
using Lecture8;

namespace Lecture8_2
{ 
    class Driver
    {
        public void test()
        {
             var aObj = new A();   // this will give error if A is not set as public class
             var bObj = new B();   // this will give error if B is a internal class
                                   //var cObj = new C();

            //aObj.xInternal = 123;  // internal is not available in external project file
            //bObj.xInternal = 456;  // internal is not available in external project file

            //aObj.xPI = 44;  // Protected Internal cannot be directly fetched in external projects
            //bObj.xPI = 55;  // ???????????????
            //dObj.xPI = 66;  // ???????????????????????????


            //bObj.xPP = 55;   // can only be accessed in same assembly
            //bObj.xPP = 65;

        }
    }

}