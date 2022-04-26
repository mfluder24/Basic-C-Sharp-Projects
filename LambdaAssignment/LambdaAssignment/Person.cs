using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    public abstract class Person // Sets 'Person' class as abstract
    {
        public string FirstName { get; set; } // Defines string property 'FirstName'
        public string LastName { get; set; } // Defines string property 'LastName'

        public abstract void SayName(); // Creates abstract method called 'SayName' 

    }
}
