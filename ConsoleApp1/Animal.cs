using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    { 
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
        public void greet()
        {
            Console.WriteLine("Animal says Hello");
        }
        public void talk()
        {
            Console.WriteLine("Animal talk");
        }
        public virtual void sing()
        {
            Console.WriteLine("Animal sing");
        }
    }
    class dog:Animal
    {
        public dog()
        {
            Console.WriteLine("dog");
        }
        public override void sing()
        {
            Console.WriteLine("Overriding understanding");
        }
    }
}
