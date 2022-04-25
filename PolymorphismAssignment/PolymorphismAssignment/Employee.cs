using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Employee : Person, IQuittable // Employee class inherits from 'Person' class, and 'IQuittable' interface
    {
        public override void SayName() // Instantiates SayName from abstract class Person
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // Displays values of properties to user
        }

        public void Quit() // Instantiates Quit from interface IQuittable
        {
            // Displays message to user
            Console.WriteLine(FirstName + " " + LastName + " slaps their resignation letter on the desk!");
            Console.WriteLine(FirstName + ": \"I'm outta here, man!!!\"");
            Console.WriteLine(FirstName + " " + LastName + " has quit their job!");
        }
    }
}
