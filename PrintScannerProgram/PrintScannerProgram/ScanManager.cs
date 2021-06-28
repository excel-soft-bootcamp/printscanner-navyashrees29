using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerProgram
{
    public class ScanManager : IScanner
    {
        public void Scan()
        {
            Console.WriteLine("Scan In Action");
        }
    /*    public void ScanDocument(Scanner scaner)
        {
            scaner.Scan();
        }*/
    }
}
