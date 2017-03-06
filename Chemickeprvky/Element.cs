using System;
namespace Chemickeprvky
{
	public class Element
	{
		public int AtomicNumber { get; set; }
		public string Symbol { get; set; }
		public string Name { get; set; }
		public string CzechName { get; set; }
		public bool Activ { get; set; }

		public Element(int atomicNumber, string symbol, string name, string czechName, bool activ)
		{
			AtomicNumber = atomicNumber;
			Symbol = symbol;
			Name = name;
			CzechName = czechName;
			Activ = activ;
		}
	}
}
