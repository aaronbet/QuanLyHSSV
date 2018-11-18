
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHSGV.EF;

namespace QLHSGV.DAO
{   
    public  class GiaoVienDAO
    {



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
        }using System;
        HSGVContext db = new HSGVContext();

        public List<GiaoVien> ListAll()
        {
            return db.GiaoViens.ToList();
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
