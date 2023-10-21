using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Student
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }


        public override string ToString()
        {
            return $"{Name} {Lastname} {Age}";
        }
    }
}
