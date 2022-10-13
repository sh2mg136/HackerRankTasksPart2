using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualizeTheArray
{
    [DebuggerDisplay("{Company}. {FirstName} {LastName} ({Age})")]
    internal class Employee
    {
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public int Age { get; set; }
        public string Company { get; set; } = String.Empty;

        public override string ToString()
        {
            return $"{Company}. {FirstName} {LastName} ({Age})";
        }
    }
}
