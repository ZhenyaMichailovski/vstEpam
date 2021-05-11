using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskEpamVsk.Prints
{
    class InkjetPrint : Print
    {
        public InkjetPrint(string name) : base(name)
        {
            Console.WriteLine("Выполнена струйная печать файла " + name);
        }
    }
}
