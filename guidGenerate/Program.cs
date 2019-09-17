using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace guidGenerate
{
    class Program
    {
        public static void Main(string[] args)
        {
            InsertGuid.searchForGuid(typeof(Person), "Person", "Person");

        }
    }
}
