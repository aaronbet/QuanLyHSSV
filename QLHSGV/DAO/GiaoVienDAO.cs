using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHSGV.EF;

namespace QLHSGV.DAO
{   
    public  class GiaoVienDAO
    {
        HSGVContext db = new HSGVContext();

        public List<GiaoVien> ListAll()
        {
            return db.GiaoViens.ToList();
        }

        public bool Insert(GiaoVien hs)
        {
            GiaoVien gv = GetByID(hs.MaGV);
            if (gv == null)
            {
                db.GiaoViens.Add(hs);
                db.SaveChanges();
                return true;
            }
            return false;
        } 
        public bool Update(GiaoVien hs)
        {
            var dbEntry = db.GiaoViens.Find(hs.MaGV);
            if(dbEntry == null)
            {
                return false;
            }
            else
            {
                dbEntry.HoTen = hs.HoTen;
                dbEntry.DiaChi = hs.DiaChi;
                dbEntry.GT = hs.GT;
                dbEntry.MonHoc = hs.MonHoc;
                dbEntry.NgaySinh = hs.NgaySinh;
            }
            db.SaveChanges();
            return true;
        }
        public bool Delete(string MaHS)
        {
            var dbEntry = db.GiaoViens.Find(MaHS);
            if(dbEntry == null)
            {
                return false;
            }
            else
            {
                db.GiaoViens.Remove(dbEntry);
                db.SaveChanges();
                return true;
            }
        }
        public List<GiaoVien> Search(string key)
        {
            return db.GiaoViens.Where(x => x.MaGV.Contains(key) || x.HoTen.Contains(key)|| x.MonHoc.Contains(key) || x.NgaySinh.ToString().Contains(key)|| x.GT.Contains(key) || x.DiaChi.Contains(key)).ToList();
        }
        public GiaoVien GetByID(string MaGV)
        {
            return db.GiaoViens.SingleOrDefault(x => x.MaGV == MaGV);
        }
        public List<string> GetGvName()
        {
            var list = from q in db.GiaoViens
                       select q.HoTen;
            return list.ToList();
        }
        public string GetIDbyName(string name)
        {
            var data = db.GiaoViens.SingleOrDefault(x => x.HoTen == name);
            return data.MaGV;
        }
        public string GetMonHocByGv(string gv)
        {
            return db.GiaoViens.SingleOrDefault(x => x.HoTen == gv).MonHoc;
        }
    }
}
