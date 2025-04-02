using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._03_LSP.Good
{
    internal class CheckingAccount : BankAccount
    {
        public override void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
