namespace Assement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region first project Define 3D Point Class and the basic Constructors (use chaining in constructors).

            //       int x1, y1, z1, x2, y2, z2;

            //      do
            //      {
            //          Console.WriteLine(" enter X coordinate for point P1");
            //      } while (!int.TryParse(Console.ReadLine(), out x1));

            //      do
            //      {
            //          Console.WriteLine(" enter Y coordinate for point P1:");
            //      } while (!int.TryParse(Console.ReadLine(), out y1));

            //      do
            //      {
            //          Console.WriteLine(" enter Z coordinate for point P1:");
            //      } while (!int.TryParse(Console.ReadLine(), out z1));

            //      do
            //      {
            //          Console.WriteLine(" enter X coordinate for point P2:");
            //      } while (!int.TryParse(Console.ReadLine(), out x2));

            //      do
            //      {
            //          Console.WriteLine(" enter Y coordinate for point P2:");
            //      } while (!int.TryParse(Console.ReadLine(), out y2));

            //      do
            //      {
            //          Console.WriteLine(" enter Z coordinate for point P2:");
            //      } while (!int.TryParse(Console.ReadLine(), out z2));

            //      _3Dpoint P1 = new _3Dpoint(x1, y1, z1);
            //      _3Dpoint P2 = new _3Dpoint(x2, y2, z2);

            //      if (P1 == P2)
            //      {
            //          Console.WriteLine("p1 equal p2");
            //      }
            //      else
            //      {
            //          Console.WriteLine("Not Equal");
            //      }

            //      _3Dpoint[] points = new _3Dpoint[]
            //{
            //      new _3Dpoint(11, 20, 30),
            //      new _3Dpoint(5, 13, 25),
            //      new _3Dpoint(10, 65, 20),
            //      new _3Dpoint(5, 16, 13)
            //};

            //      Array.Sort(points);
            //      Console.WriteLine("*********************************************");
            //      Console.WriteLine("Sorted points:");

            //      foreach (_3Dpoint point in points)
            //      {
            //          Console.WriteLine(point);
            //      }



            //      _3Dpoint p3 = (_3Dpoint)P1.Clone();
            //      Console.WriteLine("*********** clone *****************");
            //      Console.WriteLine(p3); 
            #endregion

            #region second project Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters. Call each method in Main ().

            //Console.WriteLine("add");
            //Console.WriteLine(Maths.Add(10, 5));
            //Console.WriteLine("Subtract");
            //Console.WriteLine( Maths.Subtract(10, 0));
            //Console.WriteLine("Multiply ");
            //Console.WriteLine(Maths.Multiply(10, 5));

            //Console.WriteLine("Divide ");
            //Console.WriteLine( Maths.Divide(10, 0)); 
            #endregion

            #region third project Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
            int h, m, s;

            do
            {
                Console.WriteLine("enter hours");
            } while (!int.TryParse(Console.ReadLine(), out h) || h < 1 || h > 12);


            do
            {
                Console.WriteLine("enter minites");
            } while (!int.TryParse(Console.ReadLine(), out m) || m < 1 || m >= 60);

            do
            {
                Console.WriteLine("enter second");
            } while (!int.TryParse(Console.ReadLine(), out s) || s < 1 || s >= 60);

            Duration D1 = new Duration(h, m, s);

            Console.WriteLine(D1.ToString());

            //    Console.WriteLine("*********************************");

            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2);
            //Console.WriteLine("*********************************");

            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3);
            //Console.WriteLine("*********************************");


            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4);

            //Console.WriteLine("*********************************");


            //Duration D5 = D1 + D2;
            //Console.WriteLine(D5);

            //Console.WriteLine("*********************************");

            //Duration D6 = D1 + 7800;
            //Console.WriteLine(D6);
            //Console.WriteLine("*********************************");


            //D3 = 666 + D3;
            //Console.WriteLine(D3);
            //Console.WriteLine("*********************************");

            //D3 = ++D1;
            //Console.WriteLine(D3);
            //Console.WriteLine("*********************************");
            //D3 = --D2;
            //Console.WriteLine(D3);
            //Console.WriteLine("*********************************");

            //D1 = D1 - D2;
            //Console.WriteLine(D1);

            //Console.WriteLine("*********************************");

            //Console.WriteLine(D1 > D2);

            //Console.WriteLine("*********************************");
            //Console.WriteLine(D1 <= D2);
            //Console.WriteLine("*********************************");
            //Console.WriteLine((bool)D1);
            //Console.WriteLine("*********************************");



            //DateTime dt = (DateTime)D1;
            //Console.WriteLine(dt.ToString("HH:mm:ss"));
            #endregion


        }
    }
}
