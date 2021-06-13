using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveTheComic.DAL;
using System.IO;

namespace SaveTheComic.GUI
{
    public partial class ucComic : UserControl
    {
        public Truyen t;

        public ucComic(Truyen t)
        {
            InitializeComponent();
            labName.Text = t.tenTruyen;
            labChap.Text = t.chap.ToString();
            labDate.Text = t.ngayDocCuoi.Value.ToString("dd/MM/yyyy");
            if (t.hot != true)
                this.labHot.Hide();
            this.t = t;

            // Set image for pictureBox
            MemoryStream memoryStream = new MemoryStream(t.img.ToArray());
            Image img = Image.FromStream(memoryStream);
            if (img == null)
                return;
            picAnh.Image = img;
            picAnh.Name = t.maTruyen.ToString();
        }

        
    }
}
