using System;
using c_sharp_lab2.Properties;

namespace c_sharp_lab2
{
    internal class Program
    {
        public static void showMenu()
        {
            Console.WriteLine("--------MENU---------");
            Console.WriteLine("1. Nhap thong tin Product.");
            Console.WriteLine("2. Hien thi thong tin Product.");
            Console.WriteLine("3. Thong bao con/het hang");
            Console.WriteLine("4. Them anh vao Gallery");
            Console.WriteLine("5. Xoa anh trong Gallery");
            Console.WriteLine("----------------------");
            Console.WriteLine("6. Nhap thong tin Khach hang.");
            Console.WriteLine("7. Them san pham vao gio hang.");
            Console.WriteLine("8. Xoa san pham khoi gio hang.");
            Console.WriteLine("9. Xem tong tien.");
            Console.WriteLine("10. Xem chi tiet thong tin gio hang.");
            Console.WriteLine("----------------------");
            Console.WriteLine("11-------");
            Console.WriteLine("| Exit. |");
            Console.WriteLine("---------");
            Console.WriteLine("please chose");
        }

        public static void Main(string[] args)
        {
            // ManageProduct mp = new ManageProduct();
            ManageCart mc = new ManageCart();

            String choose = null;
            Boolean exit = false;
            showMenu();
            while (true) {
                choose = Console.ReadLine();
                switch (choose) {
                    case "1": ;
                        mc.setInfo();
                        break;
                    case "2": ;
                        mc.getInfo();;
                        break;
                    case "3": ;
                        mc.checkStock();
                        break;
                    case "4": ;
                        while (true)
                        {
                            mc.addImageToGallery();
                            Console.WriteLine("ban muon add them anh k? (1/2)");
                            int choose2 = Int32.Parse(Console.ReadLine());
                            if (choose2 == 2)
                            {
                                break;
                            }
                        }
                        break;
                    case "5": ;
                            mc.deleteImageFromGallery();
                        break;
                    case "6":
                            mc.getInfo();
                        break;
                    case "7":
                            mc.addToCart();
                        break;
                    case "8":
                            mc.removeFromCart();
                        break;
                    case "9":
                            mc.grandTotal();
                        break;
                    case "10":
                            mc.showAllCart();
                        break;
                    case "11":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("invalid! hello world !");
                        break;
                }
                if (exit) {
                    break;
                }
                showMenu();
            }
        }
    }
}