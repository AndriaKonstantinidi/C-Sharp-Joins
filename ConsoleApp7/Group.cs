using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Group
    {
        public string Groupname { get; set; }
        public int GroupId { get; set; }

        public override string ToString()
        {
            return $"{Groupname}";
        }
    }
}
