using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnBryce
{
    public abstract class Shape : IEquatable<Shape>, IDrawable
    {
        public Coordinate Center;
        public Color Color;
        private int _lineWidth;
        private static int _count;

        public Shape()
        {
            Center = new Coordinate();
            _count++;
        }

        public Shape(Coordinate center, Color color, int lineWidth)
            : this()
        {
            Center = center;
            Color = color;
            LineWidth = lineWidth;
        }

        public Shape(double x, double y, Color color, int lineWidth)
            : this(new Coordinate(x, y), color, lineWidth)
        {
        }

        public int LineWidth
        {
            get
            {
                return _lineWidth;
            }
            set
            {
                if (value < 0)
                {
                    throw new ShapeException();
                }
                _lineWidth = value;
            }
        }

        public static int Count
        {
            get
            {
                return _count;
            }
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();

        public double GetDistanceFromAnotherCoordinate(double x, double y)
        {
            return Math.Sqrt(Math.Pow((Center.X - x), 2) + Math.Pow((Center.Y - y), 2));
        }

        public double GetDistanceFromAnotherCoordinate(Coordinate other)
        {
            return Math.Sqrt(Math.Pow((Center.X - other.X), 2) + Math.Pow((Center.Y - other.Y), 2));
        }

        public bool Equals(Shape other)
        {
            return (Center.Equals(other) && Color == other.Color && _lineWidth == other._lineWidth);
        }

        public abstract void Draw(Graphics g);

    }
}
