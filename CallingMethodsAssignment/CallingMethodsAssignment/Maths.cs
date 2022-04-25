using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Maths 
    {
        public static void Maths1(int num) // Creates method 'Maths1' and has parameters of int variable 
        {
            int result = num + 20; // Adds 20 to int argument and saves 'result' as int variable
            Console.WriteLine(num + " plus 20 = "+ result + "\n"); // Displays equation and result to user, ending with new line to keep things tidy
        }

        public static void Maths2(int num) // Creates method 'Maths2' and has parameters of int variable
        {
            int result = num - 5; // Subtracts 5 from int argument and saves 'result' as int variable
            Console.WriteLine(num + " minus 5 = " + result + "\n"); // Displays equation and result to user, ending with new line to keep things tidy
        }

        public static void Maths3(int num) // Creates method 'Maths3' and has parameters of int variable
        {
            int result = num * 17; // Multiplies int argument by 17 and saves 'result' as int variable
            Console.WriteLine(num + " multiplied by 17 = " + result + "\n"); // Displays equation and result to user, ending with new line to keep things tidy
        }
    }
}
