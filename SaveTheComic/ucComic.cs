using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveTheComic
{
    public partial class ucComic : UserControl
    {
        public Comic c = new Comic();
        string str;

        public ucComic(Comic comic)
        {
            InitializeComponent();
            labName.Text = comic.Name;
            labChap.Text = comic.Chap.ToString();
            labDate.Text = comic.Date.ToString("dd/MM/yyyy");
            picAnh.Image = Image.FromFile("Anh\\" + comic.Anh);
            picAnh.Name = comic.Name;
            str = comic.Name;
            if (comic.Hot != 1)
                this.labHot.Hide();
            this.c = comic;
        }

        
    }
}
