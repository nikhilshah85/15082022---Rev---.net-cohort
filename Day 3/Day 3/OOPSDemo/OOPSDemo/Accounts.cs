using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    internal class Accounts : Employee
    {
        public override int ApplyLeave(int days)
        {
            if (days >7)
            {
                Console.WriteLine("You cannot apply for more than 7 days of leave");
                return empLeaves;
            }
            return base.ApplyLeave(days);
        }
    }
}
