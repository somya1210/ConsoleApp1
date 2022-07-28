// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Enter your name");
//string nam=Console.ReadLine();
//Console.WriteLine(nam);
//Console.WriteLine(nam+"enter your year of experience");
//int age=Convert.ToInt32(Console.ReadLine());
//if (age < 20)
//  Console.WriteLine("YOu are a fresher");
//else
//  Console.WriteLine("You have experience");
//Console.WriteLine("Enter your location");
//string country=Console.ReadLine();
//Console.WriteLine("hey , this is " + nam + "from " + country);
//int n=Convert.ToInt32(Console.ReadLine());
using System.Collections;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //StringBuilder sb = new StringBuilder("Hello World!");
            //sb.Insert(5, " C#");

            /*   StringBuilder s = new StringBuilder("Hello This is ",20);
               Console.WriteLine(s);
               s.Insert(6, "hi");
               s.Insert(7, "dd");
               s.Remove(3, 4);
               Console.WriteLine(s);
               s.AppendLine("");
               s.Append("somya");
               Console.WriteLine(s);
            */
            /*int p, q;
            find(out p, out q);
            Console.WriteLine(p);
            Console.WriteLine(q);*/
            // out keyword when multiple values arre to be returned then instead o f returning use this ou tt keyword
            /* int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
             int[] ans = new int[5];// find(ar);
             int[] a1 = new int[5];
             for (int i = 0; i < 5; i++)
                 a1[i] = ar[i];
             int j = 0;
             for (int i = 5; i < 10; i++)
             { ans[j] = ar[i];
             j++; }
             int[] a2 = find(ans);
             // find(out ar);
             for (int i = 0; i < 5; i++)
                 Console.WriteLine(a1[i]);
             for(int i=0;i<5;i++)
             {
                 Console.WriteLine(a2[i]);
             }

         }
         static int[] find(int[] p)
         {
             for (int i = 0; i < 2; i++)
             {
                 int x = p[i];
                 p[i] = p[4 - i];
                 p[4 - i] = x;
             }
             return p;
         }*/
            /* Calculatorr calculator = new Calculatorr();
             int x=calculator.add(2, 3);
             Console.WriteLine(x);

             int y=calculator.subtract(2, 3);
             Console.WriteLine(y);
             int a = calculator.xyz(5);
             Console.WriteLine(a);

             int z=calculator.multiply(2 , 3);
             Console.WriteLine(z);
             int p=calculator.divide(2, 3);
             Console.WriteLine(p);
            */
            //Class2 class2 = new Class2();
            //int x= class2.multiplynumbers(3, 4);
            //Console.WriteLine(x);
            //  Console.WriteLine(double.MinValue);
            // null;
           /* string x = null;
            int? i =10;
            int j = i ?? 0;
            Console.WriteLine(j);
        */
      //      Console.WriteLine();
            Class2 classa=new Class2();
            classa.CalPersonalLoan();
            classa.CalHomeLoan();
            classa.CalLoan();


        }
           
            
            








      
    }
  
}