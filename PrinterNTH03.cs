using System;
using System.Reflection.Metadata;

namespace PrinterDriver
{
    public class PrinterNTH03 : Printer, ISingleSidePrint, IDoubleSidePrint, IFaxPrinter
    {
        public void PrintDoubleSide(string text)
        {
            Console.WriteLine($"Printer NTH03: Printing double-side {text}");
        }

        public void PrintSingleSide(string text)
        {
            Console.WriteLine($"Printer NTH03: Printing single-side {text} ");
        }

        public void Scan(string document)
        {
            Console.WriteLine($"Printer NTH03: Scaning....  {document} ");
        }

        public void SendFax(string text)
        {
            Console.WriteLine($"Printer NTH03: Fax....{text}  ");
        }
    }
}

