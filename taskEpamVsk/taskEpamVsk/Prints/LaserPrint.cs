using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskEpamVsk.Prints
{
    class LaserPrint : Print
    {
        public LaserPrint(string name) : base (name)
        {
            Console.WriteLine("Выполнена лазерная печать файла " + name);
        }

    }
}
