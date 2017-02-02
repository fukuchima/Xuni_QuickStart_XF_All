using System;
using System.Collections.Generic;

namespace Xuni_QuickStart
{
	public class States
	{
		public string Name { get; set; }
		public States(string name)
		{
			this.Name = name;
		}

		public static List<States> GetStates()
		{
			List<States> data = new List<States>();
			data.Add(new States("アラバマ"));
			data.Add(new States("アラスカ"));
			data.Add(new States("アリゾナ"));
			data.Add(new States("アーカンソー"));
			data.Add(new States("カリフォルニア"));
			data.Add(new States("コロラド"));
			data.Add(new States("コネティカット"));
			data.Add(new States("デラウェア"));
			data.Add(new States("コロンビア特別区"));
			data.Add(new States("フロリダ"));
			data.Add(new States("ジョージア"));
			data.Add(new States("グアム"));
			data.Add(new States("ハワイ"));
			data.Add(new States("アイダホ"));
			data.Add(new States("イリノイ"));
			data.Add(new States("インディアナ"));
			data.Add(new States("アイオワ"));
			data.Add(new States("カンザス"));
			return data;
		}
	}}
