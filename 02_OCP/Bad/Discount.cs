using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._02_OCP.Bad
{
    public enum EproductType
    {
        Eletronics = 1,
        Health = 2,
        Beauty = 3,
        Fashion = 4
    }

    public class Discount
    {
        public decimal Calculate(EproductType type, decimal amount)
        {
            if (type == EproductType.Eletronics)
                return amount * 0.1M;

            if (type == EproductType.Health)
                return amount * 0.3M;

            if (type == EproductType.Beauty)
                return amount * 0.4M;

            if (type == EproductType.Fashion)
                return amount * 0.5M;

            return amount;
        }
    }
}
