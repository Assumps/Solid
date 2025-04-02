using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._02_OCP.Good
{
    internal class EletronicsDiscount : Discount
    {
        public override decimal Calculate(decimal price) => price * 0.5M;

    }
}
