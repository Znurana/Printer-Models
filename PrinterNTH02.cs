using System;
namespace PrinterDriver
{
    public class PrinterNTH02 : Printer, ISingleSidePrint, IDoubleSidePrint
    {
        public void PrintDoubleSide(string text)
        {
            Console.WriteLine($"Printer NTH02: Printing double-side { text}");
        }

        public void PrintSingleSide(string text)
        {
            Console.WriteLine($"Printer NTH02: Printing single-side {text} ");
        }

        public void Scan(string document)
        {
            Console.WriteLine($"Printer NTH02: Scaning.....  {document} ");
        }
    }
}

