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
using SaveTheComic.DAL;
using SaveTheComic.BUS;

namespace SaveTheComic.GUI
{
    public partial class Form1 : Form
    {
        public List<ucComic> ListUCTruyens = new List<ucComic>();
        public ucComic curUC;

        #region Move Form
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        #endregion

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
            loadAllTruyen();
            loadFlowLayout();

            cboLoc.Items.Add("Lần đọc gần nhất");
            cboLoc.Items.Add("Lần đọc trễ nhất");
            AlertForm.Alert("Hello !"  , AlertForm.enmType.Success);
        }

        public void loadAllTruyen()
        {
            this.curUC = null;
            this.ListUCTruyens.Clear();
            foreach (Truyen item in DBGet<Truyen>.getDatas())
            {
                ucComic uc = new ucComic(item);
                this.ListUCTruyens.Add(uc);
                uc.picAnh.Click += new EventHandler(pictureBoxClick);
            }
        }

        public void loadFlowLayout(int maLoai = -2)
        {
            flowLayoutPanel1.Controls.Clear();

            // Load theo loại truyện
            if (maLoai != -2 && maLoai != -1)
            {
                List<ucComic> listTemp = this.ListUCTruyens.Where(x => x.t.maLoai == maLoai && x.t.blackList == false).ToList();

                foreach (ucComic item in listTemp)
                {
                    flowLayoutPanel1.Controls.Add(item);
                }
                return;
            }

            // Load black list
            if (maLoai == -1)
            {
                List<ucComic> listBL = this.ListUCTruyens.Where(x => x.t.blackList == true).ToList();

                foreach (ucComic item in listBL)
                {
                    flowLayoutPanel1.Controls.Add(item);
                }
                return;
            }

            // Load all truyện
            foreach (ucComic item in this.ListUCTruyens)
            {
                if (item.t.blackList == true)
                    continue;
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        public void pictureBoxClick(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            
            if (this.curUC != null)
            {
                this.curUC = ListUCTruyens.FirstOrDefault(x => x.t.maTruyen == this.curUC.t.maTruyen);
                if (this.curUC == null)
                    return;
                this.curUC.BorderStyle = BorderStyle.None;
                if (this.curUC.t.maTruyen.ToString() == pb.Name && this.curUC.BorderStyle == BorderStyle.None)
                {
                    this.curUC = null;
                    return;
                }
            }
            this.curUC = ListUCTruyens.FirstOrDefault(x => x.t.maTruyen.ToString() == pb.Name);
            this.curUC.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormComic fComic = new FormComic();
            fComic.xuly = "Thêm";
            fComic.FormClosed += new FormClosedEventHandler(form_close);
            fComic.ShowDialog();
        }

        public void form_close(object sender, FormClosedEventArgs e)
        {
            loadAllTruyen();
            loadFlowLayout();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.curUC == null)
            {
                AlertForm.Alert("Bạn chưa chọn truyện", AlertForm.enmType.Info);
                return;
            }

            FormComic fComic = new FormComic();
            fComic.xuly = "Sửa";
            fComic.t = this.curUC.t;
            fComic.FormClosed += new FormClosedEventHandler(form_close);
            fComic.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.curUC != null)
                BUSTruyen.xoaTruyen(this.curUC.t);
            loadAllTruyen();
            loadFlowLayout();
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
            loadFlowLayout();
        }

        private void btnManhwa_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            sideBar_Animation(sender, e);
            loadFlowLayout(int.Parse(btn.Tag.ToString()));
        }

        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoc.SelectedItem.ToString() == "Lần đọc trễ nhất")
            {
                this.ListUCTruyens = this.ListUCTruyens.OrderBy(x => x.t.ngayDocCuoi).ToList();
                loadFlowLayout();
            }
            else
            {
                this.ListUCTruyens = this.ListUCTruyens.OrderByDescending(x => x.t.ngayDocCuoi).ToList();
                loadFlowLayout();
            }
        }

        private void btnBlackList_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            sideBar_Animation(sender, e);
            loadFlowLayout(int.Parse(btn.Tag.ToString()));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            List<ucComic> searchList = this.ListUCTruyens.Where(x => x.t.tenTruyen.Contains(txtSearch.Text)).ToList();

            foreach (ucComic item in searchList)
            {
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        
    }
}
