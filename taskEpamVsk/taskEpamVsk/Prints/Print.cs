using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskEpamVsk.Prints
{
    abstract class Print
    {
        public Print(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

    }
}
