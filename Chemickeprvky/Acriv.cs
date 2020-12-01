using System;
using SQLite;

namespace Chemickeprvky
{
	public class Activ
	{
		[PrimaryKey]
		public int AtomicNumber { get; set; }
		public bool Active { get; set; }

		/// <summary>
		/// Text representation of activ
		/// </summary>
		/// <returns>String of all value</returns>
		public override string ToString()
		{
			return AtomicNumber + " " + Active;
		}
	}
}