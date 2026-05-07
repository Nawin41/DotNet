using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Employee> empList = EmployeeData.GetEmployees();

        // 1. Joined before 1/1/2015
        var q1 = empList.Where(e => e.DOJ < new DateTime(2015, 1, 1));

        // 2. DOB after 1/1/1990
        var q2 = empList.Where(e => e.DOB > new DateTime(1990, 1, 1));

        // 3. Consultant and Associate
        var q3 = empList.Where(e => e.Title == "Consultant" || e.Title == "Associate");

        // 4. Total employees
        int total = empList.Count();

        // 5. Chennai employees
        int chennai = empList.Count(e => e.City == "Chennai");

        // 6. Highest ID
        int maxId = empList.Max(e => e.EmployeeID);

        // 7. Joined after 1/1/2015
        int after2015 = empList.Count(e => e.DOJ > new DateTime(2015, 1, 1));

        // 8. Not Associate
        int notAssociate = empList.Count(e => e.Title != "Associate");

        // 9. Group by City
        var groupCity = empList.GroupBy(e => e.City)
                               .Select(g => new { City = g.Key, Count = g.Count() });

        // 10. Group by City & Title
        var groupCityTitle = empList.GroupBy(e => new { e.City, e.Title })
            .Select(g => new { g.Key.City, g.Key.Title, Count = g.Count() });

        // 11. Youngest employee
        var youngest = empList.OrderByDescending(e => e.DOB).First();

        // ✅ SAMPLE OUTPUT
        Console.WriteLine("Total Employees: " + total);
        Console.WriteLine("Chennai Employees: " + chennai);
        Console.WriteLine("Max ID: " + maxId);
        Console.WriteLine("Youngest: " + youngest.FirstName);

        Console.ReadLine();
    }
}