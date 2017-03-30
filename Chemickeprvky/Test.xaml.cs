using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chemickeprvky
{
	public partial class Test : ContentPage
	{
		Table table = new Table();
		int right;
		int bad;

		int Iright;

		public Test()
		{
			InitializeComponent();
			//Task.Delay(500).Wait();
			fill();
		}

		public void fill() { 
			if (right + bad >= 25)
			{
				App.bad = bad;
				App.right = right;
				Navigation.PopModalAsync();
			}

			A.BackgroundColor = Color.FromHex("#d1d1e0");
			B.BackgroundColor = Color.FromHex("#d1d1e0");
			C.BackgroundColor = Color.FromHex("#d1d1e0");


			Element elementA = table.getTrueElement();
			Task.Delay(100);
			Element elementB = table.getTrueElement();
			while (elementA == elementB)
			{
				elementB = table.getTrueElement();
			}
			Task.Delay(100);
			Element elementC = table.getTrueElement();
			while (elementC == elementB || elementC == elementA)
			{
				elementC = table.getTrueElement();
			}


			switch (RandomNumber(0, 6))
			{
				case 0:
					A.Text = elementA.Symbol;
					B.Text = elementB.Symbol;
					C.Text = elementC.Symbol;

					element.Text = elementA.CzechName;
					Iright = 1;
					break;
				case 1:
					A.Text = elementA.Symbol;
					B.Text = elementB.Symbol;
					C.Text = elementC.Symbol;

					element.Text = elementB.CzechName;
					Iright = 2;
					break;
				case 2:
					A.Text = elementA.Symbol;
					B.Text = elementB.Symbol;
					C.Text = elementC.Symbol;

					element.Text = elementC.CzechName;
					Iright = 3;
					break;
				case 3:
					A.Text = elementA.Symbol;
					B.Text = elementB.Symbol;
					C.Text = elementC.Symbol;

					element.Text = elementB.CzechName;
					Iright = 2;
					break;	
				case 4:
					A.Text = elementA.Symbol;
					B.Text = elementB.Symbol;
					C.Text = elementC.Symbol;

					element.Text = elementA.CzechName;
					Iright = 1;
					break;
				default:
					A.Text = elementA.Symbol;
					B.Text = elementB.Symbol;
					C.Text = elementC.Symbol;

					element.Text = elementC.CzechName;
					Iright = 3;
					break;
			}
		}

		//funkce se zeptá zda je řetezec pal......
		public void pressA(object sender, EventArgs e)
		{
			A.BackgroundColor = Color.FromHex("#E51F1F");
			B.BackgroundColor = Color.FromHex("#E51F1F");
			C.BackgroundColor = Color.FromHex("#E51F1F");

			if (Iright == 1)
			{
				A.BackgroundColor = Color.FromHex("#24EE64");
				right++;
				Delay();
			}
			else {
				A.BackgroundColor = Color.FromHex("#0099ff");
				bad++;
				Delay();
			}


		}
		//funkce se zeptá zda je řetezec pal......
		public void pressB(object sender, EventArgs e)
		{
			A.BackgroundColor = Color.FromHex("#E51F1F");
			B.BackgroundColor = Color.FromHex("#E51F1F");
			C.BackgroundColor = Color.FromHex("#E51F1F");

			if (Iright == 2)
			{
				B.BackgroundColor = Color.FromHex("#24EE64");
				right++;
				Delay();
			}
			else
			{
				B.BackgroundColor = Color.FromHex("#0099ff");
				bad++;
				Delay();
			}

		}
		//funkce se zeptá zda je řetezec pal......
		public void pressC(object sender, EventArgs e)
		{
			A.BackgroundColor = Color.FromHex("#E51F1F");
			B.BackgroundColor = Color.FromHex("#E51F1F");
			C.BackgroundColor = Color.FromHex("#E51F1F");

			if (Iright == 3)
			{
				C.BackgroundColor = Color.FromHex("#24EE64");
				right++;
				Delay();
			}
			else
			{
				C.BackgroundColor = Color.FromHex("#0099ff");
				bad++;
				Delay();
			}

		}
		public void Delay()
		{
			score.Text = string.Format("{0}/{1}", right, bad);

			fill();
		}

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
	}
}
