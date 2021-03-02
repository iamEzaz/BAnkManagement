﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Address
    {
        private string roadNo;
        private string houseNo;
        private string city;
        private string country;

        public Address(string houseNo, string roadNo, string city, string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.city = city;
            this.country = country;
        }

       

        public string HouseNo
        {
            set { this.houseNo = value; }
            get { return this.houseNo; }
        }
        public string RoadNo
        {
            set { this.roadNo = value; }
            get { return this.roadNo; }
        }
        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }
        public string Country
        {
            set { this.country = value; }
            get { return this.country; }
        }

        public string GetAddress()
        {
            return " House No:" + this.houseNo + " Road NO: " + this.roadNo + " City: " + this.city + " Country: "+this.country;
        }
    }
}
