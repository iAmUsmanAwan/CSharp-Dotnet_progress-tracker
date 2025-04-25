using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public void PrintBoxDetails() 
        {
            Console.WriteLine($"length: {length}, width: {width}, height: {height} ");
        }

        //public static Box AddBoxes(Box b, Box c)
        //{
        //    Box box = new Box();
        //    box.length = b.length + c.length;
        //    box.width = b.width + c.width;
        //    box.height = b.height + c.height;
        //    return box;
        //}

        // Overload + Operator to add two Box Objects
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.Length = b.Length + c.length;
            box.width = b.Width + c.width;
            box.height = b.Height + c.height;
            return box;
        }

        public static bool operator ==(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length == rhs.length && lhs.width == rhs.width && lhs.height == rhs.height)
            {
                status = true;
            }
            return status;
        }


        public static bool operator !=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length != rhs.length && lhs.width != rhs.width && lhs.height != rhs.height)
            {
                status = true;
            }
            return status;
        }



    }
}
