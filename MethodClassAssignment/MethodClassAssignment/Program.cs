using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some math!"); // Displays message to the user

            Maths.Maths1(24, 72); // Calls 'Maths1' method and passes two arguments

            Maths.Maths1(num1: 17, num2: 407); // Calls 'Maths1' method and passes two arguments, specifying parameters by name

            Console.ReadLine(); // Prevents program from terminating immediately
        }
    }
}
