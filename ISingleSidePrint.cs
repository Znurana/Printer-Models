using System;
namespace PrinterDriver
{
	public interface ISingleSidePrint
	{
        void PrintSingleSide(string text);
        void Scan(string document);
    }
}

