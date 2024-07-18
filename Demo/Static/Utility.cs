using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static
{
    //static class 
    //is a just container for static member [attribute, property, constractor,methode]
    //and constant
    //no inheratance for this class

    internal static class Utility
    {
       
        // static constractur [max only one per class]
        // u can not specify access modifier or parameters for static constractor
        //will be called once per class lifetime before first usage for class
        //the usage of class is following
        //1. create object from this class or from anothor class 'inheriting from this class'
        //2.call static property
        //3.call static methode

        static Utility()
        {
          //  pi = 3.14;

        }

       
        //class member methode: static method
        public static double CMToInch(double Cm)
        {
            return Cm / 2.54;
        }
        //class member attribute :static atrribute

        //private static readonly double pi = default;
        //clr will initilize each and every static attribute with its datatype defalute value
        //before the first usage of class

        //.2 constant 
        private  const double pi = 3.14;

        //1.static attribute 
        //2.Constant 

        public static double PI { get { return pi; } }

        public static double CalcCircleArea(double darious)
        {
            return Utility.PI * darious* darious;
        }
    }
}
