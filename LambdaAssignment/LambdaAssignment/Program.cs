using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>(); // Creates new Employee list called 'emplist'
            empList.Add(new Employee(27, "Joe", "Hill")); // Adds new 'Employee' to list with required parameters
            empList.Add(new Employee(394, "Severus", "Snape")); // Adds new 'Employee' to list with required parameters
            empList.Add(new Employee(19, "Roland", "Deschain")); // Adds new 'Employee' to list with required parameters
            empList.Add(new Employee(777, "Raziel", "Yewande")); // Adds new 'Employee' to list with required parameters
            empList.Add(new Employee(03, "Joe", "Blow")); // Adds new 'Employee' to list with required parameters
            empList.Add(new Employee(489, "Ron", "Obvious")); // Adds new 'Employee' to list with required parameters
            empList.Add(new Employee(7, "Richard", "Nixon")); // Adds new 'Employee' to list with required parameters
            empList.Add(new Employee(324, "The", "Doctor")); // Adds new 'Employee' to list with required parameters
            empList.Add(new Employee(42, "Barbara", "Salmon")); // Adds new 'Employee' to list with required parameters
            empList.Add(new Employee(222, "Ralph", "Morales")); // Adds new 'Employee' to list with required parameters

            List<Employee> joeList = new List<Employee>(); // Creates a new Employee list called 'joeList'

            foreach (Employee emp in empList) // Foreach loop to parse through all objects in empList
            {
                if (emp.FirstName == "Joe") // If statement to catch all objects where FirstName == Joe
                {
                    joeList.Add(emp); // Adds object to 'joeList'
                }
            }

            foreach (Employee joe in joeList) // Foreach loop to parse through all objects in joeList
            {
                Console.WriteLine(joe.Id + " " + joe.FirstName + " " + joe.LastName); // Displays the objects in list to user to show function works
            }

            Console.WriteLine("\n"); // Creates new line in display to make it easier for user to see results

            // Lambda func that creates new list 'joe2List', parses empList for objects where FirstName == Joe, then adds objects to new list
            List<Employee> joe2List = empList.Where(x => x.FirstName == "Joe").ToList(); 
            foreach (Employee joe in joe2List) // Foreach loop to parse objects in joe2List 
            {
                Console.WriteLine(joe.Id + " " + joe.FirstName + " " + joe.LastName); // Displays the objects in list to user to show function works
            }

            Console.WriteLine("\n"); // Creates new line in display to make it easier for user to see results

            // Lambda func that creates new list 'sixPlusList', parses empList for objects where Id > 5, then adds objects to new list
            List<Employee> sixPlusList = empList.Where(x => x.Id > 5).ToList();
            foreach (Employee emp in sixPlusList) // Foreach loop to parse objects in sixPlusList
            {
                Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName); // Displays the objects in list to user to show function works
            }

            Console.ReadLine(); // Prevents program from terminating immediately
        }


    }
}
