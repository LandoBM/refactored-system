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
        Console.WriteLine("Please Enter First Name: (leave empty to exit): ");
        // Get a name from the Console and assign it to a variable
        string firstName = Console.ReadLine() ?? "";
        if (firstName == "") 
        {
          break;
        }
        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine() ?? " ";
        Console.Write("Enter ID: ");
        int id = Int32.Parse(Console.ReadLine() ?? " ");
        Console.Write("Enter Photo URL: ");
        string photoUrl = Console.ReadLine() ?? " ";
        // Created a new Employee Instance
        Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
        employees.Add(currentEmployee);
      }
      // Return Employees
      return employees;
    }

    // Method to Print Employees Name in list
    // static void PrintEmployees(List<Employee> employees)
    // {
    //   // Loop through the List<Employee>
    //   for (int i = 0; i < employees.Count; i++)
    //   {
    //     string template = "{0,-10}\t{1,-20}\t{2}";
    //     // each item in employee is now an Employee Instance
    //       Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
    //   }
    // }

    static void Main()
    {
      // Call the GetEmployees method
      List<Employee> employees = GetEmployees();
      // Call the PrintEmployees method
      Util.PrintEmployees(employees);
      Util.MakeCSV(employees);
    }
  }
}


