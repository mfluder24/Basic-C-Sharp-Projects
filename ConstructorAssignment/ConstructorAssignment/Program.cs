using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
       
    static void Main(string[] args)
        {
            const string person = "Walter White"; // Creates a string constant 

            var welcome = "Welcome "; // Uses 'var' to create a string variable

            Console.WriteLine(welcome + person + "!"); // Displays const and var to show they work

            Class1 newClass1 = new Class1("Jesse Pinkman"); // Uses chained constructor to create a new instance of Class1

            Console.WriteLine(newClass1.Name + " " + newClass1.Wallet); // Displays properties of 'newClass1' instance to show chained constructor worked

            Console.ReadLine(); // Prevents program from terminating immediately
      
        }
    }
}
