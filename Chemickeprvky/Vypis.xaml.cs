using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Chemickeprvky
{
	public partial class Vypis : ContentPage
	{
		Table table = new Table();

		public Vypis()
		{
			InitializeComponent();

			ListViewFormatted.ItemsSource = table.getPeriodicTable();

		}

		/// <summary>
		/// Možnost editace jednotlivích položek
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public void Activ(object sender, EventArgs e)
		{
			var mi = ((MenuItem)sender);

			int derp = (int)mi.CommandParameter;
			//vytvoření spojení s db
			var dbConnection = App.Database;
			//db věcí
			Database items = App.Database;
			//přikaz smaž
			App.Database.DeleteItemAsync(App.Database.GetItemAsync(derp).Result);
			//hlaška
			DisplayAlert("Aktivováno", "Prvek s ID: " + derp + " byl smazán.", "OK");

		}

		/// <summary>
		/// Možnost smazání položky
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public void DeActiv(object sender, EventArgs e)
		{
			var mi = ((MenuItem)sender);

			int derp = (int)mi.CommandParameter;
			//vytvoření spojení s db
			var dbConnection = App.Database;
			//db věcí
			Database items = App.Database;

			Activ activ = new Activ();
			activ.Active = false;
			activ.AtomicNumber = derp;

			//přikaz vlož
			App.Database.SaveItemAsync(activ);
			//hlaška
			DisplayAlert("Vyřazeno", "Prvek s ID: " + derp + " byl smazán.", "OK");
		}
	}
}
