using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class triangle:shape
    {
        private int l;
        public int _l
        {
            get { return l; }
            set { l = value; }
        }
        private int w;
        public int _w
        {
            get { return w; }
            set { w = value; }
        }
        private int h;
        public int _h
        {
            get { return h; }   
            set { h = value; }
        }
            
        public override double area()
        {
            Console.WriteLine("enter the length, width, height");
            triangle._l = Convert.ToInt32(Console.ReadLine());
            triangle._w = Convert.ToInt32(Console.ReadLine());
            triangle._h = Convert.ToInt32(Console.ReadLine());

            return (0.5 * l * w);
        }
        public override double perimeter()
        {
            Console.WriteLine("enter the length, width, height");
            triangle._l = Convert.ToInt32(Console.ReadLine());
            triangle._w = Convert.ToInt32(Console.ReadLine());
            triangle._h = Convert.ToInt32(Console.ReadLine());
            return (l + w + h);
        }
    }
}
