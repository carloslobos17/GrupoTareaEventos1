using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_y_perimetro2.clases
{
    public class TriangleArea
    {
        public double Base { get; set; }
        public double Height { get; set; }


        public TriangleArea(double baase, double height)
        {
           Base = baase;
           Height = height;
        }

        public double CalculateArea()
        {
            return Base * Height / 2;
        }
    }

    public class TrianglePerimeter
    {
        public double Base { get; set; }

        public TrianglePerimeter(double baase)
        {
            Base = baase;
        }
        public double CalculatePerimeter()
        {
            return Base * 3;
        }
    }

    public class Octagon
    {
        public double Side { get; set; }

        public Octagon(double side)
        {
            Side = side;
        }

        public double CalculatePerimeter()
        {
            return Side * 8;
        }

        public double CalculateArea()
        {
            return Math.Round(2 * (1 + Math.Sqrt(2)) * Side * Side, 2);
        }
    }
}
