using System;
using System.Collections.Generic;

namespace Xuni_QuickStart
{
	public class Country
	{
		public string Name { get; set; }
		public static List<Country> GetCountries()
		{
			List<Country> listCountries = new List<Country>();
			string[] countries = { "あおもり", "あきた", "いわて", "みやぎ", "ふくしま", "やまがた", "みやざき", "ふくおか", "やまなし", "やまぐち", "とやま", "あいち" };
			foreach (var item in countries)
			{
				listCountries.Add(new Country() { Name = item });
			}
			return listCountries;
		}
	}
}
