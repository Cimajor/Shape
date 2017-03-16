using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Test
    {
        public static void Main(String[] args)
        {
            int hight = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());

            Shape rectangle = new Rectangle(hight, width);
            Shape triangle = new Triangle(hight, width);
            rectangle.Area();
            triangle.Area();
            Console.ReadLine();
        }
    }
}
