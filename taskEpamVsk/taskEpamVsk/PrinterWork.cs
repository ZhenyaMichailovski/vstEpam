using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskEpamVsk.Printers;
using taskEpamVsk.Prints;

namespace taskEpamVsk
{
    static class PrinterWork
    {
        public static void Work()
        {
            Printer laserPrinter = new LaserPrinter("HP LaserJet Pro M104w");
            Printer matrixPrinter = new MatrixPrinter("Epson LX-350");
            Printer inkjetPrinter = new InkjetPrinter("HP Ink Tank 115");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("На ваш выбор предоставляется 3 вида принтеров: ");
                Console.WriteLine("1) Принтер лазерной печати " + laserPrinter.Name);
                Console.WriteLine("2) Принтер матричной печати " + matrixPrinter.Name);
                Console.WriteLine("3) Принтер струйной печати " + inkjetPrinter.Name);
                Console.WriteLine("4) Выход.");
                Console.Write("Выберите каким хотите воспользоваться: ");
                int printer = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите имя файла который хотите напечатать: ");
                string nameFile = Console.ReadLine();
                switch (printer)
                {
                    case 1:
                        Console.Clear();
                        laserPrinter.Publish(nameFile);
                        break;
                    case 2:
                        Console.Clear();
                        matrixPrinter.Publish(nameFile);
                        break;
                    case 3:
                        Console.Clear();
                        inkjetPrinter.Publish(nameFile);
                        break;
                    case 4:
                        Console.Clear();
                        flag = false;
                        Console.WriteLine("До свидания!");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
