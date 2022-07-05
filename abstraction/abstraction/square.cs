using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class square : shape
    {
        private  int s;
        public  int _s
        {
            get { return s; }
            set
            {
                s = value;
            }
        }
        public  override double area()
        {
            Console.WriteLine("enter the side");
            square._s =Convert.ToInt32( Console.ReadLine());
            return (s*s);
        }
        public override double perimeter()
        {
            Console.WriteLine("enter the side");
            square._s = Convert.ToInt32(Console.ReadLine());
            return (4*s);
        }
    }
}
