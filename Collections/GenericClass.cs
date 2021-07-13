using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class GenericClass<Tip>
    {
        Tip a;
        Tip b;

        public GenericClass(Tip a, Tip b)
        {
            this.a = a;
            this.b = b;
        }

        public double Sum()
        {
            return Convert.ToDouble(a) + Convert.ToDouble(b);
        }
    }
}
