using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskEpamVsk.Prints;

namespace taskEpamVsk.Printers
{
    abstract class Printer
    {
        public Printer(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        abstract public Print Publish(string nameFile);
    }
}
