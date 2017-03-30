using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Chemickeprvky
{
	public partial class Menu : ContentPage
	{
		public Menu()
		{
			InitializeComponent();

		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
			score.Text = App.right + "/" + App.bad;

		}

		public void vypis(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new Vypis());
		}

		public void test(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new Test());
		}
	}
}
