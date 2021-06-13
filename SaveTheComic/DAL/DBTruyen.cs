using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheComic.DAL
{
    class DBTruyen
    {
        public static void addData(Truyen t)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                db.Truyens.InsertOnSubmit(t);
                db.SubmitChanges();
            }
        }

        public static bool removeData(Truyen t)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                try
                {
                    Truyen data = db.Truyens.Where(x => x.maTruyen.Equals(t.maTruyen)).FirstOrDefault();
                    db.Truyens.DeleteOnSubmit(data);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static void updateData(Truyen t)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Truyen data = db.Truyens.Where(x => x.maTruyen.Equals(t.maTruyen)).FirstOrDefault();

                data.tenTruyen = t.tenTruyen;
                data.chap = t.chap;
                data.maLoai = t.maLoai;
                data.ngayDocCuoi = t.ngayDocCuoi;
                data.img = t.img;
                data.hot = t.hot;
                data.blackList = t.blackList;
                data.noiDung = t.noiDung;

                db.SubmitChanges();
            }
        }
    }
}
