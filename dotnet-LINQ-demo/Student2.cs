using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_LINQ_demo
{
    class Student2
    {
        public int id;
        public string firstName;
        public string lastName;
        public int age;
        public double avgScore;
        public int groupId;

        public override string ToString()
        {
            return $"firstName: {firstName}, lastName: {lastName}";
        }
    }
}
