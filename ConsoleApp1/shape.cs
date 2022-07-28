using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class shape
    {
     public int height;
        public int width;
        public void setheight(int h)
        {
            height = h;

        }
        public void setwidth(int w)
        {
            width = w;

        }
        

    }
    public class rectangle : shape
    {
        public int getarea()
        {
            return width * height;
        }
    }
}
