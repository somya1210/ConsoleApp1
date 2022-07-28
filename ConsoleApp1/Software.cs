using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Software
    {
        protected int mx;
        public Software()
        {
            mx = 100;
            Console.WriteLine(mx);
        }
        public Software(int c)
        {
            mx = c;
            Console.WriteLine(mx);  
        }
    }
    public class MS:Software
    {
        public  MS()
        {
            Console.WriteLine("In MS");
        }
    }
    public class DU:Software
    {
        public DU(int y):base(y)
        {
            Console.WriteLine("print {0}", mx);
        }
        public DU(string x,int y)
        {
            Console.WriteLine(x);
        }
    }
}
