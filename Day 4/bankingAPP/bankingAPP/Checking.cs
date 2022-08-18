using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP
{
    internal class Checking : Accounts
    {
        public override double Widraw(double amountToWidraw)
        {
            if (amountToWidraw > 20000)
            {
                throw new Exception("Checking Account can widraw max 20000");
            }
            return base.Widraw(amountToWidraw);
        }
    }
}
