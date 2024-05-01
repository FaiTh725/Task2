using SquareLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square.Figures
{
    public class Circle : IFigure
    {
        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("radius less than zero");
                }
                radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Square()
        {
            return Math.PI * Radius*Radius;
        }
    }
}
