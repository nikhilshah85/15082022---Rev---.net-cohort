using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    internal class HR : Employee
    {
        public override int ApplyLeave(int days)
        {
            if (days > 10)
            {
                Console.WriteLine("HR cannot apply leave for more than 10 days at a stretch");
                return empLeaves;
            }
            return base.ApplyLeave(days);
        }
    }
}
