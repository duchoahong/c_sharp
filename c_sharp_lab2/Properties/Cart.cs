using System;
using System.Collections.Generic;

namespace c_sharp_lab2.Properties
{
    public class Cart
    {
        private int id;
        private String tenKh;
        private double tongTien;
        private List<Product> pList = new List<Product>();
        private String city;
        private String country;
        public Cart()
        {
            
        }

        public Cart(int id, String tenKh, String city, String country)
        {
            this.Id = id;
            this.TenKh = tenKh;
            this.City = city;
            this.Country = country;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string TenKh
        {
            get { return tenKh; }
            set { tenKh = value; }
        }

        public double TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        public List<Product> PList
        {
            get { return pList; }
            set { pList = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
    }
}