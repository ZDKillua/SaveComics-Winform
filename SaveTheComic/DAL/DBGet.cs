using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheComic.DAL
{
    abstract class DBGet<T> where T: class
    {
        public static List<T> getDatas()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                return db.GetTable<T>().ToList();
            }
        }

        public static T getData(string columnName, string name)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                List<T> tlist = db.GetTable<T>().ToList();
                var result = tlist.FirstOrDefault(x => typeof(T).GetProperty(columnName).GetValue(x).ToString().Contains(name));

                return result;
            }
        }
    }
}
