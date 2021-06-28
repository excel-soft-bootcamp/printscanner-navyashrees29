using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintManager printManager = new PrintManager();
            ScanManager scanManager = new ScanManager();
            PrintScanner printScan = new PrintScanner(printManager, scanManager);
            printScan.PrintScan();
       }
    }
}
