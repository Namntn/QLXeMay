using QLXeMay;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
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
            }
        }

        private void buttonDN_Click(object sender, EventArgs e)
        {
            // Lấy thông tin tên đăng nhập và mật khẩu từ các control trên form
            string tenDangNhap = textTK.Text;
            string matKhau = textMK.Text;

            // Tạo kết nối tới cơ sở dữ liệu
            SqlConnection connection = KetNoi.connectDB();

            try
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SQL để kiểm tra tên đăng nhập và mật khẩu
                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                command.Parameters.AddWithValue("@MatKhau", matKhau);

                // Thực hiện truy vấn và lấy kết quả
                int result = (int)command.ExecuteScalar();

                // Kiểm tra kết quả
                if (result > 0)
                {
                    // Đăng nhập thành công, hiển thị form hoặc thực hiện các hành động khác
                    MessageBox.Show("Đăng nhập thành công!");
                    //Mở form mới sau khi đăng nhập thành công
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    // Đăng nhập không thành công, hiển thị thông báo lỗi
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra trong quá trình đăng nhập
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối được đóng sau khi sử dụng
                connection.Close();
            }

        }
    }
}
