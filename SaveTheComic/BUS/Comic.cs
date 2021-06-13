using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheComic.BUS
{
    public class Comic
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        int chap;
        public int Chap
        {
            get { return chap; }
            set { chap = value; }
        }

        DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        string anh;
        public string Anh
        {
            get { return anh; }
            set { anh = value; }
        }

        string loai;
        public string Loai
        {
            get { return loai; }
            set { loai = value; }
        }

        string mota;
        public string Mota
        {
            get { return mota; }
            set { mota = value; }
        }

        int hot;
        public int Hot
        {
            get { return hot; }
            set { hot = value; }
        }

        public Comic()
        {
            this.name = this.anh = this.loai = this.mota = string.Empty;
            this.chap = this.hot = 0;
        }
        
        public Comic (string name, int chap, DateTime date, string anh, string loai, string mota, int hot)
        {
            this.name = name;
            this.chap = chap;
            this.date = date;
            this.anh = anh;
            this.loai = loai;
            this.mota = mota;
            this.hot = hot;
        }
    }
}
