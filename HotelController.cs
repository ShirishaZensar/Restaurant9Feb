using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantWork9Feb.Models;

namespace RestaurantWork9Feb.Controllers
{
    public class HotelController : Controller
    {
        // GET: Hotel
        public ActionResult Index()
        {
			List<RestaurantApp> resDetails = new List<RestaurantApp>
			{
				new RestaurantApp{ RId=1001,RName="Paradise",CuisineDish=Cuisine.Mexican},
				new RestaurantApp{ RId=1002,RName="Chutneys",CuisineDish=Cuisine.Mexican},
				new RestaurantApp{ RId=1003,RName="Bahar Cafe",CuisineDish=Cuisine.Indian},
				new RestaurantApp{ RId=1004,RName="ABs",CuisineDish=Cuisine.Indian},
				new RestaurantApp{ RId=1005,RName="Almond House",CuisineDish=Cuisine.Indian}
			};
			return View(resDetails);
        }

		public ActionResult Details(int id)
		{
			List<RestaurantApp> resDetails = new List<RestaurantApp>
			{
				new RestaurantApp{ RId=1001,RName="Paradise",CuisineDish=Cuisine.Mexican},
				new RestaurantApp{ RId=1002,RName="Chutneys",CuisineDish=Cuisine.Mexican},
				new RestaurantApp{ RId=1003,RName="Bahar Cafe",CuisineDish=Cuisine.Indian},
				new RestaurantApp{ RId=1004,RName="ABs",CuisineDish=Cuisine.Indian},
				new RestaurantApp{ RId=1005,RName="Almond House",CuisineDish=Cuisine.Indian}
			};
			RestaurantApp Menu=null;
			foreach (var item in resDetails)
			{
				if (item.RId == id)
					Menu = item;
			}
			ViewBag.resDetails = Menu;
			return View();
		}

		public ActionResult Image()
		{
			List<RestaurantApp> resDetails = new List<RestaurantApp>
			{
				new RestaurantApp{ RId=1001,RName="Paradise"},
				new RestaurantApp{ RId=1002,RName="Chutneys"},
				new RestaurantApp{ RId=1003,RName="Bahar Cafe"},
				new RestaurantApp{ RId=1004,RName="ABs"},
				new RestaurantApp{ RId=1005,RName="Almond House"}
			};
			return View(resDetails);
		}
	}
}