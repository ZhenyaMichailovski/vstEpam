using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskEpamVsk.Prints
{
    class MatrixPrint : Print
    {
        public MatrixPrint(string name) : base (name)
        {
            Console.WriteLine("Выполнена матричная печать файла " + name);
        }
    }
}
