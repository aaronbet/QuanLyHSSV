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


    }
}
