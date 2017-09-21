﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace car_sharing_system.Models
{
    public class Booking
    {
        public int bookingID { get; }
        public int accountID { get;}
        public String numberPlate { get; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Location latlong { get; set; }
        public int travelDistance { get; }

        public Booking(int accountID, String numberPlate, DateTime startDate, DateTime endDate, Location latlong) {
            this.accountID = accountID;
            this.numberPlate = numberPlate;
            this.startDate = startDate;
            this.endDate = endDate;
            this.latlong = latlong;
        }
        public Booking(int bookingID, int accountID, String numberPlate, DateTime startDate, DateTime endDate, Location latlong)
        {
            this.bookingID = bookingID;
            this.accountID = accountID;
            this.numberPlate = numberPlate;
            this.startDate = startDate;
            this.endDate = endDate;
            this.latlong = latlong;
        }
        public Booking(int bookingID, int accountID, String numberPlate, DateTime startDate,
            DateTime endDate, Location latlong, int travelDistance)
        {
            this.bookingID = bookingID;
            this.accountID = accountID;
            this.numberPlate = numberPlate;
            this.startDate = startDate;
            this.endDate = endDate;
            this.latlong = latlong;
            this.travelDistance = travelDistance;
        }
    }
}