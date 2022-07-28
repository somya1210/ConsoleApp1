using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class employee:Iemp
    {
        public void GetFirstName()
        {
            Console.WriteLine("Get the fname");
        }
        public void GetLastName()
        {
            Console.WriteLine("Get the lname");
        }
    }
}
