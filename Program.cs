using System;
using System.Collections.Generic;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            
            var Prestige = new Company("Prestige Worldwide", DateTime.Now);  

        // Create three employees

        //object initialization 
            var Johnny = new Employee()
            {
                FirstName = "John",
                LastName = "Jacobson",
                Title = "CFO",
                StartDate = DateTime.Now
            };
            Employee Shakey = new Employee()
            {
                FirstName = "Shakey Graves",
                LastName = "Gibson",
                Title = "CEO",
                StartDate = DateTime.Now
            };
            Employee Marbles = new Employee()
            {
                FirstName = "Marbles",
                LastName = "Mozambique",
                Title = "CTO",
                StartDate = DateTime.Now
            };

        // Assign the employees to the company
            Prestige.Employees.Add(Johnny);
            Prestige.Employees.Add(Shakey);
            Prestige.Employees.Add(Marbles);

            // Console.WriteLine($"{Prestige.Employees[0].FirstName}");
            Prestige.ListEmployees();






        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
         }
    }
};

