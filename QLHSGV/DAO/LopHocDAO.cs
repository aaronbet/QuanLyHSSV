using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHSGV.EF;

namespace QLHSGV.DAO
{   
    public class LopHocDAO
    {
        HSGVContext db = new HSGVContext();

        public List<LopHoc> ListAll()
        {
            return db.LopHocs.ToList();
        }

        public bool Insert(LopHoc hs)
        {
            LopHoc gv = GetByID(hs.TenLop);
            if (gv == null)
            {
                db.LopHocs.Add(hs);
                db.SaveChanges();
                return true;
            }
            return false;
        } 
        public bool Update(LopHoc hs)
        {
            var dbEntry = db.LopHocs.Find(hs.TenLop);
            if(dbEntry == null)
            {
                return false;
            }
            else
            {
                dbEntry.QSo = hs.QSo;
            }
            db.SaveChanges();
            return true;
        }
        public bool Delete(string MaHS)
        {
            var dbEntry = db.LopHocs.Find(MaHS);
            if(dbEntry == null)
            {
                return false;
            }
            else
            {
                db.LopHocs.Remove(dbEntry);
                db.SaveChanges();
                return true;
            }
        }
        public List<LopHoc> Search(string key)
        {
            return db.LopHocs.Where(x => x.TenLop.Contains(key) || x.QSo.ToString().Contains(key)).ToList();
        }
        public LopHoc GetByID(string TebLop)
        {
            return db.LopHocs.SingleOrDefault(x => x.TenLop == TebLop);
        }
        public List<string> DSLop()
        {
            var list = from q in db.LopHocs
                       select q.TenLop;
            return list.ToList();
        }
        public List<string> GetTenLop()
        {
            var list = from q in db.LopHocs
                       select q.TenLop;
            return list.ToList();
        }
    }
}
