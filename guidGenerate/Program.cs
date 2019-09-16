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

            PropertyInfo[] prop = typeof(Person).GetProperties();
            Attribute classAttr = typeof(Person).GetCustomAttribute(typeof(GUID), false);

            if (classAttr != null)
            {
                Console.WriteLine("true");
            } else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine(prop.Length);

            Object[] attrs = prop[0].GetCustomAttributes(typeof(GUID), false);
            Console.WriteLine(prop[0].Name);

            //Console.WriteLine(attrs[0].GetType());

            string text = InsertGuid.searchForGuid(typeof(Person), "Person", "Person");

        }
    }
}
