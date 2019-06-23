using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_LINQ_demo
{
    class GroupReport
    {
        public string Name;
        public int StudentsCount;
        public double StudentsAvgScore;

        public override string ToString()
        {
            return $"Name: {Name}, StudentsCount: {StudentsCount}, StudentsAvgScore: {StudentsAvgScore}";
        }
    }
}
