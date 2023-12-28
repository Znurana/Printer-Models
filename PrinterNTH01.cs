using System;
using static System.Net.Mime.MediaTypeNames;

namespace PrinterDriver
{
    public class PrinterNTH01 : Printer, ISingleSidePrint
    {
        public void PrintSingleSide(string text)
        {
            Console.WriteLine($"Printer NTH01: Printing single-side {text} ");
        }


        public void Scan(string document)
        {
            Console.WriteLine($"Printer NTH01: Scaning....  {document} ");
        }
    }

}

