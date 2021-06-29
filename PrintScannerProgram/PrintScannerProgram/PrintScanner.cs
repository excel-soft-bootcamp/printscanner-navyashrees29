using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerProgram
{
    public class PrintScanner
    {
        IPrinter _printer;
        IScanner _scanner;

        public PrintScanner(IPrinter printer,IScanner scanner)
        {
            this._printer = printer;
            this._scanner = scanner;
        }
        public void PrintScan()
        {
            _printer.Print();
            _scanner.Scan();
        }


 /*       public PrintScanner(IPrinter printer)
        {
            this._printer = printer;
        }
        public void PrintOnly()
        {
            _printer.Print();
        }

        public PrintScanner(IScanner scanner)
        {
            this._scanner = scanner;
        }
        public void ScanOnly()
        {
            _scanner.Scan();
        }
*/

    }
}
