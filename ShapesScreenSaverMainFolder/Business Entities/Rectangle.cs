using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnBryce
{
    public class Rectangle : Shape, IEquatable<Rectangle>
    {
        private double _height;
        private double _width;

        public Rectangle()
        {

        }

        public Rectangle(Coordinate centerOfShape, Color color, int lineWidth, double width, double height)
            : base(centerOfShape, color, lineWidth)
        {
            Height = height;
            Width = width;
        }

        public Rectangle(double x, double y, Color color, int lineWidth, double width, double height)
            : base(x, y, color, lineWidth)
        {
            Height = height;
            Width = width;
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ShapeException();
                }
                _height = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ShapeException();
                }
                _width = value;
            }
        }

        public override string ToString()
        {
            return "I am a Rectangle!\nMy height is " + _height + " and my width is " + _width;
        }

        public bool Equals(Rectangle other)
        {
            return base.Equals(other) && _height == other._height && _width == other.Width;
        }

        public override double GetArea()
        {
            return _height * _width;
        }

        public override double GetPerimeter()
        {
            return _height * 2 + _width * 2;
        }

        public override void Draw(Graphics g)
        {
            int x = (int)(Center.X - _height / 2);
            int y = (int)(Center.Y - _width / 2);
            g.DrawRectangle(new Pen(Color, LineWidth), x, y, (int)_height, (int)_width);
        }
    }
}
