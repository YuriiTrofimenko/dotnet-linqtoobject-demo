using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_LINQ_demo
{
    class Group
    {
        public int Id;
        public string Name;

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
