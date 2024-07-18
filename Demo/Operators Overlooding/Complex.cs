using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operators_Overlooding
{
    internal class Complex
    {

        public int  Real { get; set; }

        public int imag { get; set; }


        #region operator overloding
        // overloding operator : must be non-private class member function


        #region binary operator
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                imag = (left?.imag ?? 0) + (right?.imag ?? 0)

            };
            //left?.real
            //left != null? left.real :null
        }
        #endregion


        #region unary operator
        public static Complex operator ++ (Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                imag = (C?.imag ?? 0)


            };
        }

        #endregion

        #region Comparison Operator[relational]

        public static bool operator > (Complex left , Complex right)
        {
            if(left?.Real == right?.Real)
                return left?.imag > right?.imag;
            else
                return left?.Real > right?.Real;
        }
        public static bool operator <(Complex left, Complex right)
        {
            if (left?.Real == right?.Real)
                return left?.imag < right?.imag;
            else
                return left?.Real < right?.Real;
        }
        #endregion

        #region casting operator overloding
        public static /* int*/ explicit operator int(Complex C)
        {
            return C?.Real ?? 0;
        }

        public static /* string*/ explicit operator string(Complex C)
        {

return C?.ToString() ?? string.Empty;
        }
        #endregion

        #endregion



        public override string ToString()
        {
            return $"{Real} + {imag}i";
        }
    }
}
