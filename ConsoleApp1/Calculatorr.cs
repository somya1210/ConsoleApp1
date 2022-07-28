using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculatorr: Interface1
    {
        public int add(int x,int y)
        {
            return x + y;
        }
        public int subtract(int x,int y)
        {
            return x - y;
        }
        public int multiply(int x,int y)
        {
            return x * y;
        }
        public int divide(int x,int y)
        {
            return x / y;
        }
        public int xyz(int a)
        {
            return a;
        }
    }
}
