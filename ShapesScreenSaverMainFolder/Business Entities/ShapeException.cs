using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnBryce
{
    class ShapeException:Exception
    {
        public override string Message
        {
            get
            {
                return "Illegal value, Shape value can't be negative."; 
            }
        }
    }
}
