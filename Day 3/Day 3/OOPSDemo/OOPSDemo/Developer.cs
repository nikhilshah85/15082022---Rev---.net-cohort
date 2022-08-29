using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    internal class Developer : Employee
    {
        public string developerType { get; set; }

        public override int ApplyLeave(int days)
        {
            if (days > 5)
            {
                Console.WriteLine("Developer can apply for maximum 5 days of leave");
                return empLeaves;
            }
            return base.ApplyLeave(days);
        }
    }
}
