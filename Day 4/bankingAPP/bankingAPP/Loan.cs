using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP
{
    internal class Loan : Accounts
    {
        public override double Widraw(double amountToWidraw)
        {
            if (amountToWidraw > accBalance)
            {
                throw new Exception("Cannot widraw more than available balance");
            }
            return base.Widraw(amountToWidraw);
        }
    }
}
