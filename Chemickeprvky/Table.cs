using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chemickeprvky
{
	public class Table
	{
		
		//Function to get random number
		private static readonly Random random = new Random();
		private static readonly object syncLock = new object();
		public static int RandomNumber(int min, int max)
		{
			lock (syncLock)
			{ // synchronize
				return random.Next(min, max);
			}
		}

		public Element getElement()
		{
			List<Element> Elements = getPeriodicTable();
			int num = RandomNumber(1, 118);
			return Elements[num];

		}

		public Element getTrueElement()
		{
			List<Element> Elements = getPeriodicTable();
			int num = RandomNumber(0, 118);

			//vytvoření spojení s db
			var dbConnection = App.Database;
			//db věcí
			Database items = App.Database;

			if (App.Database.GetActiv(num) == false)
			{
				getTrueElement();
			}
			return Elements[num];

		}

		public List<Element> getPeriodicTable()
		{
			List<Element> Elements = new List<Element>();
			Elements.Add(new Element(1, "H", "Hydrogen", "Vodík"));
			Elements.Add(new Element(2, "He", "Helium", "Helium"));
			Elements.Add(new Element(3, "Li", "Lithium", "Lithium"));
			Elements.Add(new Element(4, "Be", "Beryllium", "Belirium"));
			Elements.Add(new Element(5, "B", "Boron", "Bór"));
			Elements.Add(new Element(6, "C", "Carbon", "Uhlík"));
			Elements.Add(new Element(7, "N", "Nitrogen", "Dusík"));
			Elements.Add(new Element(8, "O", "Oxygen", "Kislík"));
			Elements.Add(new Element(9, "F", "Fluorine", "Fluor"));
			Elements.Add(new Element(10, "Ne", "Neon", "Neon"));
			Elements.Add(new Element(11, "Na", "Sodium", "Sodík"));
			Elements.Add(new Element(12, "Mg", "Magnesium", "Hořčík"));
			Elements.Add(new Element(13, "Al", "Aluminum", "Hliník"));
			Elements.Add(new Element(14, "Si", "Silicon", "Křemík"));
			Elements.Add(new Element(15, "P", "Phosphorus", "Fosfor"));
			Elements.Add(new Element(16, "S", "Sulphur", "Síra"));
			Elements.Add(new Element(17, "Cl", "Chlorine", "Chlor"));
			Elements.Add(new Element(18, "Ar", "Argon", "Argon"));
			Elements.Add(new Element(19, "K", "Potassium", "Draslík"));
			Elements.Add(new Element(20, "Ca", "Calcium", "Vápník"));
			Elements.Add(new Element(21, "Sc", "Scandium", "Skandium"));
			Elements.Add(new Element(22, "Ti", "Titanium", "Titan"));
			Elements.Add(new Element(23, "V", "Vanadium", "Vanad"));
			Elements.Add(new Element(24, "Cr", "Chromium", "Chrom"));
			Elements.Add(new Element(25, "Mn", "Manganese", "Mangan"));
			Elements.Add(new Element(26, "Fe", "Iron", "Železo"));
			Elements.Add(new Element(27, "Co", "Cobalt", "Kobalt"));
			Elements.Add(new Element(28, "Ni", "Nickel", "Nikl"));
			Elements.Add(new Element(29, "Cu", "Copper", "Měď"));
			Elements.Add(new Element(30, "Zn", "Zinc", "Zinek"));
			Elements.Add(new Element(31, "Ga", "Gallium", "Galium"));
			Elements.Add(new Element(32, "Ge", "Germanium", "Germanium"));
			Elements.Add(new Element(33, "As", "Arsenic", "Arsen"));
			Elements.Add(new Element(34, "Se", "Selenium", "Selen"));
			Elements.Add(new Element(35, "Br", "Bromine", "Bróm"));
			Elements.Add(new Element(36, "Kr", "Krypton", "Krypton"));
			Elements.Add(new Element(37, "Rb", "Rubidium", "Rubium"));
			Elements.Add(new Element(38, "Sr", "Strontium", "Stroncium"));
			Elements.Add(new Element(39, "Y", "Yttrium", "Yttrium"));
			Elements.Add(new Element(40, "Zr", "Zirconium", "Zircon"));
			Elements.Add(new Element(41, "Nb", "Niobium", "Niob"));
			Elements.Add(new Element(42, "Mo", "Molybdenum", "Molibden"));
			Elements.Add(new Element(43, "Tc", "Technetium", "Technecium"));
			Elements.Add(new Element(44, "Ru", "Ruthenium", "Rubuídium"));
			Elements.Add(new Element(45, "Rh", "Rhodium", "Rhodikum"));
			Elements.Add(new Element(46, "Pd", "Palladium", "Palladikum"));
			Elements.Add(new Element(47, "Ag", "Silver", "Atříbro"));
			Elements.Add(new Element(48, "Cd", "Cadmium", "Kadmium"));
			Elements.Add(new Element(49, "In", "Indium", "Idium"));
			Elements.Add(new Element(50, "Sn", "Tin", "Cín"));
			Elements.Add(new Element(51, "Sb", "Antimony", "Antinon"));
			Elements.Add(new Element(52, "Te", "Tellurium", "Tellur"));
			Elements.Add(new Element(53, "I", "Iodine", "Iod"));
			Elements.Add(new Element(54, "Xe", "Xenon", "Xenon"));
			Elements.Add(new Element(55, "Cs", "Cesium", "Cesium"));
			Elements.Add(new Element(56, "Ba", "Barium", "Barium"));
			Elements.Add(new Element(57, "La", "Lanthanum", "Lanthan"));
			Elements.Add(new Element(58, "Ce", "Cerium", "Car"));
			Elements.Add(new Element(59, "Pr", "Praseodymium", "Praseodym"));
			Elements.Add(new Element(60, "Nd", "Neodymium", "Neodym"));
			Elements.Add(new Element(61, "Pm", "Promethium", "Promethium"));
			Elements.Add(new Element(62, "Sm", "Samarium", "Samarium"));
			Elements.Add(new Element(63, "Eu", "Europium", "Europium"));
			Elements.Add(new Element(64, "Gd", "Gadolinium", "Gadolinium"));
			Elements.Add(new Element(65, "Tb", "Terbium", "Tarbium"));
			Elements.Add(new Element(66, "Dy", "Dysprosium", "Disprosium"));
			Elements.Add(new Element(67, "Ho", "Holmium", "Holmium"));
			Elements.Add(new Element(68, "Er", "Erbium", "Erbium"));
			Elements.Add(new Element(69, "Tm", "Thulium", "Thulium"));
			Elements.Add(new Element(70, "Yb", "Ytterbium", "Ytterbium"));
			Elements.Add(new Element(71, "Lu", "Lutetium", "Lutecium"));
			Elements.Add(new Element(72, "Hf", "Hafnium", "Hafnium"));
			Elements.Add(new Element(73, "Ta", "Tantalum", "Tantal"));
			Elements.Add(new Element(74, "W", "Tungsten", "Wolfram"));
			Elements.Add(new Element(75, "Re", "Rhenium", "Rehenium"));
			Elements.Add(new Element(76, "Os", "Osmium", "Osmium"));
			Elements.Add(new Element(77, "Ir", "Iridium", "Iridium"));
			Elements.Add(new Element(78, "Pt", "Platinum", "Platina"));
			Elements.Add(new Element(79, "Au", "Gold", "Aurum"));
			Elements.Add(new Element(80, "Hg", "Mercury", "Rtuť"));
			Elements.Add(new Element(81, "Tl", "Thallium", "Thallium"));
			Elements.Add(new Element(82, "Pb", "Lead", "Olovo"));
			Elements.Add(new Element(83, "Bi", "Bismuth", "Bismut"));
			Elements.Add(new Element(84, "Po", "Polonium", "Polonium"));
			Elements.Add(new Element(85, "At", "Astatine", "Astnat"));
			Elements.Add(new Element(86, "Rn", "Radon", "Radon"));
			Elements.Add(new Element(87, "Fr", "Francium", "Francium"));
			Elements.Add(new Element(88, "Ra", "Radium", "Radium"));
			Elements.Add(new Element(89, "Ac", "Actinium","Aktinium"));
			Elements.Add(new Element(90, "Th", "Thorium", "Thorium"));
			Elements.Add(new Element(91, "Pa", "Protactinium", "Protaktinium"));
			Elements.Add(new Element(92, "U", "Uranium", "Uran"));
			Elements.Add(new Element(93, "Np", "Neptunium", "Neptunium"));
			Elements.Add(new Element(94, "Pu", "Plutonium", "Plutonium"));
			Elements.Add(new Element(95, "Am", "Americium", "Americum"));
			Elements.Add(new Element(96, "Cm", "Curium", "Curium"));
			Elements.Add(new Element(97, "Bk", "Berkelium", "Berkelium"));
			Elements.Add(new Element(98, "Cf", "Californium", "Kalifo"));
			Elements.Add(new Element(99, "Es", "Einsteinium", "Einsteinium"));
			Elements.Add(new Element(100, "Fm", "Fermium", "Fermium"));
			Elements.Add(new Element(101, "Md", "Mendelevium", "Mendelevium"));
			Elements.Add(new Element(102, "No", "Nobelium", "Nobelidum"));
			Elements.Add(new Element(103, "Lr", "Lawrencium", "Lawrencium"));
			Elements.Add(new Element(104, "Rf", "Rutherfordium", "Ruthefordium"));
			Elements.Add(new Element(105, "Db", "Dubnium", "Dubinum"));
			Elements.Add(new Element(106, "Sg", "Seaborgium", "Seadorgium"));
			Elements.Add(new Element(107, "Bh", "Bohrium", "Bohrium"));
			Elements.Add(new Element(108, "Hs", "Hassium", "Hassium"));
			Elements.Add(new Element(109, "Mt", "Meitnerium", "Meitnerium"));
			Elements.Add(new Element(110, "Ds", "Darmstadtium", "Darmstadtium"));
			Elements.Add(new Element(111, "Rg", "Rentgenium", "Rentgenium"));
			Elements.Add(new Element(112, "Cn", "copernicium", "Kopernicium"));
			Elements.Add(new Element(113, "Nh", "Nihinium", "Nihonium"));
			Elements.Add(new Element(114, "Fi", "Flerovium", "Flerovium"));
			Elements.Add(new Element(115, "Mc", "Moscovium", "Moscovium"));
			Elements.Add(new Element(116, "Lv", "Livermorium", "Livermorium"));
			Elements.Add(new Element(117, "Ts", "Tennessine", "Tennessine"));
			Elements.Add(new Element(118, "Og", "Oganesson", "Oganessn"));

			return Elements;
		}

	}

}
