using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee : Person // Employee class inherits from 'Person' class
    {
        public int Id { get; set; } // Defines int property 'Id'

        public override void SayName() // Instantiates SayName from abstract class Person
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // Displays values of properties to user
        }

        public static bool operator== (Employee emp1, Employee emp2) // Overrides '==' operator with two parameters
        {
            return emp1.Id == emp2.Id; // Checks if two employee 'Id' values match and returns result
        }

        public static bool operator!= (Employee emp1, Employee emp2) // Overrides '!=' operator with two parameters, required to override '==' operator
        {
            return emp1.Id != emp2.Id; // Checks if two employee 'Id' values do not match and returns result
        }
    }
}
