using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {
        public Company(string name, DateTime CreatedOn)
        {
            Name = name;
            CreatedOn = createdOn;
            Employees = new List<Employee>();
        }

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime createdOn { get; }

        // Create a public property for holding a list of current employees     
         
        public List<Employee> Employees { get; set; }

        public void ListEmployees()
        {
            foreach(Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as a {employee.Title} since {employee.StartDate}");
            }
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
            The constructor will set the value of the public properties
        */
       
    }
}