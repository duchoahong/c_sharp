using System;
using System.Collections;
using System.Collections.Generic;

namespace c_sharp_lab2.Properties
{
    public class ManageProduct
    {
        public List<Product> pList = new List<Product>();
        private int idIcrement = 0;
        public void setInfo()
        {
            Console.Write("them san pham moi\n");
            Console.WriteLine("======================");
            
            int prdId = this.idIcrement++;
            Console.WriteLine("nhap ten san pham");
            String prdName = Console.ReadLine();
            Console.WriteLine("nhap gia san pham");
            double prdPrice = Double.Parse(Console.ReadLine());
            Console.WriteLine("nhap so luong san pham");
            int prdQty = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhap thu tu san pham");
            int prdDesc = Int32.Parse(Console.ReadLine());
            
            Product p = new Product(prdId, prdName, prdPrice, prdQty, prdDesc);
            pList.Add(p);
        }
        
        public void getInfo()
        {
            foreach (Product p in pList)
            {
                Console.WriteLine("======================");
                Console.WriteLine("id    "+p.Id);
                Console.WriteLine("name  "+p.Name);
                Console.WriteLine("price "+p.Price);
                Console.WriteLine("qty   "+p.Qty);
                Console.WriteLine("desc  "+p.Desc);
                var imgMsg = "";
                if (p.Gallery.Count == 0)
                {
                    imgMsg = "khong co anh cua san pham nay";
                }
                else
                {
                    foreach (string s in p.Gallery)
                    {
                        imgMsg += s+" | ";
                    }
                }
                Console.WriteLine("image: "+imgMsg);
                Console.WriteLine("======================");
            }
        }

        public void checkStock()
        {
            foreach (Product p in pList)
            {
                if (p.Qty > 0)
                {
                    Console.WriteLine(p.Name+": con hang ("+p.Qty+")");
                }
                else
                {
                    Console.WriteLine(p.Name+" het hang");
                }

            }
        }

        public void getProductName()
        {
            foreach (Product p in pList)
            {
                Console.WriteLine("id: "+p.Id+" ten san pham :"+p.Name);
            }
        }
        public void addImageToGallery()
        {
            Console.WriteLine("chon san pham muon them anh");
            this.getProductName();
            int prdPicked = Int32.Parse(Console.ReadLine());

            foreach (Product p in pList)
            {
                if (p.Id == prdPicked)
                {
                    if (p.Gallery.Count == 10)
                    {
                        Console.WriteLine("da du 10 anh, can xoa bot anh r thu lai");
                    }
                    else
                    {
                        Console.WriteLine("nhap ten dan anh can them");
                        p.Image = Console.ReadLine();
                        p.Gallery.Add(p.Image);
                    }
                }
                break; 
            }
        }

        public void deleteImageFromGallery()
        {
            Console.WriteLine("chon san pham muon xoa anh");
            this.getProductName();
            int prdPicked = Int32.Parse(Console.ReadLine());

            foreach (Product p in pList)
            {
                if (p.Id == prdPicked)
                {
                    
                    Console.WriteLine("chon vi tri anh muon xoa");
                    for (int i = 0; i < p.Gallery.Count; i++)
                    {
                        Console.WriteLine(i+". ten anh: "+p.Gallery[i]);
                    }
                    int imagePicker = Int32.Parse(Console.ReadLine());
                    String tempImage = p.Gallery[imagePicker];
                    p.Gallery.RemoveAt(imagePicker);
                    Console.WriteLine("xoa thanh cong anh cua san pham :"+p.Name+" ,ten anh : "+tempImage);
                }
                break;
            }
        }
    }
}