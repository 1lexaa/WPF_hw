using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2109hw
{
    public class ResumeObject
    {
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Occupation { get; set; }
        public string? Skills { get; set; }
        public string? Languages { get; set; }
        public string? Experience { get; set; }
        public string? AboutMe { get; set; }
        public string? Education { get; set; }
        public string? Contacts { get; set; }
        public string? GitHub { get; set; }
        public string? LinkedIn { get; set; }
        public string? PhotoPath { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
