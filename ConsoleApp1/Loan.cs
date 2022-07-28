using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Loan
    {
        public abstract void CalPersonalLoan();
        public abstract void CalHomeLoan();
        public void CalLoan()
        {
            Console.WriteLine("Total Loan");
        }
    }
}
