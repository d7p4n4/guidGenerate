using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guidGenerate
{
    [AttributeUsage(AttributeTargets.All)]
    class GUID :  Attribute
    {
        private string Guid;

        public GUID(string value)
        {
            this.Guid = value;
        }

        public string getGuid()
        {
            return Guid;
        }
    }
}
