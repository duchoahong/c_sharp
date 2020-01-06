using System;
using System.Collections.Generic;

namespace c_sharp_lab2.Properties
{
    public class Product
    {
        private int id;
        private String name;
        private double price;
        private int qty;
        private String image;
        private int desc;
        private List<String> gallery = new List<string>();

        public Product()
        {
            
        }

        public Product(int id, String name, double price, int qty, int desc)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Qty = qty;
            this.Desc = desc;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public int Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public List<String> Gallery
        {
            get { return gallery; }
            set { gallery = value; }
        }
    }
}