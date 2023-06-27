using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
  class Program
  { async static Task Main()
    {
      // Call the GetEmployees method
      // List<Employee> employees = new List<Employee>();
      List<Employee> employees = PeopleFetcher.ApiQuestion() ? await PeopleFetcher.GetFromApi() : PeopleFetcher.GetEmployees();
      Util.MakeCSV(employees);
      await Util.MakeBadges(employees);
    }
  }
}


