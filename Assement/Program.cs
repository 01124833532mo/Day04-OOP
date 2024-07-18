namespace Assement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region first project Define 3D Point Class and the basic Constructors (use chaining in constructors).

            int x1, y1, z1, x2, y2, z2;

            do
            {
                Console.WriteLine(" enter X coordinate for point P1");
            } while (!int.TryParse(Console.ReadLine(), out x1));

            do
            {
                Console.WriteLine(" enter Y coordinate for point P1:");
            } while (!int.TryParse(Console.ReadLine(), out y1));

            do
            {
                Console.WriteLine(" enter Z coordinate for point P1:");
            } while (!int.TryParse(Console.ReadLine(), out z1));

            do
            {
                Console.WriteLine(" enter X coordinate for point P2:");
            } while (!int.TryParse(Console.ReadLine(), out x2));

            do
            {
                Console.WriteLine(" enter Y coordinate for point P2:");
            } while (!int.TryParse(Console.ReadLine(), out y2));

            do
            {
                Console.WriteLine(" enter Z coordinate for point P2:");
            } while (!int.TryParse(Console.ReadLine(), out z2));

            _3Dpoint P1 = new _3Dpoint(x1, y1, z1);
            _3Dpoint P2 = new _3Dpoint(x2, y2, z2);

            if (P1 == P2)
            {
                Console.WriteLine("p1 equal p2");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            _3Dpoint[] points = new _3Dpoint[]
      {
                  new _3Dpoint(11, 20, 30),
                  new _3Dpoint(5, 13, 25),
                  new _3Dpoint(10, 65, 20),
                  new _3Dpoint(5, 16, 13)
      };

            Array.Sort(points);
            Console.WriteLine("*********************************************");
            Console.WriteLine("Sorted points:");

            foreach (_3Dpoint point in points)
            {
                Console.WriteLine(point);
            }



            _3Dpoint p3 = (_3Dpoint)P1.Clone();
            Console.WriteLine("*********** clone *****************");
            Console.WriteLine(p3);
            #endregion




        }
    }
}
