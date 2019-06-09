using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_LINQ_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            /*List<string> strings = new List<string>() {
                "123",
                "ABC",
                "DEF",
                "XYZ",
                "A",
                "C",
                "B",
                "-10"
            };*/

            // var result = strings.OrderBy((s) => s);
            // var result = strings.OrderBy((s) => s).ToList();
            // var result = strings.OrderByDescending((s) => s).ToList();

            /* var result =
               strings
               .Take(3)
               .Skip(1)
               .ToList(); */

            /* var result =
                strings
                .Where((s) => s.Length > 10)
                //.First();
                .FirstOrDefault(); */

            /*var result =
                strings
                .Where((s) => s.StartsWith("-"))
                .SingleOrDefault();

            Console.WriteLine(result);*/

            /*Console.WriteLine(result.GetType().Name);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/

            //2
            List<Student> strings = new List<Student>() {
                new Student(){id = 3, firstName = "A1", lastName = "B10", age = 18, avgScore = 9.5 },
                new Student(){id = 1, firstName = "A5", lastName = "B1", age = 20, avgScore = 10.5 },
                new Student(){id = 5, firstName = "A4", lastName = "B100", age = 18, avgScore = 8 },
                new Student(){id = 5, firstName = "A4", lastName = "B0", age = 18, avgScore = 8 }
            };

            var result = strings.OrderBy((s) => s.firstName).ThenBy((s) => s.lastName);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
