using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace SaveTheComic
{
    public partial class Form1 : Form
    {
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;

        public List<Comic> listComic = new List<Comic>();
        public Comic c;
        public List<ucComic> listUCComic = new List<ucComic>();

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            docFileComic();
            loadFlowLayout();
            cboLoc.Items.Add("Lần đọc gần nhất");
            cboLoc.Items.Add("Lần đọc trễ nhất");
            Form1.Alert("Hello !"  , AlertForm.enmType.Success);
        }

        public void loadFlowLayout()
        {
            listUCComic.Clear();
            flowLayoutPanel1.Controls.Clear();

            foreach (Comic comic in listComic)
            {
                ucComic uc = new ucComic(comic);
                listUCComic.Add(uc);
                uc.picAnh.Click += new EventHandler(pictureBoxClick);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        public void pictureBoxClick(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            ucComic uc;
            
            if (this.c != null)
            {
                uc = listUCComic.FirstOrDefault(x => x.c.Name == this.c.Name);
                if (uc == null)
                    return;
                uc.BorderStyle = BorderStyle.None;
            }
            this.c = this.listComic.FirstOrDefault(x => x.Name == pb.Name);
            uc = listUCComic.FirstOrDefault(x => x.c.Name == pb.Name);
            uc.BorderStyle = BorderStyle.FixedSingle;
        }

        public void docFileComic()
        {
            listComic.Clear();
            try
            {
                FileStream fs = new FileStream("Comic\\comic.txt", FileMode.Open);
                StreamReader rd = new StreamReader(fs, Encoding.UTF8);
                int n = int.Parse(rd.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Comic comic = new Comic();
                    comic.Name = rd.ReadLine();
                    comic.Chap = int.Parse(rd.ReadLine());
                    comic.Date = DateTime.ParseExact(rd.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    comic.Anh = rd.ReadLine();
                    comic.Loai = rd.ReadLine();
                    comic.Hot = int.Parse(rd.ReadLine());
                    comic.Mota = rd.ReadLine();
                    listComic.Add(comic);
                }
                rd.Close();
            }
            catch
            {
                MessageBox.Show("File does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormComic fComic = new FormComic();
            fComic.listComic = this.listComic;
            fComic.xuly = "Thêm";
            fComic.FormClosed += new FormClosedEventHandler(form_close);
            fComic.ShowDialog();
        }

        public void form_close(object sender, FormClosedEventArgs e)
        {
            docFileComic();
            loadFlowLayout();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.c == null)
                return;
            Comic comic = c;

            FormComic fComic = new FormComic();
            fComic.listComic = this.listComic;
            fComic.comic = comic;
            fComic.xuly = "Sửa";
            fComic.fileName = comic.Anh;
            fComic.FormClosed += new FormClosedEventHandler(form_close);
            fComic.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.c == null)
                return;

            this.listComic.Remove(this.c);
            ghiFileComic();
            Form1.Alert("Đã xoá " + this.c.Name, AlertForm.enmType.Error);
            this.c = null;
            loadFlowLayout();
        }

        public void ghiFileComic()
        {
            FileStream fs = new FileStream("Comic\\comic.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(fs, Encoding.UTF8);
            s.WriteLine(listComic.Count());
            foreach (Comic comic in listComic)
            {
                s.WriteLine(comic.Name);
                s.WriteLine(comic.Chap);
                s.WriteLine(comic.Date.ToString("dd/MM/yyyy"));
                s.WriteLine(comic.Anh);
                s.WriteLine(comic.Loai);
                s.WriteLine(comic.Hot);
                s.WriteLine(comic.Mota);
            }
            s.Flush();
            fs.Close();
        }

        private void sideBar_Animation(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            sideBar.Height = btn.Height;
            sideBar.Top = btn.Top;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            sideBar_Animation(sender, e);
            docFileComic();
            loadFlowLayout();
        }

        private void btnManhwa_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            sideBar_Animation(sender, e);
            docFileComic();
            listComic = listComic.Where(x => x.Loai == btn.Text).ToList();
            loadFlowLayout();
        }

        public static void Alert(string msg, AlertForm.enmType type)
        {
            AlertForm frm = new AlertForm();
            frm.showAlert(msg, type);
        }

        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoc.SelectedItem.ToString() == "Lần đọc trễ nhất")
            {
                this.listComic = this.listComic.OrderBy(x => x.Date).ToList();
                loadFlowLayout();
            }
            else
            {
                this.listComic = this.listComic.OrderByDescending(x => x.Date).ToList();
                loadFlowLayout();
            }
        }
    }
}
