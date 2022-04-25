using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person // Employee class inherits from 'Person' class
    {
        public override void SayName() // Instantiates SayName from abstract class Person
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // Displays values of properties to user
        }
    }
}
