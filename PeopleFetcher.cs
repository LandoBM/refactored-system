// Import correct packages
using System;
// Package for Directory
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
// convert string to JSON
using Newtonsoft.Json.Linq;

namespace  CatWorx.BadgeMaker 
{
  class PeopleFetcher 
  {
    public static Boolean ApiQuestion()
    {
        Console.Write(" Would you like to auto generate Employees? \n Enter 'True' or 'False': ");
        bool Gen = Convert.ToBoolean(Console.ReadLine());
        return Gen;
    }
    public static List<Employee> GetEmployees()
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
    async public static Task <List<Employee>> GetFromApi() 
    {
        List<Employee> employees = new List<Employee>();

        // instance of HttpClient is disposed after code in the block has run
        using(HttpClient client = new HttpClient())
        {   //Download string from random user api
            string response = await client.GetStringAsync("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
            JObject json = JObject.Parse(response);
            // (!) tells the complier that this expression is not null
            // Loop through each token in api response results
            foreach (JToken person in json.SelectToken("results")!) 
            {
                // Parse JSON data
                Employee emp = new Employee
                (
                    // "token" is a new JObject derived from "results[i]"
                    person.SelectToken("name.first")!.ToString(),
                    person.SelectToken("name.last")!.ToString(),
                    Int32.Parse(person.SelectToken("id.value")!.ToString().Replace("-", "")),
                    person.SelectToken("picture.large")!.ToString()
                );
                employees.Add(emp);
            }
        }
        return employees;
    }
  }
}