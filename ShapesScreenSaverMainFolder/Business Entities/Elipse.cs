using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnBryce
{
    public class Elipse : Shape, IEquatable<Elipse>
    {
        private double _elipseHeight;
        private double _elipseWidth;

        public Elipse() { }

        public Elipse(Coordinate centerOfShape, Color color, int lineWidth, double elipseWidth, double elipseHeight)
            : base(centerOfShape, color, lineWidth)
        {
            ElipseHeight = elipseHeight;
            ElipseWidth = elipseWidth;
        }

        public Elipse(double x, double y, Color color, int lineWidth, double elipseWidth, double elipseHeight)
            : base(x, y, color, lineWidth)
        {
            ElipseHeight = elipseHeight;
            ElipseWidth = elipseWidth;
        }

        public double ElipseHeight
        {
            get
            {
                return _elipseHeight;
            }
            set
            {
                if (value < 0)
                {
                    throw new ShapeException();
                }
                _elipseHeight = value;
            }
        }

        public double ElipseWidth
        {
            get
            {
                return _elipseWidth;
            }
            set
            {
                if (value < 0)
                {
                    throw new ShapeException();
                }
                _elipseWidth = value;
            }
        }

        public override string ToString()
        {
            return "I am an Elipse and my rectangle height is " + _elipseHeight + " and my rectangle width is " + _elipseWidth;
        }

        public bool Equals(Elipse other)
        {
            return base.Equals(other) && _elipseHeight == other._elipseHeight && _elipseWidth == other._elipseWidth;
        }

        public override double GetArea()
        {
            return Math.PI * (_elipseWidth / 2) * (_elipseHeight / 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Math.Sqrt((Math.Pow(_elipseHeight, 2) / 2) + (Math.Pow(_elipseWidth, 2) / 2));
        }

        public override void Draw(Graphics g)
        {
            int x = (int)(Center.X - _elipseHeight / 2);
            int y = (int)(Center.Y - _elipseWidth / 2);
            g.DrawEllipse(new Pen(Color, LineWidth), x, y, (int)_elipseWidth, (int)_elipseHeight);
        }
    }
}
