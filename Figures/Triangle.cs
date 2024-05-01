using SquareLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Square.Figures
{
    public class Triangle : IFigure
    {
        private double a;
        private double b;
        private double c;


        public double A
        {
            get => a;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("side less than zero");
                }
                a = value;
            }
        }
        public double B
        {
            get => b;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("side less than zero");
                }
                b = value;
            }
        }
        public double C
        {
            get => c;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("side less than zero");
                }
                c = value;
            }
        }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Square()
        {
            double pDiv2 = (double)(A + B + C) / 2;

            return Math.Sqrt(pDiv2*(pDiv2-A)*(pDiv2 - B) *(pDiv2 - C));
        }

        public bool IsRightTriangle()
        {
            double maxSide = Math.Pow(Math.Max(Math.Max(A, B), C), 2);
            double sum2Side = Math.Pow(A, 2) + Math.Pow(B, 2) + Math.Pow(C, 2) - maxSide;

            return maxSide == sum2Side;
        }
    }
}
