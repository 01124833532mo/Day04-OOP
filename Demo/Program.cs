using Demo.Abstraction;
using Demo.Casting_Operator_Overlloding;
using Demo.Operators_Overlooding;
using Demo.Partial;
using Demo.Sealde;
using Demo.Static;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region operators overloding

            //Complex c1 =new Complex() {Real=1,imag=5 };
            //Complex c2 = new Complex() { Real = 3, imag = 4 };


            #region binary operator
            //Complex c3 = default;

            //c3 = c2 + c1;

            //c2 += c1;

            //Complex c4 = c1 + c2 + c3;

            //Console.WriteLine($"c1 ={c1}");
            //Console.WriteLine($"c2 ={c2}");
            //Console.WriteLine($"c3 ={c3}");

            #endregion

            #region unary operator
            //Console.WriteLine($"c1 = {c1}");
            //Complex c3 = c1++;

            //Console.WriteLine("after ++c1");

            //Console.WriteLine($"c1 ={c1}");
            //Console.WriteLine($"c2 ={c2}"); 
            #endregion

            #region comparision operator [relational ]
            //if (c1 > c2)
            //{
            //    Console.WriteLine("c1 greater c2")  ;
            //}
            //else if (c1 < c2) {
            //    Console.WriteLine("c1 less than c2");
            //}
            //else
            //{
            //    Console.WriteLine( "c1  equal c2");
            //}

            #endregion

            #endregion

            #region casting operators overloding

            #region example1
            //Complex c1 = new Complex() { Real = 1, imag = 5 };

            //int y = (int)c1; //excipicit casting
            //Console.WriteLine($"y = {y}");

            //object o1 = 6;
            //int y1 = (int)o1;

            #endregion

            #region example2
            //Complex c1 = new Complex() { Real = 1, imag = 5 };

            //string y = (string)c1; //excipicit casting
            //Console.WriteLine($"y = {y}");

            //object o1 = "ahmed";
            //string y1 = (string)o1;



            #endregion

            #endregion

            #region casting Operators Overloding -Bussines need [mapping]
            //User user = new User()
            //{
            //    Id = 1,
            //    FullName = "mohamed hamdi",
            //    Email = "mohamed@gmaol.com",
            //    Password = "123456",
            //    SecurityStmp = Guid.NewGuid()

            //};

            //UserViewModel viewModel = (UserViewModel)user;

            //Console.WriteLine(viewModel.Id);
            //Console.WriteLine(viewModel.Fname);
            //Console.WriteLine(viewModel.Lname);
            //Console.WriteLine(viewModel.Email);
            //Console.WriteLine(viewModel.Password); 
            #endregion

            #region Abstraction [abstrac class,abstract method,abstract property]
            //Shap shap;
            //shap = new Rect(10, 20);

            //decimal rectarea = shap.calcarea();
            //decimal rectperi = shap.perimeter;

            //Console.WriteLine($"area{rectarea}");
            //Console.WriteLine($"peri{rectperi}");


            //shap = new squar(20);

            //decimal squararea = shap.calcarea();
            //decimal squarperi = shap.perimeter;

            //Console.WriteLine($"area{squararea}");
            //Console.WriteLine($"peri{squarperi}");


            //shap = new circle(20);

            //decimal circlearea = shap.calcarea();
            //decimal circilperi = shap.perimeter;

            //Console.WriteLine($"area{circlearea}");
            //Console.WriteLine($"peri{circilperi}"); 
            #endregion


            #region static [class , attribute, property, constractor, methode ] and conast

            //Utility u01 = new Utility(1, 2);
            //Utility u02 = new Utility(1, 2);

            ////the resulte of calling methode "cmtoinch " will not be different by the difference
            //Console.WriteLine(Utility.CMToInch(245));
            //Console.WriteLine(Utility.CMToInch(245);

            //Console.WriteLine($"Circle area is {Utility.CalcCircleArea(10)}");
            //Console.WriteLine($"Circle area is {Utility.CalcCircleArea(10)}"); 
            #endregion

            #region seald [class ,property]

            //ImutableString str = new ImutableString("ahmed");

            //str = new ImutableString("mohamed"); 
            #endregion

            #region partial[class,struct,interface,method]
            //Emploee emploee = new Emploee() { 
            //Id = 1,
            //Name    = "Test",
            //Salary  =111111,
            //age = 10,
            //address="fayoum"

            //}; 
            #endregion

            #region class type sumary
            //1.concrete class
            //2.static class
            //3.abstract class
            //4.seald class
            //5.partial class
            #endregion
        }
    }
}
