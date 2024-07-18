using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealde
{
    internal sealed class ImutableString
    {
        private readonly string value;

        public string Value { get { return value; } }

        public ImutableString(string value)
        {
this.value = value;
        }
    }
}
