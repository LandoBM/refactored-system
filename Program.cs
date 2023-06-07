using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  { // Method to get the employees
    static List<Employee> GetEmployees()
    {
      // I will return a List of strings
      List<Employee> employees = new List<Employee>();
      // Collect user values until the value is an empty string
      while (true)
      {
        Console.WriteLine("Please Enter a Name: (leave empty to exit): ");
        // Get a name from the Console and assign it to a variable
        string input = Console.ReadLine() ?? "";
        if (input == "") 
        {
          break;
        }
        // Created a new Employee Instance
        Employee currentEmployee = new Employee(input, "Smith");
        employees.Add(currentEmployee);
      }
      // Return Employees
      return employees;
    }

    // Method to Print Employees Name in list
    static void PrintEmployees(List<Employee> employees)
    {
      // Loop through the List<Employee>
      for (int i = 0; i < employees.Count; i++)
      {
        // each item in employee is now an Employee Instance
        Console.WriteLine(employees[i].GetFullName());
      }
    }

    static void Main()
    {
      // Call the GetEmployees method
      List<Employee> employees = GetEmployees();
      // Call the PrintEmployees method
      PrintEmployees(employees);
    }
  }
}


