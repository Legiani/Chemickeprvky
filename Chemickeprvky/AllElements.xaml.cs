using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chemickeprvky
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllElements : ContentPage
    {
		private ObservableCollection<ElementGroup> grouped { get; set; }
		Table table = new Table();


        public AllElements()
        {
            InitializeComponent();

            //Set nav bar text to "Zpět"
            NavigationPage.SetBackButtonTitle(this, "Zpět");

			fillData();
        }


		/// <summary>
        /// Fill lIstView with gruped data
        /// </summary>
		public void fillData()
		{
			//Get all periodic element
			var data = table.getPeriodicTable();

			//Sort to active and deactivet

			var activeGroup = new ElementGroup();
			var actives = data.FindAll(x => x.isActive == true);

			activeGroup.Heading = "Zkoušené prvky";
			foreach (Element item in actives)
			{
				activeGroup.Add(item);
			}

			var deactiveGroup = new ElementGroup();
			var deactives = data.FindAll(x => x.isActive == false);

			deactiveGroup.Heading = "Odložené prvky";
			foreach (Element item in deactives)
			{
				deactiveGroup.Add(item);
			}

			var gruped = new ObservableCollection<ElementGroup>();

			gruped.Add(activeGroup);
			gruped.Add(deactiveGroup);


			//Fill lisview wit data
			MyListView.ItemsSource = gruped;
		}

		/// <summary>
		/// Možnost editace jednotlivích položek
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public void Activ(object sender, EventArgs e)
		{
			var mi = ((MenuItem)sender);

			int rowMenuContent = (int)mi.CommandParameter;

			//create active object
			Activ activ = new Activ();
			activ.Active = true;
			activ.AtomicNumber = rowMenuContent;

			//save to db
			App.Database.SaveItemAsync(activ);

			//alert
			DisplayAlert("Prvek aktivován", "Prvek se bude zobrazovat v testech. Dokud jej znovu nedeaktivujete.", "OK");

			fillData();
		}

		/// <summary>
		/// Možnost smazání položky
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public void DeActiv(object sender, EventArgs e)
		{
			var mi = ((MenuItem)sender);

			int rowMenuContent = (int)mi.CommandParameter;

			//create deactive object
			Activ activ = new Activ();
			activ.Active = false;
			activ.AtomicNumber = rowMenuContent;

			//save to db
			App.Database.SaveItemAsync(activ);

			//alert
			DisplayAlert("Prvek deaktivován", "Prvek se nadale nebude zobrazovat v testech. Dokud jej znovu neaktivujete.", "OK");

			fillData();
		}

		/// <summary>
        /// Deselect on line tap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
