using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Math
    {
        public int x;
        public double y;
        public string z;
        
    }
    public class Mathadd:Math
    {
        public Mathadd(int a)
        {
            x = a;  
            Console.WriteLine("This is first constructor here integer is assigned {0} {1}",x,y);
        }
        public Mathadd(int p, double q):this(p)
        {
            y = q;
            Console.WriteLine("This is a second constructor here double is assigned {0},{1}{2}", x, y,z);
        }
        public Mathadd(int a,double b,string c)//:this(a,b)
        {
            z = c;
            Console.WriteLine("This is third constructor here string is assigned and appended{0},{1},{2}",x,y,z);
        }

    }
}
