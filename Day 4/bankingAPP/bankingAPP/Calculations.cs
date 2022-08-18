using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP
{
    internal class Calculations
    {
        #region Add method overloads
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public int Add(int num1, int num2, int num3, int num4)
        {
            return num1 + num2 + num3 + num4;
        }

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }


        public string Add(string val1, string val2)
        {
            return val1 + " " + val2;
        }
        #endregion

        public Calculations()
        {

        }

        public Calculations(int num1, int num2)
        {

        }

        public Calculations(string n1, string n2)
        {
            
        }

    }
}
