using Xamarin.Forms;
using Xuni.Forms.Calendar;

namespace Xuni_QuickStart
{
	public partial class Xuni_QuickStartPage : ContentPage
	{
		public Xuni_QuickStartPage()
		{
			InitializeComponent();
			// Autocomplete
			this.autoComplete.ItemsSource = Country.GetCountries();

			//// Combobox
			var array = States.GetStates();
			this.cbxEdit.ItemsSource = array;

			//// Combobox with Calendar
			this.calendar.SelectionChanged += CalendarSelectionChanged;
		}

		private void CalendarSelectionChanged(object sender, CalendarSelectionChangedEventArgs e)
		{
			this.mask.Value = calendar.SelectedDate.ToString();
			this.dropdown.IsDropDownOpen = false;
		}
	}
}
