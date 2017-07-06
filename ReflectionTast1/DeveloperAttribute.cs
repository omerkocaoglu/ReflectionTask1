using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTast1
{
    [AttributeUsage(AttributeTargets.Method)]
    public class DeveloperAttribute:Attribute
    {
        public string Name { get; set; }
        public DeveloperAttribute(string Name)
        {
            this.Name = Name;
        }
    }
}
