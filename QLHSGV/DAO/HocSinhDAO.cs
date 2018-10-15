using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHSGV.EF;

namespace QLHSGV.DAO
{   
    public class HocSinhDAO
    {
        HSGVContext db = new HSGVContext();

        public List<HocSinh> ListAll()
        {
            return db.HocSinhs.ToList();
        }

        public bool Insert(HocSinh hs)
        {
            HocSinh gv = GetByID(hs.MaHS);
            if (gv == null)
            {
                db.HocSinhs.Add(hs);
                db.SaveChanges();
                return true;
            }
            return false;
        } 
        public bool Update(HocSinh hs)
        {
            var dbEntry = db.HocSinhs.Find(hs.MaHS);
            if(dbEntry == null)
            {
                return false;
            }
            else
            {
                dbEntry.HoTen = hs.HoTen;
                dbEntry.DiaChi = hs.DiaChi;
                dbEntry.GT = hs.GT;
                dbEntry.TenLop = hs.TenLop;
                dbEntry.NgaySinh = hs.NgaySinh;
            }
            db.SaveChanges();
            return true;
        }
        public bool Delete(string MaHS)
        {
            var dbEntry = db.HocSinhs.Find(MaHS);
            if(dbEntry == null)
            {
                return false;
            }
            else
            {
                db.HocSinhs.Remove(dbEntry);
                db.SaveChanges();
                return true;
            }
        }
        public List<HocSinh> Search(string key)
        {
            return db.HocSinhs.Where(x => x.MaHS.Contains(key) || x.HoTen.Contains(key)|| x.TenLop.Contains(key) || x.NgaySinh.ToString().Contains(key)|| x.GT.Contains(key) || x.DiaChi.Contains(key)).ToList();
        }
        public HocSinh GetByID(string MaGV)
        {
            return db.HocSinhs.SingleOrDefault(x => x.MaHS == MaGV);
        }
    }
}
