using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealde
{
    internal sealed class PamentProccessor
    {
        public void proccessPament(decimal Amount)
        {
            Console.WriteLine($"amount {Amount}");
        }
    }

    //internal class MyPamentProcessor : PamentProccessor
    //{
    //    public new void proccessPament(decimal Amount)
    //    {
    //        Console.WriteLine($"amount {Amount +20}");
    //    }

    //}
}
