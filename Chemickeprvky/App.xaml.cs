using Xamarin.Forms;

namespace Chemickeprvky
{
	public partial class App : Application
	{
		public static int right;
		public App()
		{
			InitializeComponent();

			MainPage = new ChemickeprvkyPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

