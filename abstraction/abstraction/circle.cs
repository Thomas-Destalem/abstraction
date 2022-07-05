using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class Circle : shape
    {
        private int r;
        public int _r
        {
            get { return r; }
            set { r = value; }
        }
        private double pi=3.14;
        public double _pi
        {
            get { return pi; }
            set { pi = value; }
        }

        public override double area()
        {
            Console.WriteLine("enter the radius");
            Circle._r = Convert.ToInt32(Console.ReadLine());
            return (r * r * pi);
        }

        public override double perimeter()
        {
            Console.WriteLine("enter the radius");
            Circle._r = Convert.ToInt32(Console.ReadLine());
            return (2 * pi * r);
        }
    }
}
