using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class department
    {
        public string depname;
        public string deploc;

    }    
    public class emp:department
    {
        public string fname;
        public string lname;
        
        public void @int()
        {
            Console.WriteLine("Name of the employee is {0} {1}",fname,lname);
            Console.WriteLine("Department of the emp is {0}", depname);
            Console.WriteLine("Location of the emp is {0}", deploc);
        }
    }
}
