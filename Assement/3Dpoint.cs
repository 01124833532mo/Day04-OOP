using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement
{
    internal class _3Dpoint :IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; } 

        public _3Dpoint(int _x) {
        X= _x;
            Y = 0;
            Z = 0;
        
        }

        public _3Dpoint(int _x,int _y) : this(_x) 
        {
            Y = _y;
            Z = 0;
        }
        public _3Dpoint(int _x, int _y,int _z) : this(_x,  _y)
        {
            Z = _z;  
        }


        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(object? obj)
        {
            _3Dpoint? Emp = (_3Dpoint?)obj;

            int comparx = this.X.CompareTo(Emp?.X);
            if(comparx != 0)
                return comparx;

            int compary = this.Y.CompareTo(Emp?.Y);
            if (compary != 0)
                return compary;

            return this.Z.CompareTo(Emp?.Z);
        }

        public object Clone()
        {
            return new _3Dpoint(this.X, this.Y, this.Z); // because we have chining constractor
           
        }

        public static bool operator == (_3Dpoint left, _3Dpoint right) {

            if ((left?.X ?? 0) == (right?.X ?? 0) && (left?.Y ?? 0) == (right?.Y ?? 0) && (left?.Z ?? 0) == (right?.Z ?? 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(_3Dpoint left, _3Dpoint right)
        {

            if ((left?.X ?? 0) != (right?.X ?? 0) && (left?.Y ?? 0) != (right?.Y ?? 0) && (left?.Z ?? 0) != (right?.Z ?? 0))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
