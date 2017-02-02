using System;
using System.Collections.Generic;

namespace Xuni_QuickStart
{

	public class FlexChartDataSource
	{
		private List<Month> appData;

		public List<Month> Data
		{
			get { return appData; }
		}

		public FlexChartDataSource()
		{
			// appData
			appData = new List<Month>();
			var monthNames = "1 月,2 月,3 月,4 月,5 月,6 月,7 月,8 月,9 月,10 月,11 月,12 月".Split(',');
			var salesData = new[] { 5000, 8500, 7000, 6500, 12000, 14800, 18500, 7500, 6500, 13000, 20000, 9000 };
			var downloadsData = new[] { 6000, 7500, 12000, 5800, 11000, 7000, 16000, 17500, 19500, 13250, 13800, 19000 };
			var expensesData = new[] { 15000, 18000, 15500, 18500, 11000, 16000, 8000, 7500, 6500, 6000, 13500, 5000 };
			for (int i = 0; i < 12; i++)
			{
				Month tempMonth = new Month();
				tempMonth.Name = monthNames[i];
				tempMonth.Sales = salesData[i];
				tempMonth.Downloads = downloadsData[i];
				tempMonth.Expenses = expensesData[i];
				appData.Add(tempMonth);

			}
		}
	}

	public class Month
	{
		string _name;
		long _sales, _downloads, _expenses;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public long Sales
		{
			get { return _sales; }
			set { _sales = value; }
		}

		public long Downloads
		{
			get { return _downloads; }
			set { _downloads = value; }
		}
		public long Expenses
		{
			get { return _expenses; }
			set { _expenses = value; }
		}
	}

}
