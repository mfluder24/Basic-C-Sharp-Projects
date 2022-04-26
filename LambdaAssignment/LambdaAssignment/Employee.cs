using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    public class Employee : Person
    {
        public Employee(int Id, string FirstName, string LastName) // Defines Employee and provides parameters
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public int Id { get; set; } // Defines int property 'Id'

        public override void SayName() // Instantiates SayName from abstract class Person
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // Displays values of properties to user
        }
    }
}
