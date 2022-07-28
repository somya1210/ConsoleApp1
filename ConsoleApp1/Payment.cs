using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Payment
    {
        public virtual void fun()
        {
            Console.WriteLine("IN PAyment");
        }
    }
    public class Gpay:Payment
    {
        public override void fun()
        {
            Console.WriteLine("IN Gpay");
        }
    }
    public class Phonepe:Payment
    {
        public override void fun()
        {
            Console.WriteLine("IN Phonepe");
        }
    }
    public class CreditCard:Payment
    {
        public override void fun()
        {
            Console.WriteLine("IN credit card");
        }
    }
}
