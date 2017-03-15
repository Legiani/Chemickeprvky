using System;
using System.Collections.Generic;

namespace Chemickeprvky
{
	public class Table
	{

		public Element getElement()
		{
			List<Element> Elements = getPeriodicTable();
			Random rnd = new Random();
			int num = rnd.Next(1, 118);
			return Elements[num];

		}

		public Element getTrueElement()
		{
			List<Element> Elements = getPeriodicTable();
			Random rnd = new Random();
			int num = rnd.Next(0, 118);
			if (Elements[num].Activ == false)
			{
				getTrueElement();
			}
			return Elements[num];

		}

		public List<Element> getPeriodicTable()
		{
			List<Element> Elements = new List<Element>();
			Elements.Add(new Element(1, "H", "Hydrogen", "Vodík",true));
			Elements.Add(new Element(2, "He", "Helium", "Helium", true));
			Elements.Add(new Element(3, "Li", "Lithium", "lithium", true));
			Elements.Add(new Element(4, "Be", "Beryllium", "Belirium", true));
			Elements.Add(new Element(5, "B", "Boron", "Bór", true));
			Elements.Add(new Element(6, "C", "Carbon", "Uhlík", true));
			Elements.Add(new Element(7, "N", "Nitrogen", "Dusík", true));
			Elements.Add(new Element(8, "O", "Oxygen", "Kislík", true));
			Elements.Add(new Element(9, "F", "Fluorine", "Fluor", true));
			Elements.Add(new Element(10, "Ne", "Neon", "Neon", true));
			Elements.Add(new Element(11, "Na", "Sodium", "Sodík", true));
			Elements.Add(new Element(12, "Mg", "Magnesium", "Hořčík", true));
			Elements.Add(new Element(13, "Al", "Aluminum", "Hliník", true));
			Elements.Add(new Element(14, "Si", "Silicon", "Křemík", true));
			Elements.Add(new Element(15, "P", "Phosphorus", "Fosfor", true));
			Elements.Add(new Element(16, "S", "Sulphur", "Síra", true));
			Elements.Add(new Element(17, "Cl", "Chlorine", "Chlor", true));
			Elements.Add(new Element(18, "Ar", "Argon", "Argon", true));
			Elements.Add(new Element(19, "K", "Potassium", "Draslík", true));
			Elements.Add(new Element(20, "Ca", "Calcium", "Vápník", true));
			Elements.Add(new Element(21, "Sc", "Scandium", "Skandium", true));
			Elements.Add(new Element(22, "Ti", "Titanium", "Titan", true));
			Elements.Add(new Element(23, "V", "Vanadium", "Vanad", true));
			Elements.Add(new Element(24, "Cr", "Chromium", "Chrom", true));
			Elements.Add(new Element(25, "Mn", "Manganese", "Mangan", true));
			Elements.Add(new Element(26, "Fe", "Iron", "Železo", true));
			Elements.Add(new Element(27, "Co", "Cobalt", "Kobalt", true));
			Elements.Add(new Element(28, "Ni", "Nickel", "Nikl", true));
			Elements.Add(new Element(29, "Cu", "Copper", "Měď", true));
			Elements.Add(new Element(30, "Zn", "Zinc", "Zinek", true));
			Elements.Add(new Element(31, "Ga", "Gallium", "Galium", true));
			Elements.Add(new Element(32, "Ge", "Germanium", "Germanium", true));
			Elements.Add(new Element(33, "As", "Arsenic", "Arsen", true));
			Elements.Add(new Element(34, "Se", "Selenium", "Selen", true));
			Elements.Add(new Element(35, "Br", "Bromine", "Bróm", true));
			Elements.Add(new Element(36, "Kr", "Krypton", "Krypton", true));
			Elements.Add(new Element(37, "Rb", "Rubidium", "Rubium", true));
			Elements.Add(new Element(38, "Sr", "Strontium", "Stroncium", true));
			Elements.Add(new Element(39, "Y", "Yttrium", "Yttrium", true));
			Elements.Add(new Element(40, "Zr", "Zirconium", "Zircon", true));
			Elements.Add(new Element(41, "Nb", "Niobium", "Niob", true));
			Elements.Add(new Element(42, "Mo", "Molybdenum", "Molibden", true));
			Elements.Add(new Element(43, "Tc", "Technetium", "Technecium", true));
			Elements.Add(new Element(44, "Ru", "Ruthenium", "Rubuídium", true));
			Elements.Add(new Element(45, "Rh", "Rhodium", "Rhodikum", true));
			Elements.Add(new Element(46, "Pd", "Palladium", "Palladikum", true));
			Elements.Add(new Element(47, "Ag", "Silver", "Atříbro", true));
			Elements.Add(new Element(48, "Cd", "Cadmium", "Kadmium", true));
			Elements.Add(new Element(49, "In", "Indium", "Idium", true));
			Elements.Add(new Element(50, "Sn", "Tin", "Cín", true));
			Elements.Add(new Element(51, "Sb", "Antimony", "Antinon", true));
			Elements.Add(new Element(52, "Te", "Tellurium", "Tellur", true));
			Elements.Add(new Element(53, "I", "Iodine", "Iod", true));
			Elements.Add(new Element(54, "Xe", "Xenon", "Xenon", true));
			Elements.Add(new Element(55, "Cs", "Cesium", "Cesium", true));
			Elements.Add(new Element(56, "Ba", "Barium", "Barium", true));
			Elements.Add(new Element(57, "La", "Lanthanum", "Lanthan", true));
			Elements.Add(new Element(58, "Ce", "Cerium", "Car", true));
			Elements.Add(new Element(59, "Pr", "Praseodymium", "Praseodym", true));
			Elements.Add(new Element(60, "Nd", "Neodymium", "Neodym", true));
			Elements.Add(new Element(61, "Pm", "Promethium", "Promethium", true));
			Elements.Add(new Element(62, "Sm", "Samarium", "Samarium", true));
			Elements.Add(new Element(63, "Eu", "Europium", "Europium", true));
			Elements.Add(new Element(64, "Gd", "Gadolinium", "Gadolinium", true));
			Elements.Add(new Element(65, "Tb", "Terbium", "Tarbium", true));
			Elements.Add(new Element(66, "Dy", "Dysprosium", "Disprosium", true));
			Elements.Add(new Element(67, "Ho", "Holmium", "Holmium", true));
			Elements.Add(new Element(68, "Er", "Erbium", "Erbium", true));
			Elements.Add(new Element(69, "Tm", "Thulium", "Thulium", true));
			Elements.Add(new Element(70, "Yb", "Ytterbium", "Ytterbium", true));
			Elements.Add(new Element(71, "Lu", "Lutetium", "Lutecium", true));
			Elements.Add(new Element(72, "Hf", "Hafnium", "Hafnium", true));
			Elements.Add(new Element(73, "Ta", "Tantalum", "Tantal", true));
			Elements.Add(new Element(74, "W", "Tungsten", "Wolfram", true));
			Elements.Add(new Element(75, "Re", "Rhenium", "Rehenium", true));
			Elements.Add(new Element(76, "Os", "Osmium", "Osmium", true));
			Elements.Add(new Element(77, "Ir", "Iridium", "Iridium", true));
			Elements.Add(new Element(78, "Pt", "Platinum", "Platina", true));
			Elements.Add(new Element(79, "Au", "Gold", "Aurum", true));
			Elements.Add(new Element(80, "Hg", "Mercury", "rtut", true));
			Elements.Add(new Element(81, "Tl", "Thallium", "Thallium", true));
			Elements.Add(new Element(82, "Pb", "Lead", "Olovo", true));
			Elements.Add(new Element(83, "Bi", "Bismuth", "Bismut", true));
			Elements.Add(new Element(84, "Po", "Polonium", "Polonium", true));
			Elements.Add(new Element(85, "At", "Astatine", "Astnat", true));
			Elements.Add(new Element(86, "Rn", "Radon", "Radon", true));
			Elements.Add(new Element(87, "Fr", "Francium", "Francium", true));
			Elements.Add(new Element(88, "Ra", "Radium", "Radium", true));
			Elements.Add(new Element(89, "Ac", "Actinium","Aktinium", true));
			Elements.Add(new Element(90, "Th", "Thorium", "Thorium", true));
			Elements.Add(new Element(91, "Pa", "Protactinium", "Protaktinium", true));
			Elements.Add(new Element(92, "U", "Uranium", "Uran", true));
			Elements.Add(new Element(93, "Np", "Neptunium", "Neptunium", true));
			Elements.Add(new Element(94, "Pu", "Plutonium", "Plutonium", true));
			Elements.Add(new Element(95, "Am", "Americium", "Americum", true));
			Elements.Add(new Element(96, "Cm", "Curium", "Curium", true));
			Elements.Add(new Element(97, "Bk", "Berkelium", "Berkelium", true));
			Elements.Add(new Element(98, "Cf", "Californium", "Kalifo", true));
			Elements.Add(new Element(99, "Es", "Einsteinium", "Einsteinium", true));
			Elements.Add(new Element(100, "Fm", "Fermium", "Fermium", true));
			Elements.Add(new Element(101, "Md", "Mendelevium", "Mendelevium", true));
			Elements.Add(new Element(102, "No", "Nobelium", "Nobelidum", true));
			Elements.Add(new Element(103, "Lr", "Lawrencium", "Lawrencium", true));
			Elements.Add(new Element(104, "Rf", "Rutherfordium", "Ruthefordium", true));
			Elements.Add(new Element(105, "Db", "Dubnium", "Dubinum", true));
			Elements.Add(new Element(106, "Sg", "Seaborgium", "Seadorgium", true));
			Elements.Add(new Element(107, "Bh", "Bohrium", "Bohrium", true));
			Elements.Add(new Element(108, "Hs", "Hassium", "Hassium", true));
			Elements.Add(new Element(109, "Mt", "Meitnerium", "Meitnerium", true));
			Elements.Add(new Element(110, "Ds", "Darmstadtium", "Darmstadtium", true));
			Elements.Add(new Element(111, "Rg", "Rentgenium", "Rentgenium", true));
			Elements.Add(new Element(112, "Cn", "copernicium", "Kopernicium", true));
			Elements.Add(new Element(113, "Nh", "Nihinium", "Nihonium", true));
			Elements.Add(new Element(114, "Fi", "Flerovium", "Flerovium", true));
			Elements.Add(new Element(115, "Mc", "Moscovium", "Moscovium", true));
			Elements.Add(new Element(116, "Lv", "Livermorium", "Livermorium", true));
			Elements.Add(new Element(117, "Ts", "Tennessine", "Tennessine", true));
			Elements.Add(new Element(118, "Og", "Oganesson", "Oganessn", true));

			return Elements;
		}
	}
}
