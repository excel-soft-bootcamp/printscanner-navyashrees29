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
            Printer printer = new Printer();
            Scanner scanner = new Scanner();

            PrintManager printManager = new PrintManager();
            printManager.PrintDocument();

            ScanManager scanManager = new ScanManager();
            scanManager.ScanDocument();
        
            PrintScanner printScan = new PrintScanner(printManager, scanManager);
            printScan.PrintScan();

        /*    PrintScanner print = new PrintScanner(printManager);
            print.PrintOnly();

            PrintScanner scan = new PrintScanner(scanManager);
            print.ScanOnly();
        */
        }
    }
}
