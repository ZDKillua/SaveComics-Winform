using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveTheComic.DAL;


namespace SaveTheComic.GUI
{
    public partial class FormComic : Form
    {
        public string xuly = string.Empty; // Cờ xử lý add hay edit
        public Truyen t;

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

        public FormComic()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public void nhapSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormComic_Load(object sender, EventArgs e)
        {
            btnXN.Text = xuly;
            foreach (LoaiTruyen item in DBGet<LoaiTruyen>.getDatas())
            {
                cboLoai.Items.Add(item.tenLoai);
            }


        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(dlg.FileName);
                    this.labAnh.Hide();
                }
                catch
                {
                    MessageBox.Show("Bạn phải chọn file ảnh");
                }
                
            }
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0 || txtChap.Text.Length  == 0)
            {
                errorProvider1.SetError(txtName, "Không được để trống");
                errorProvider1.SetError(txtChap, "Không được để trống");
                MessageBox.Show("Nhập thiếu kìa", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Bạn chưa chọn file ảnh", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //if (btnXN.Text == "Thêm")
            //{
            //    comic = new Comic();
            //    comic.Name = txtName.Text;
            //    comic.Chap = int.Parse(txtChap.Text);
            //    comic.Loai = cboLoai.SelectedItem.ToString();
            //    comic.Date = dtpDate.Value;
            //    comic.Anh = fileName;
            //    if (chkHot.Checked)
            //        comic.Hot = 1;
            //    else
            //        comic.Hot = 0;
            //    if (txtMota.Text.Length > 0)
            //        comic.Mota = txtMota.Text;
            //    else
            //        comic.Mota = string.Empty;
            //    listComic.Add(comic);
            //    ghiFileComic();
            //    Form1.Alert("Đã thêm " + comic.Name, AlertForm.enmType.Success);
            //}
            //else
            //{
            //    Comic comic = listComic.FirstOrDefault(x => x.Name == this.comic.Name);
            //    comic.Name = txtName.Text;
            //    comic.Chap = int.Parse(txtChap.Text);
            //    comic.Loai = cboLoai.SelectedItem.ToString();
            //    comic.Date = dtpDate.Value;
            //    comic.Anh = fileName;
            //    if (txtMota.Text.Length > 0)
            //        comic.Mota = txtMota.Text;
            //    else
            //        comic.Mota = string.Empty;
            //    if (chkHot.Checked)
            //        comic.Hot = 1;
            //    else
            //        comic.Hot = 0;
            //    ghiFileComic();
            //    Form1.Alert("Thay đổi " + comic.Name + " thành công !", AlertForm.enmType.Info);
            //}
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length > 0)
                errorProvider1.SetError(txt, null);
            else
                errorProvider1.SetError(txt, "Không được để trống");
        }
    }
}
