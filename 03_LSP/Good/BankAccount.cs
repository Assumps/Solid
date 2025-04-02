using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._03_LSP.Good
{
    public abstract class BankAccount
    {
        public decimal Balance { get; protected set; }

        public abstract void Withdraw(decimal amount);
    }
}
