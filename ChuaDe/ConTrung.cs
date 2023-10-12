using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDe
{
    public class ConTrung
    {
        private int ID;
        private string TenLoai;
        private string MoiTruong;

        public int getID()
        {
            return this.ID;
        }
        public string getMoiTruong()
        {
            return this.MoiTruong;
        }

        public ConTrung()
        {
        }

        public ConTrung(int iD, string tenLoai, string moiTruong)
        {
            ID = iD;
            TenLoai = tenLoai;
            MoiTruong = moiTruong;
        }

        public void NhapThongTin()
        {
            Console.WriteLine("ID: ");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Ten Loai: ");
            TenLoai = Console.ReadLine();
            Console.WriteLine("Moi Truong: " );
            MoiTruong= Console.ReadLine();
        }

        public void InThongTin()
        {
            Console.WriteLine("ID: "+ ID);
            Console.WriteLine("Ten Loai: "+TenLoai);
            Console.WriteLine("Moi Truong: "+ MoiTruong);
        }
    }
}
