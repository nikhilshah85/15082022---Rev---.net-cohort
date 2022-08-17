//this are base class libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    abstract internal class Employee
    {

        #region Properties
        //empNo,empName,empDesignation,empSalary,empLeave
        public int empNo { get; set; }

        public string empName { get; set; } = "";

        public string empDesignation { get; set; } = "";

        public double empSalary { get; set; }

        public int empLeaves { get; set; }
        #endregion

        #region Methods
        public virtual int ApplyLeave(int days)
        {
            if(days < 1)
            {
                Console.WriteLine("Please enter days more than 0");
            }

            empLeaves = empLeaves - days;
            return empLeaves;
        }

        public string ChangeDesigantion(string newDesigantion)
        {
            empDesignation = newDesigantion;
            return empDesignation;
        }
        #endregion

    }
}
