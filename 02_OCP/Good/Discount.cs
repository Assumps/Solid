using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._02_OCP.Good
{

    public enum EproductType
    {
        Eletronics = 1,
        Health = 2,
        Beauty = 3,
        Fashion = 4
    }

    public abstract class Discount
    {
        public abstract decimal Calculate(decimal price);
    }
}
