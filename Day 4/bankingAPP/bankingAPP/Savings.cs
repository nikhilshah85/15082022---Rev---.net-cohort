using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP
{
    internal class Savings : Accounts
    {
        public override double Widraw(double amountToWidraw)
        {
            if (amountToWidraw > 5000)
            {
                throw new Exception("Savings Account can widraw max 5000");
            }
            return base.Widraw(amountToWidraw);
        }
    }
}
