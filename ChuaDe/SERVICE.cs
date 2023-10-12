using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDe
{
    public class SERVICE
    {
        List<ConTrung> conTrungs = new List<ConTrung>();

        public void ThemConTrung()
        {
            
            while (true)
            {
                ConTrung ct = new ConTrung();
                ct.NhapThongTin();
                conTrungs.Add(ct);

                Console.WriteLine("Nhap tiep? (Y/N)");
                string isContinue = Console.ReadLine();
                if(isContinue != "Y")
                {
                    break;
                }

            }
        }

        public void XuatDanhSach()
        {
            foreach(ConTrung ct in conTrungs)
            {
                ct.InThongTin();
            }
        }

        public void XuatConTrungTrongRung()
        {
            foreach (ConTrung ct in conTrungs)
            {
                if(ct.getMoiTruong() == "Rung")
                {
                    ct.InThongTin();
                }
            }
        }

        public void SortListConTrungDESCbyID()
        {
            for(int i = 0; i < conTrungs.Count - 1; i++)
            {
                for(int j = i+1; j< conTrungs.Count; j++)
                {
                    if (conTrungs[i].getID() < conTrungs[j].getID())
                    {
                        ConTrung tempCT = conTrungs[i];
                        conTrungs[i] = conTrungs[j];
                        conTrungs[j] = tempCT;
                    }
                }
            }
        }

        public void KeThua()
        {
            // khoi tao khong tham so
            BoCanhCung bcc = new BoCanhCung();

            bcc.NhapThongTin();
            bcc.InThongTin();

            //khoi tao co tham so
            BoCanhCung bcc1 = new BoCanhCung(1, "BoHung","Duoi dat", 4);
        }
    }
}
