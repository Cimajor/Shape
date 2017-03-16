using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Rectangle : Shape
    {
        private int area;
        public Rectangle(int hight, int width) : base (hight, width)
        {
            
        }

        public override void Area()
        {
            area = hight* width;
            Console.WriteLine(area);
        }

    }
}
