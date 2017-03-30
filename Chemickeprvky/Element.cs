using System;
using SQLite;

namespace Chemickeprvky
{
	public class Element
	{

		public int AtomicNumber { get; set; }
		public string Symbol { get; set; }
		public string Name { get; set; }
		public string CzechName { get; set; }
		public bool Active() { 
			//vytvoření spojení s db
			var dbConnection = App.Database;
			//db věcí
			Database items = App.Database;

			return App.Database.GetActiv(AtomicNumber);
		}

		public Element(int atomicNumber, string symbol, string name, string czechName)
		{
			AtomicNumber = atomicNumber;
			Symbol = symbol;
			Name = name;
			CzechName = czechName;

		}
		public override string ToString()
		{
			return AtomicNumber + " " + Symbol + " " + Name +" "+ CzechName;
		}

	}
}
