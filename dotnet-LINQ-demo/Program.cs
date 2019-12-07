using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

            // 2
            /*List<Student> students = new List<Student>() {
                new Student(){id = 3, firstName = "A1", lastName = "B10", age = 18, avgScore = 9.5 },
                new Student(){id = 1, firstName = "A5", lastName = "B1", age = 20, avgScore = 10.5 },
                new Student(){id = 5, firstName = "A4", lastName = "B100", age = 18, avgScore = 8 },
                new Student(){id = 5, firstName = "A4", lastName = "B0", age = 18, avgScore = 8 }
            };

            // var result = students.OrderBy((s) => s.firstName).ThenBy((s) => s.lastName);

            var students2 = students.Select((s) => new { Id = s.id, Name = $"{s.firstName} {s.lastName}" }).ToList();

            foreach (var item in students2)
            {
                Console.WriteLine(item);
            }*/

            // 3
            List<Group> groups = new List<Group>() {
                new Group(){Id = 30, Name = "PSV 30-18" },
                new Group(){Id = 12, Name = "PPV 30-18" }
            };

            List<Student2> students = new List<Student2>() {
                new Student2(){id = 3, firstName = "A1", lastName = "B10", age = 18, avgScore = 9.5, groupId = 30 },
                new Student2(){id = 1, firstName = "A5", lastName = "B1", age = 20, avgScore = 10.5, groupId = 12 },
                new Student2(){id = 5, firstName = "A4", lastName = "B100", age = 18, avgScore = 8, groupId = 30 },
                new Student2(){id = 4, firstName = "A7", lastName = "B2", age = 19, avgScore = 8, groupId = 12 },
                new Student2(){id = 6, firstName = "A9", lastName = "B3", age = 18, avgScore = 8.5, groupId = 13 }
            };

            /*var result = students.GroupBy((s) => s.groupId).Select(
                (gr) => new {
                        GroupName = groups.Where((g) => g.Id == gr.Key).SingleOrDefault()?.Name ?? "Unknown Group",
                        StudentsCount = gr.Count(),
                        StudentsAvgScore = gr.Average((s) => s.avgScore)
                    }
                );

            foreach (var item in result)
            {
                Console.WriteLine(item);
                // Console.WriteLine("g");
            }*/
            // На входе - две группы, на выходе - два списка студентов этих групп
            /*var result = groups.Select((g) => students.Where((s) => s.groupId == g.Id)).Aggregate(
                // Инициализация выходного объекта
                new List<GroupReport>(),
                // Обработка каждого входного элемента,
                // reports - аккумулятор (выходной объект)
                // groupStudents - список студентов, входящих в одну группу
                (reports, groupStudents) => {
                    GroupReport report = new GroupReport();
                    report.Name = groups.Where((g) => g.Id == groupStudents.FirstOrDefault().groupId).SingleOrDefault().Name;
                    report.StudentsCount = groupStudents.Count();
                    report.StudentsAvgScore = groupStudents.Average((s) => s.avgScore);
                    reports.Add(report);
                    return reports;
                },
                (reports) => { return reports; }
                );*/
            Console.WriteLine("Loading 1 ...");
            groups.ForEach(Console.WriteLine);
            
            Console.WriteLine("***");
            groups.AsParallel().ForAll((g) => Console.WriteLine(g));
            Console.WriteLine("Loading 2 ...");

            /*foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/
            //Console.WriteLine(result);

            short x = short.Parse("100500000");
            int x1 = 100500000;
        }
    }
}
