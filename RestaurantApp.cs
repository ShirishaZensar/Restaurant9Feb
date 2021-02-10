using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWork9Feb.Models
{
	public enum Cuisine
	{
		None,
		French,
		Indian,
		Mexican
	}

	public class RestaurantApp
	{
		private Cuisine _c;
		public int RId { get; set; }

		public string RName { get; set; }

		public Cuisine CuisineDish
		{
			get { return _c; }
			set { _c = value; }
		}
	}
}