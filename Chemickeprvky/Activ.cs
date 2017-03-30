using System;
using SQLite;

namespace Chemickeprvky
{
	public class Activ
	{
		[PrimaryKey]
		public int AtomicNumber { get; set; }
		public bool Active { get; set; }

		public override string ToString()
		{
			return AtomicNumber + " " + Active;
		}
	}
}
