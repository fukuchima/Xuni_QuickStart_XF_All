using System;
using System.Collections.Generic;

namespace Xuni_QuickStart
{

	public class FlexPieDataSource
	{
		private List<FruitEntity> entityList;

		public List<FruitEntity> Data
		{
			get { return entityList; }
		}

		public FlexPieDataSource()
		{
			entityList = new List<FruitEntity>();
			string[] fruits = new string[] { "みかん", "りんご", "なし", "バナナ", "パイナップル" };
			Random random = new Random();
			for (int i = 0; i < fruits.Length; i++)
			{
				decimal value = (decimal)random.NextDouble() * 100;
				entityList.Add(new FruitEntity(fruits[i], value));
			}
		}
	}
	public class FruitEntity
	{
		public string Name { get; set; }
		public decimal Value { get; set; }

		public FruitEntity(string name, decimal value)
		{
			this.Name = name;
			this.Value = value;
		}
	}

}
