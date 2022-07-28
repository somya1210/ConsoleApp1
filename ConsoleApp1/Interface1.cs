using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Interface1
    {
        public int add(int x,int y);
        public int subtract(int x ,int y);
        public int multiply(int x,int y);
        public int divide(int x,int y);
        // if all the functions aree not implemented in the class which is inherting then it will be an error
            
    }
}
