using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    abstract class Shape
    {
        protected int hight;
        protected int width;

        public Shape(int hight, int width)
        {
            this.hight = hight;
            this.width = width;
        }

        public abstract void Area();

    }
}
