using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uses polymorphism to instantiate IQuittable/Employee object 'ron' and assigns values to properties
            IQuittable ron = new Employee() { FirstName = "Ron", LastName = "Obvious" };

            ron.Quit(); // Utilises interface method 'Quit' on employee object

            Console.ReadLine(); // Prevents program from terminating immediately
        }
    }
}
