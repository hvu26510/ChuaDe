using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Menu();
        }
        static void Menu()
        {
            SERVICE service = new SERVICE();
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Chon chuc nang:");
                Console.WriteLine("1.Nhập danh sách đối tượng (1đ), Khi nhập có hỏi tiếp hay không? (0,5đ)");
                Console.WriteLine("2.Xuất danh sách đối tượng (1đ)");
                Console.WriteLine("3.Xuất các ConTrung sống ở trong rừng(1 đ)");
                Console.WriteLine("4.Sắp xếp đối tượng theo ID giảm dần(1đ)");
                Console.WriteLine("5.Thoát (1 đ)");
                Console.WriteLine("6.KeThua");
                string cn = Console.ReadLine();
                if (cn == "5")
                {
                    break;
                }
                switch (cn)
                {
                    case "1": service.ThemConTrung(); break;
                    case "2": service.XuatDanhSach(); break;
                    case "3": service.XuatConTrungTrongRung(); break;
                    case "4": service.SortListConTrungDESCbyID(); break;
                    case "6": service.KeThua(); break;
                    default:
                        Console.WriteLine("Chuc nang ban chon khong ton tai"); break;
                }
                Console.WriteLine("Press a button to continue");
                Console.ReadLine();


            }
        }
    }
}
