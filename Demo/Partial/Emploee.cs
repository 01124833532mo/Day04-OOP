using Demo.Sealde;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Partial
{
    //develop 1
    internal partial class Emploee :Parent
    {
        public int Id { get; set; }
         
        public string Name { get; set; }

            public int age { get; set; }

        //partial methode
        public partial int Dosomthing(int X);
         public void test()
        {
            Dosomthing(10);
        }
    }
}
