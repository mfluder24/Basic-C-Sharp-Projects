using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Maths
    {
        // Creates 'Maths1' method with one required parameter (num) and num2 set to 5, which can be changed with optional user input
        public static void Maths1(int num, int num2 = 5)
        { 
            int result = num * num2; // Multipies num by num2 and saves result as int variable
            Console.WriteLine(num + " plus " + num2 + " = " + result); // Displays equation and result to user
        }
    }
}
