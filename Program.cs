using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  { // Method to get the employees
    static List<string> GetEmployees()
    {
      // I will return a List of strings
      List<string> employees = new List<string>();
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
        employees.Add(input);
      }
      // Return Employees
      return employees;
    }

    // Method to Print Employees Name in list
    static void PrintEmployees(List<string> employees)
    {
      // Loop through the List<string>
      for (int i = 0; i < employees.Count; i++)
      {
        // Print the value of the List<string> at the current index
        Console.WriteLine(employees[i]);
      }
    }

    static void Main()
    {
      // Call the GetEmployees method
      List<string> employees = GetEmployees();
      // Call the PrintEmployees method
      PrintEmployees(employees);
    }
  }
}


