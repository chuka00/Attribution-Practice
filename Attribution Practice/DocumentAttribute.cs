using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribution_Practice
{
    [AttributeUsage(AttributeTargets.All)]
    public class DocumentAttribute : Attribute
    {
        public string Description { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }

        public DocumentAttribute(string description)
        {
            Description = description;
        }
    }

}
