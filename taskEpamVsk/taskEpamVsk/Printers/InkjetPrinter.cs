using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskEpamVsk.Prints;

namespace taskEpamVsk.Printers
{
    class InkjetPrinter : Printer
    {
        public InkjetPrinter(string name) :base (name)
        { }
        public override Print Publish(string nameFile)
        {
            return new InkjetPrint(nameFile);
        }
    }
}
