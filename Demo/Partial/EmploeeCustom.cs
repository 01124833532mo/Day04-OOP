using Demo.Sealde;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Partial
{
    internal partial class Emploee :Parent
    {

        public string address {  get; set; }

        public partial int Dosomthing(int X)
        {
            throw new NotImplementedException();
        }
    }
}
