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
			// TabbedPage で各コントロールのページを表示
			MainPage = new  TabbedPage()
			{
				Children =
				{
					new Xuni_QuickStartPage(),
					new XuniLinearGauge(),
					new XuniRadialGauge(),
					new XuniBulletGraph(),
				},
			};

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
