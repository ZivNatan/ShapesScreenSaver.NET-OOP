using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnBryce
{
    public class Coordinate : IEquatable<Coordinate>
    {
        private readonly double _x; 
        private readonly double _y; 

        public Coordinate()
        {
            _x = 100;
            _y = 100;
        }

        public Coordinate(double x, double y) : this()
        {
            if (x >= 0)
            _x = x;
            if (y >= 0)
            {
            _y = y; 
            }           
        }
      
        public double X
        {
            get
            {
                return _x;
            }
        }
        public double Y
        {
            get
            {
                return _y;
            }
        }

        public double GetOriginDistance()
        {
            return Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));
        }

        public bool Equals(Coordinate other)
        {
            return _x == other._x && _y == other._y;
        }
    }
}
