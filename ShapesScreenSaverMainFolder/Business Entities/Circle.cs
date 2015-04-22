using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnBryce
{
    public class Circle : Shape, IEquatable<Circle>
    {
        private double _radius;

        public Circle()
        {

        }

        public Circle(Coordinate centerOfShape, Color color, int lineWidth, double radius)
            : base(centerOfShape, color, lineWidth)
        {
            Radius = radius;
        }

        public Circle(double x, double y, Color color, int lineWidth, double radius)
            : base(x, y, color, lineWidth)
        {
            Radius = radius;
        }

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ShapeException();
                }
                _radius = value;
            }
        }

        public override string ToString()
        {
            return "I am a Circle and my radius is " + _radius;
        }

        public bool Equals(Circle other)
        {
            return base.Equals(other) && _radius == other._radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public override void Draw(Graphics g)
        {
            int x = (int)(Center.X - _radius);
            int y = (int)(Center.Y - _radius);
            int width = (int)(_radius * 2);
            int height = (int)(_radius * 2);

            g.DrawEllipse(new Pen(Color, LineWidth), x, y, width, height);
        }
    }
}
