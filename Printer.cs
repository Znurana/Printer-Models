using System;
namespace PrinterDriver
{
	public class Printer // abstract class ede bilerdin ki instance yaratmaq olmasin 
	{
		public int Id { get; set; }
		public string Model { get; set; }

		public Printer(int _id,string _model)
		{
			this.Id = _id;
			this.Model = _model;
		}

		public Printer()
		{

		}

	}
}

