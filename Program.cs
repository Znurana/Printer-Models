namespace PrinterDriver;

class Program
{
    static void Main(string[] args)
    {
       //Interface Segregation
        PrinterNTH01 printerNTH01 = new PrinterNTH01();
        Console.WriteLine("PrinterNTH01 Operation is starting ....");
        printerNTH01.PrintSingleSide("Dummy Text");
        printerNTH01.Scan("Dummy Text");

        Console.WriteLine("------------------------------------");

        PrinterNTH02 nth02Printer = new PrinterNTH02();
        Console.WriteLine("PrinterNTH02 Operation is starting ....");
        nth02Printer.PrintSingleSide(" Dummy Text ");
        nth02Printer.PrintDoubleSide("Sample Document");
        nth02Printer.Scan("Dummy Text");

        Console.WriteLine("------------------------------------");

        PrinterNTH03 printerNTH03 = new PrinterNTH03();
        Console.WriteLine("PrinterNTH03 Operation is starting ....");
        printerNTH03.Scan("Document");
        printerNTH03.PrintSingleSide("Dummy Text");
        printerNTH03.PrintDoubleSide("Dummy Text");
        printerNTH03.SendFax("Dummy Text");


    }
}

