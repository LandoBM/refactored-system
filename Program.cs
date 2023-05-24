using System;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    // Main is the Entry Point
    static void Main ()
    {
        // using System.Collections.Generic;


        // Using Dictionaries
        // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
        //     { "firstInning", 10 },
        //     { "secondInning", 20},
        //     { "thirdInning", 30},
        //     { "fourthInning", 40},
        //     { "fifthInning", 50}
        // };

        // Populate the Dictionary 
        // Console.WriteLine("----------------");
        // Console.WriteLine("  Scoreboard");
        // Console.WriteLine("----------------");
        // Console.WriteLine("Inning |  Score");
        // Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
        // Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
        // Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
        // Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
        // Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);


        // Arrays
        // string[] favFoods = new string[3]{ "pizza", "doughnuts", "icecream" };
        // string firstFood = favFoods[0];
        // string secondFood = favFoods[1];
        // string thirdFood = favFoods[2];
        // Declare Array
        // Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);



        // List 
        List<string> employees = new List<string>() { "adam", "amy" };

        employees.Add("barbara");
        employees.Add("billy");

        // Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);
        // For Loops for employee list using C#
        for (int i = 0; i < employees.Count; i++) 
        {
            Console.WriteLine(employees[i]);
        }
    }
  }
}


