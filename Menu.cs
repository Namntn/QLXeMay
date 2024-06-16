using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXeMay
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            // Hiển thị MessageBox hỏi người dùng có muốn thoát không
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra người dùng chọn Yes trong MessageBox
            if (result == DialogResult.Yes)
            {
                // Đóng form nếu người dùng chọn Yes
                this.Close();
                Application.Exit();
            }
        }

        private void buttonDN_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.Show();
        }

        private void buttonXM_Click(object sender, EventArgs e)
        {
            Xemay xm = new Xemay();
            xm.Show();
        }

        private void buttonPN_Click(object sender, EventArgs e)
        {
            PhieuNhap phieuNhap = new PhieuNhap();
            phieuNhap.Show();
        }

        private void buttonPX_Click(object sender, EventArgs e)
        {
            PhieuXuat phieuXuat = new PhieuXuat();
            phieuXuat.Show();
        }

        private void buttonCTPN_Click(object sender, EventArgs e)
        {
            ChiTietPN ctpn = new ChiTietPN();
            ctpn.Show();
        }

        private void buttonCTPX_Click(object sender, EventArgs e)
        {
            ChiTietPX chiTietPX = new ChiTietPX();
            chiTietPX.Show();
        }
    }
}
