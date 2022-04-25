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
        public int Maths1(int num, int num2 = 5)
        { 
            return num * num2; // Multipies num by num2 and returns result
        }
    }
}
