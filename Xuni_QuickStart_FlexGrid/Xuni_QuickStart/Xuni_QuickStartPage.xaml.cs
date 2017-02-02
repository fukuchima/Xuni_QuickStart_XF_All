using Xamarin.Forms;

namespace Xuni_QuickStart
{
	public partial class Xuni_QuickStartPage : ContentPage
	{
		public Xuni_QuickStartPage()
		{
			InitializeComponent();
			grid.ItemsSource = Customer.GetCustomerList(10);
		}
	}
}
