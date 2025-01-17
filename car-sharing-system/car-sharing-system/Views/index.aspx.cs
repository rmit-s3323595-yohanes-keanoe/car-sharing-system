﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using car_sharing_system.Models;
using System.Web.UI.HtmlControls;
using MySql.Data.MySqlClient;
using System.Text;
using System.Web.Script.Serialization;
using System.Diagnostics;
using System.Web.Script.Services;
using System.Web.Security;

namespace car_sharing_system {
	public class GoogleCarLocation {
		public String carName { get; set; }
		public Location loc { get; set; }
		public Double dist { get; set; }
		public GoogleCarLocation(String n, Location l, Double d) {
			carName = n;
			loc = l;
			dist = d;
		}
	}

	public partial class FrontPage : System.Web.UI.Page {
		protected void Page_Load(object sender, EventArgs e) {
		}

		[System.Web.Services.WebMethod]
		public static string getCarsDataFiltered(String lat, String lng,
												int sdate, int edate,
												String brand,
												String seat,
												int sortby,
												String transmission,
												String type,
												bool adv, bool cd,
												bool bt, bool gps, 
												bool cc, bool rad, 
												bool revcam ) {
			CarModel cm = CarModel.getInstance();
			List<Car> closeCars = cm.getCloseCarFiltered(
												Double.Parse(lat), Double.Parse(lng),
												sdate, edate, // Start and end date
												brand,
												seat,
												sortby,
												transmission,
												type,
												adv, cd, bt, gps, cc, rad, revcam );
			if (closeCars == null) {
				return null;
			} else {
				return generateGoogleCarLocation(closeCars);
			}
		}

		[System.Web.Services.WebMethod]
		public static string getCarPage(int page) {
			CarModel cm = CarModel.getInstance();
			List<Car> closeCars = cm.getPageCar(page);
			return generateGoogleCarLocation(closeCars);
		}

		[System.Web.Services.WebMethod]
		public static string getCarsData(String lat, String lng) {
			CarModel cm = CarModel.getInstance();
			if (cm == null)
				Debug.WriteLine("cm NULL");
			List<Car> closeCars = cm.getCloseCar(Double.Parse(lat), Double.Parse(lng));
			return generateGoogleCarLocation(closeCars);
		}

		private static String generateGoogleCarLocation(List<Car> cars) {
			JavaScriptSerializer oSerializer = new JavaScriptSerializer();
			List<GoogleCarLocation> carlocs = new List<GoogleCarLocation>();

			foreach (Car car in cars) {
				carlocs.Add(new GoogleCarLocation(car.getCarAsTitle(), car.latlong,
												Math.Round(car.rangeToUser,2)));
			}
			
			return oSerializer.Serialize(carlocs);
		}
	}
}