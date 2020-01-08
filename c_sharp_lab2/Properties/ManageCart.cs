using System;
using System.Collections.Generic;

namespace c_sharp_lab2.Properties
{
    public class ManageCart : ManageProduct
    {
        private Cart c ;
        private int idIncrement = 0;

        public void getInfo()
        {
            Console.WriteLine("nhap thong tin khach hang");
            int cusId = this.idIncrement++;
            Console.WriteLine("nhap ten khach hang");
            String cusName = Console.ReadLine();
            Console.WriteLine("nhap city hn || hvm || else");
            String cusCity = Console.ReadLine();
            Console.WriteLine("nhap quoc tich vn || else");
            String cusCountry = Console.ReadLine();
            
            this.c = new Cart(cusId, cusName, cusCity, cusCountry);
            
        }

        public void showAllCart()
        {
            Console.WriteLine("khach hang :" + this.c.TenKh + " id: " + c.Id);
            Console.WriteLine("dia chi: "+this.c.City+" - "+this.c.Country);
            this.grandTotal();
        }
        public void addToCart()
        {
            Console.WriteLine("chon san pham ban muon them");
            
            this.getProductName();
            int prdPicked = Int32.Parse(Console.ReadLine());
            foreach (Product p in this.pList)
            {
                if (p.Id == prdPicked)
                {
                    Product pPicked = p;
                    p.Qty = p.Qty - 1;
                    c.PList.Add(pPicked);
                }
            }
        }

        public void getProductNameInCart()
        {
            if (c.PList.Count > 0)
            {
                foreach (Product p in c.PList)
                {
                    Console.WriteLine("id :"+p.Id+" ten san pham "+p.Name);
                }
            }
        }
        
        public void getProductWithPriceInCart()
        {
            if (c.PList.Count > 0)
            {
                foreach (Product p in c.PList)
                {
                    Console.WriteLine("id :"+p.Id+" ten san pham "+p.Name+" gia: "+p.Price);
                }
            }
        }
        
        public void removeFromCart()
        {
            Console.WriteLine("Chon san pham ban muon Xoa khoi gio hang");
            this.getProductNameInCart();
            int pPicked = Int32.Parse(Console.ReadLine());
            foreach (Product p in c.PList)
            {
                if (p.Id == pPicked)
                {
                    String pickedProductName = p.Name;
                    c.PList.RemoveAt(pPicked);
                    Console.WriteLine("xoa thanh cong san pham :"+pickedProductName+"khoi gio hang");
                }
                break;
            }
        }

        public double shipCity()
        {
            String t1 = "hn";
            String t2 = "hcm";
            if (this.c.City.Equals(t1) || this.c.City.Equals(t2))
            {
                return 0.01;
            }

            return 0.02;
        }

        public double shipCountry()
        {
            String isVn = "vn";
            if (!this.c.Country.Equals(isVn))
            {
                return 0.05;
            }

            return 0;
        }

        public double countGrandTotal()
        {
            double tmpTongTien = 0;
            foreach (Product p in c.PList)
            {
                tmpTongTien += p.Price;
            }
            return c.TongTien = tmpTongTien + tmpTongTien * this.shipCity() + tmpTongTien * this.shipCountry();
        }
        
        public void grandTotal()
        {
            this.getProductWithPriceInCart();
            Console.WriteLine("phi ship city: "+this.shipCity()+" %");
            Console.WriteLine("phi ship country: "+this.shipCountry()+" %");
            Console.WriteLine("tong tien san pham la "+this.countGrandTotal());
            Console.WriteLine("===========================");
        }
    }
}