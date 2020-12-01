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

		/// <summary>
        /// Run when view appeare
        /// </summary>
		protected override void OnAppearing()
		{
			base.OnAppearing();
			//Get total score and show to user
			score.Text = App.right + "/" + App.bad;

		}

		/// <summary>
		/// Open view with All elements
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void vypis(object sender, EventArgs args)
		{
			Navigation.PushAsync(new AllElements());
		}

		/// <summary>
		/// Open view with test
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void test(object sender, EventArgs args)
		{
			Navigation.PushAsync(new Test());
		}
	}
}
