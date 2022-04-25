using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Maths
    {
        public int Maths1(int num) // Creates method called 'Maths1' with int parameter
        {
            return num + 24; // Performs math operation on num argument and saves result as int variable
        }

        public int Maths1(decimal num) // Creates method called 'Maths1' with decimal parameter
        {
            return Convert.ToInt32(num / 2); // Performs equation on decimal argument and converts result to int variable
        }

        public int Maths1(string num) // Creates method called 'Maths1' with string parameter
        {
            int number = Convert.ToInt32(num); // Converts string argument to int variable
            return number * 3; // Performs equation on int argument and saves result to int variable
        }
    }
}
