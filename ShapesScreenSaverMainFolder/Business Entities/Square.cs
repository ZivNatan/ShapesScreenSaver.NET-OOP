using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnBryce
{
    public class Square : Shape, IEquatable<Square>
    {
        private double _edgeLength;

        public Square() { }

        public Square(Coordinate centerOfShape, Color color, int lineWidth, double edgeLength)
            : base(centerOfShape, color, lineWidth)
        {
            EdgeLength = edgeLength;
        }

        public Square(double x, double y, Color color, int lineWidth, double edgeLength)
            : base(x, y, color, lineWidth)
        {
            EdgeLength = edgeLength;
        }

        public double EdgeLength
        {
            get
            {
                return _edgeLength;
            }
            set
            {
                if (value < 0)
                {
                    throw new ShapeException();

                }
                _edgeLength = value;
            }
        }

        public override string ToString()
        {
            return "I am a Square and my edge length is: " + _edgeLength;
        }

        public override double GetArea()
        {
            return _edgeLength * _edgeLength;
        }

        public override double GetPerimeter()
        {
            return _edgeLength * 4;
        }

        public bool Equals(Square other)
        {
            return base.Equals(other) && _edgeLength == other._edgeLength;
        }

        public override void Draw(Graphics g)
        {
            int x = (int)(Center.X - _edgeLength / 2);
            int y = (int)(Center.Y - _edgeLength / 2);
            g.DrawRectangle(new Pen(Color, LineWidth), x, y, (int)_edgeLength, (int)_edgeLength);
        }
    }
}
