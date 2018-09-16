using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHSGV.EF;

namespace QLHSGV.DAO
{   
    public class ThongTinGiangDayDAO
    {
        HSGVContext db = new HSGVContext();

        public List<ThongTinGiangDayView> ListAll()
        {
            var list = from q in db.ThongTinGiangDays
                       join p in db.GiaoViens on q.MaGV equals p.MaGV
                       select new ThongTinGiangDayView()
                       {
                           MaKip = q.MaKip,
                           GiaoVien = p.HoTen,
                           MonHoc = q.MonHoc,
                           Ngay = q.Ngay,
                           SoTiet = q.SoTiet,
                           TenLop = q.TenLop
                       };
            return list.ToList();
        }

        public bool Insert(ThongTinGiangDay hs)
        {
            ThongTinGiangDay gv = GetByID(hs.MaKip);
            if (gv == null)
            {
                db.ThongTinGiangDays.Add(hs);
                db.SaveChanges();
                return true;
            }
            return false;
        } 
        public bool Update(ThongTinGiangDay hs)
        {
            var dbEntry = db.ThongTinGiangDays.Find(hs.MaKip);
            if(dbEntry == null)
            {
                return false;
            }
            else
            {
                dbEntry.MaGV = hs.MaGV;
                dbEntry.MonHoc = hs.MonHoc;
                dbEntry.Ngay = hs.Ngay;
                dbEntry.TenLop = hs.TenLop;
                dbEntry.SoTiet = hs.SoTiet;
            }
            db.SaveChanges();
            return true;
        }
        public bool Delete(string MaHS)
        {
            var dbEntry = db.ThongTinGiangDays.Find(MaHS);
            if(dbEntry == null)
            {
                return false;
            }
            else
            {
                db.ThongTinGiangDays.Remove(dbEntry);
                db.SaveChanges();
                return true;
            }
        }
        public List<ThongTinGiangDayView> Search(string key)
        {
            return new ThongTinGiangDayDAO().ListAll().Where(x => x.MaKip.Contains(key) || x.TenLop.Contains(key) || x.MonHoc.Contains(key) || x.Ngay.ToString().Contains(key) || x.SoTiet.ToString().Contains(key) || x.GiaoVien.Contains(key)).ToList();
        }
        public ThongTinGiangDay GetByID(string MaGV)
        {
            return db.ThongTinGiangDays.SingleOrDefault(x => x.MaKip == MaGV);
        }
    }
}
