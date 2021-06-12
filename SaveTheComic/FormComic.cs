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

namespace SaveTheComic
{
    public partial class FormComic : Form
    {
        public List<Comic> listComic = new List<Comic>();
        public Comic comic = new Comic(); // Comic hiện hành
        public string xuly = string.Empty; // Cờ xử lý add hay edit
        public string fileImg; // Dùng để luu tên đường dẫn khi chọn ảnh cần lưu
        public string fileName; // Dùng để lưu tên file ảnh

        // Code di chuyển khi ko có thanh tiêu đề
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

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
            docFileLoai();

            btnXN.Text = xuly;
            txtName.Text = comic.Name;
            txtChap.Text = comic.Chap.ToString();

            dtpDate.Value = this.comic.Date == DateTime.MinValue ? DateTime.Now : this.comic.Date;
            if (comic.Anh != "")
            {
                pictureBox1.Image = Image.FromFile("Anh\\" + comic.Anh);
                this.labAnh.Hide();
            }
                
            if (comic.Loai != "")
                cboLoai.SelectedItem = this.comic.Loai;

            if (comic.Hot == 1)
                chkHot.CheckState = CheckState.Checked;
            txtMota.Text = comic.Mota;
        }

        public void docFileLoai()
        {
            string filePath = "Comic\\loai.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string str in lines)
                {
                    cboLoai.Items.Add(str);
                }
                cboLoai.SelectedIndex = 0;
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileImg = dlg.FileName; // Đường dẫn khi chọn file
                fileName = dlg.FileName.Substring(dlg.FileName.LastIndexOf("\\") + 1, dlg.FileName.Length - dlg.FileName.LastIndexOf("\\") - 1); // Cắt lấy tên file ảnh

                string str = fileName.Substring(fileName.LastIndexOf(".") + 1, fileName.Length - fileName.LastIndexOf(".") - 1);

                try
                {
                    pictureBox1.Image = Image.FromFile(fileImg);
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

            // Kiểm tra ảnh đã tồn tại chưa. Nếu chưa thì lưu file ảnh
            if (listComic.FirstOrDefault(c => c.Anh == fileName) == null)
            {
                Image img = Image.FromFile(fileImg);
                img.Save("Anh\\" + fileName);
            }

            if (btnXN.Text == "Thêm")
            {
                comic = new Comic();
                comic.Name = txtName.Text;
                comic.Chap = int.Parse(txtChap.Text);
                comic.Loai = cboLoai.SelectedItem.ToString();
                comic.Date = dtpDate.Value;
                comic.Anh = fileName;
                if (chkHot.Checked)
                    comic.Hot = 1;
                else
                    comic.Hot = 0;
                if (txtMota.Text.Length > 0)
                    comic.Mota = txtMota.Text;
                else
                    comic.Mota = string.Empty;
                listComic.Add(comic);
                ghiFileComic();
                Form1.Alert("Đã thêm " + comic.Name, AlertForm.enmType.Success);
            }
            else
            {
                Comic comic = listComic.FirstOrDefault(x => x.Name == this.comic.Name);
                comic.Name = txtName.Text;
                comic.Chap = int.Parse(txtChap.Text);
                comic.Loai = cboLoai.SelectedItem.ToString();
                comic.Date = dtpDate.Value;
                comic.Anh = fileName;
                if (txtMota.Text.Length > 0)
                    comic.Mota = txtMota.Text;
                else
                    comic.Mota = string.Empty;
                if (chkHot.Checked)
                    comic.Hot = 1;
                else
                    comic.Hot = 0;
                ghiFileComic();
                Form1.Alert("Thay đổi " + comic.Name + " thành công !", AlertForm.enmType.Info);
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
    }
}
