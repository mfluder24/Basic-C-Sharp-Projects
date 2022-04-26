using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number() { Amount = 1408 }; // Creates new Number 'num' and sets Amount to 1408

            Console.WriteLine(num.Amount); // Displays 'Amount' to user

            Console.ReadLine(); // Prevents program from terminating immediately
            
        }
    }
}
