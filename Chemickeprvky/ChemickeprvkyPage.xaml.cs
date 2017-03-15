using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chemickeprvky
{
	public partial class ChemickeprvkyPage : ContentPage
	{
		Table table = new Table();
		int right;
		int bad;

		public ChemickeprvkyPage()
		{
			InitializeComponent();
			fill();

		}

		public void fill() { 
			A.BackgroundColor = Color.FromHex("#d1d1e0");
			B.BackgroundColor = Color.FromHex("#d1d1e0");
			C.BackgroundColor = Color.FromHex("#d1d1e0");
			Random rnd = new Random();

			Element elementA = table.getTrueElement();
			MyDelay(100);
			Element elementB = table.getTrueElement();
			while (elementA == elementB)
			{
				elementB = table.getTrueElement();
			}
			MyDelay(100);
			Element elementC = table.getTrueElement();
			while (elementC == elementB || elementC == elementA)
			{
				elementC = table.getTrueElement();
			}

			switch (rnd.Next(0, 4))
			{
				case 0:
					A.Text = elementA.Symbol;
					B.Text = elementB.Symbol;
					C.Text = elementC.Symbol;

					element.Text = elementA.CzechName;
					App.right = 1;
					break;
				case 1:
					A.Text = elementA.Symbol;
					B.Text = elementB.Symbol;
					C.Text = elementC.Symbol;

					element.Text = elementB.CzechName;
					App.right = 2;
					break;
				case 2:
					A.Text = elementA.Symbol;
					B.Text = elementB.Symbol;
					C.Text = elementC.Symbol;

					element.Text = elementC.CzechName;
					App.right = 3;
					break;
				case 3:
					A.Text = elementA.Symbol;
					B.Text = elementB.Symbol;
					C.Text = elementC.Symbol;

					element.Text = elementB.CzechName;
					App.right = 2;
					break;					
				default:
					A.Text = elementA.Symbol;
					B.Text = elementB.Symbol;
					C.Text = elementC.Symbol;

					element.Text = elementC.CzechName;
					App.right = 3;
					break;
			}
		}

		//funkce se zeptá zda je řetezec pal......
		public void pressA(object sender, EventArgs e)
		{
			A.BackgroundColor = Color.FromHex("#E51F1F");
			B.BackgroundColor = Color.FromHex("#E51F1F");
			C.BackgroundColor = Color.FromHex("#E51F1F");

			if (App.right == 1)
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

			if (App.right == 2)
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

			if (App.right == 3)
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
			MyDelay(1000);
			fill();
		}

		public async void MyDelay(int time) { 
			await Task.Delay(time);
		}
	}
}
