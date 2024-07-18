using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    //abstract class 
    // is partial implementation for other classes 
    //is contaner for common code [fully implemented member ,abstract members] among many classes
    //u can not create object from absrtact classs

    internal abstract class Shap
    {
        public decimal dim01 { get; set; }

        public decimal dim02 { get; set; }
        //abstract property =virtaul property without implementation

        protected Shap(decimal _dim1,decimal _dim2)
        {
            dim01 = _dim1;
            dim02 = _dim2;
        }

        public abstract decimal perimeter { get;  }


        //abstract methode =virtaul methode without implementation
        public abstract decimal calcarea();

    }

    class Rect : rectbase
    {
        public Rect(decimal dim01, decimal dim02) : base(dim01, dim02)
        {


        }
        public override decimal perimeter { get {
                return (dim01 + dim02) * 2;
            } }
      

        


    }

    class parent
    {
        private protected int salary;
        public virtual int Salary { get { return salary; } set { salary = value < 5000 ? 5000 : value; } }

        public virtual void print() {
            Console.WriteLine("iam parent");
        }


    }

    class child : parent {
        public override int Salary { get => base.Salary; set => base.Salary = value+2000; }

        public override void print()
        {
            Console.WriteLine("iam child");
        }

    }

    class squar : rectbase
    {

        public squar(int dim) :base(dim, dim)
        {
            //this.dim01=this.dim02=dim;
        }
        public override decimal perimeter { get { return dim01 * 4; } }

       
    }

   abstract class  rectbase : Shap
    {

        protected rectbase(decimal dim01,decimal dim02) : base(dim01, dim02)
        {


        }
        public override decimal calcarea()
        {
            return dim01 * dim02;
        }
    }

    class circle : Shap
    {
        public circle(decimal radius):base(radius, radius) { 
         
            //this.dim01=this.dim02=radius;

        }
        public override decimal perimeter { get { return 2 * 3.14M * this.dim01; } }

        public override decimal calcarea()
        {
return 3.14m * this.dim01 * this.dim01;
                }


    }

    class triangle : Shap
    {
        public decimal dim03 { get; set; }
        public triangle(decimal dim01,decimal dim02,decimal dim03) :base(dim01,dim02) {
        this.dim03=dim03;
        }
        public override decimal perimeter => throw new NotImplementedException();

        public override decimal calcarea()
        {
            throw new NotImplementedException();
        }
    }




}
