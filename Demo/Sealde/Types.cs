using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealde
{
    class Parent
    {
        public virtual int Salary { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Iam base");

        }


    }


    class Child : Parent
    {
        public sealed override int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value < 5000 ? 5000 : value; }
        }



    }

    class GrandChild : Child { 
    
        public new int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value < 6000 ? 6000 : value; }
        }
    
    
    }


    
    
}
