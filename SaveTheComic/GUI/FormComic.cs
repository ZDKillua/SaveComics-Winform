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
using SaveTheComic.BUS;


namespace SaveTheComic.GUI
{
    public partial class FormComic : Form
    {
        public string xuly = string.Empty; // Cờ xử lý add hay edit
        public Truyen t = new Truyen();

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
            cboLoai.DisplayMember = "tenLoai";
            

            if (this.t.maLoai != null)
            {
                txtName.Text = t.tenTruyen;
                txtChap.Text = t.chap.ToString();
                cboLoai.SelectedItem = DBGet<LoaiTruyen>.getData("maLoai", t.maLoai.ToString()).tenLoai;
                dtpDate.Value = t.ngayDocCuoi.Value;
                chkHot.Checked = t.hot.Value;
                chkBL.Checked = t.blackList.Value;
                txtMota.Text = t.noiDung;

                MemoryStream memoryStream = new MemoryStream(t.img.ToArray());
                Image img = Image.FromStream(memoryStream);
                if (img == null)
                    return;
                pictureBox1.Image = img;
                pictureBox1.Name = t.maTruyen.ToString();
                labAnh.Hide();
                return;
            }

            cboLoai.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
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

            t.tenTruyen = txtName.Text;
            t.chap = int.Parse(txtChap.Text);
            t.maLoai = DBGet<LoaiTruyen>.getData("tenLoai", cboLoai.SelectedItem.ToString()).maLoai;
            t.ngayDocCuoi = dtpDate.Value;
            t.hot = chkHot.Checked;
            t.blackList = chkBL.Checked;
            t.noiDung = txtMota.Text;

            // lưu image vào database
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            t.img = stream.ToArray();

            
            if (btnXN.Text == "Thêm")
            {
                BUSTruyen.themTruyen(t);
            }
            else
            {
                BUSTruyen.capNhatTruyen(t);
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
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
    }
}
