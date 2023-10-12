using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDe
{
    public class BoCanhCung : ConTrung
    {
        private int SoCanh;
        public BoCanhCung()
        {
        }

        public BoCanhCung(int iD, string tenLoai, string moiTruong, int soCanh) 
            : base(iD, tenLoai, moiTruong)
        {
            this.SoCanh = soCanh;
        }

        public void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine("So canh:"+ SoCanh);
        }


        public void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("So canh:");
            this.SoCanh = int.Parse(Console.ReadLine());
        }

    }
}
