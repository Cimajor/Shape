using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Triangle : Shape
    {
        private int area;

        public Triangle(int hight, int width) : base(hight, width)
        {

        }
        public override void Area()
        {
            area = hight * width/2;
            Console.WriteLine(area);
        }
    }
}
