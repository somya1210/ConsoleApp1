using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        public int x, y, z;
        public double a;
        public int add(params int[]ar)

        {
        //
        Console.WriteLine("Inside the method with 2 params ,sum is {0}",x+y);
        return x+y;
        }

        public int sub(int x,int y)
        {
            Console.WriteLine("Inside the method with 2 params ,sub is {0}", x - y);
            return x - y;
        }
        public int add(int x, int y,int z)

        {
            //
            Console.WriteLine("Inside the method with 3 params ,sum is {0}", x + y+z);
            return x + y+z;
        }
        public int sub(int x, int y, int z)

        {
            //
            Console.WriteLine("Inside the method with 3 params ,sum is {0}", x - y - z);
            return x - y - z;
        }
        public int add(int x, int y,double a)

        {
            //
            Console.WriteLine("Inside the method with 2 params ,sum is {0}", x + y+a);
            return x + y+z;
        }
    }
}
