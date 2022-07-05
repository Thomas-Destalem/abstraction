using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class m
    {
        public static void main(string[] args)
        {
           
            Console.WriteLine("which shape do you want to calculate");
            Console.WriteLine("1.circle");
            Console.WriteLine("2.square");
            Console.WriteLine("3.triangle");
            Circle c=new Circle();
            square s=new square();
            triangle t=new triangle();
            int input=Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("1. area");
                Console.WriteLine("2. perimeter");
                if (input == 1)
                {
                    Console.WriteLine("area is :" + c.area());
                }

                else
                {
                    Console.WriteLine("area is :" + c.perimeter());
                }
                

                else if(input == 2)
                {
                    Console.WriteLine("1. area");
                    Console.WriteLine("2. perimeter");
                    if (input == 1)
                    {
                      
                      
                        Console.WriteLine("area is :" + s.area());
                    }
                    else
                    {
                        Console.WriteLine("area is :" + s.perimeter());
                    }
                else
                        Console.WriteLine("1. area");
                        Console.WriteLine("2. perimeter");
                    if (input == 1)
                    {
                        Console.WriteLine("area is :" + t.area());
                    }
                    else
                    {
                        Console.WriteLine("area is :" + t.perimeter());
                    }






                }
            }

        }
    }
}
