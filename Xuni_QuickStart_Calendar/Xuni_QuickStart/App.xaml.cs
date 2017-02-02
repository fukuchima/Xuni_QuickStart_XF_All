using Xamarin.Forms;

namespace Xuni_QuickStart
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			// ライセンスの設定
			Xuni.Forms.Core.LicenseManager.Key = License.Key;
			MainPage = new Xuni_QuickStartPage();
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
