using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using SQLite;

namespace Chemickeprvky
{
	public class Element
	{
		
		public int AtomicNumber { get; set; }
		public string Symbol { get; set; }
		public string Name { get; set; }
		public string CzechName { get; set; }

		public Element(int atomicNumber, string symbol, string name, string czechName)
		{
			AtomicNumber = atomicNumber;
			Symbol = symbol;
			Name = name;
			CzechName = czechName;
		}

		/// <summary>
        /// Text representation of element
        /// </summary>
        /// <returns>String of all value</returns>
		public override string ToString()
		{
			return AtomicNumber + " " + Symbol + " " + Name +" "+ CzechName;
		}

		/// <summary>
        /// Return true if element is active
        /// </summary>
        /// <returns>true if enable, else false</returns>
		public bool isActive
		{
			get
			{
				return App.Database.GetIsActiv(id: AtomicNumber);
			}
		}

		/// <summary>
		/// Return string if element is active
		/// </summary>
		/// <returns>Return "Aktivní" if isActive() return true else "Neaktivní"</returns>
		public string isActiveString
		{
			get
			{
				if (isActive)
				{
					return "Aktivní";
				}
				return "Neaktivní";
			}
		}
	}

    /// <summary>
    /// Helper class to group elements
    /// </summary>
    public class ElementGroup : ObservableCollection<Element>
	{
        public string Heading { get; set; }
    }
}
