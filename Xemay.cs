using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXeMay
{
    public partial class Xemay : Form
    {
        public Xemay()
        {
            InitializeComponent();
        }

        private void Xemay_Load(object sender, EventArgs e)
        {
            // Tạo kết nối
            SqlConnection connection = KetNoi.connectDB();
            // Load dữ liệu vào DataGridView khi form được load
            LoadDataToDataGridView(connection);
            // Chỉnh sửa tiêu đề của các cột trong DataGridView
            dataGridViewXeMay.Columns[0].HeaderText = "Mã xe máy";
            dataGridViewXeMay.Columns[1].HeaderText = "Tên xe máy";
            dataGridViewXeMay.Columns[2].HeaderText = "Hãng sản xuất";
            dataGridViewXeMay.Columns[3].HeaderText = "Năm sản xuất";
            dataGridViewXeMay.Columns[4].HeaderText = "Giá bán";
        }
        private void LoadDataToDataGridView(SqlConnection connection)
        {
            try
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SQL
                string query = "SELECT * FROM XeMay";

                // Tạo DataAdapter để lấy dữ liệu từ SQL Server
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Tạo DataTable để chứa dữ liệu
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu từ DataAdapter vào DataTable
                adapter.Fill(dataTable);

                // Hiển thị dữ liệu từ DataTable lên DataGridView
                dataGridViewXeMay.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra
                MessageBox.Show("Lỗi khi tải dữ liệu từ SQL Server: " + ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối được đóng sau khi sử dụng
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control trên form
            string maXM = textMaXM.Text;
            string tenXM = textTenXM.Text;
            string hangSx = textHangsx.Text;
            string namSx = textBoxNamsx.Text;
            string giaBan = textGiaban.Text;
            // Tạo câu lệnh SQL INSERT
            string query = "INSERT INTO XeMay (MaXeMay, TenXeMay, HangSanXuat, NamSanXuat, GiaBan) " +
                           "VALUES (@MaXeMay, @TenXeMay, @HangSanXuat, @NamSanXuat, @GiaBan)";

            try
            {
                // Tạo kết nối
                using (SqlConnection connection = KetNoi.connectDB())
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số cho câu lệnh SQL
                        command.Parameters.AddWithValue("@MaXeMay", maXM);
                        command.Parameters.AddWithValue("@TenXeMay", tenXM);
                        command.Parameters.AddWithValue("@HangSanXuat", hangSx);
                        command.Parameters.AddWithValue("@NamSanXuat", namSx);
                        command.Parameters.AddWithValue("@GiaBan", giaBan);

                        // Thực thi câu lệnh SQL INSERT
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có dòng nào được thêm vào không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm dữ liệu thành công!");
                            connection.Close();

                            // Load lại dữ liệu sau khi thêm
                            LoadDataToDataGridView(connection);

                            // Xóa trắng các control
                            XoaTrang();
                        }
                        else
                        {
                            MessageBox.Show("Thêm dữ liệu không thành công!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
        }

        public void XoaTrang()
        {
            textMaXM.Text = "";
            textTenXM.Text = "";
            textHangsx.Text = "";
            textBoxNamsx.Text = "";
            textGiaban.Text = "";
        }

        private void dataGridViewXeMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = dataGridViewXeMay.Rows[e.RowIndex];

                // Hiển thị dữ liệu từ các ô trong hàng đó lên các controls
                textMaXM.Text = row.Cells[0].Value.ToString();
                textTenXM.Text = row.Cells[1].Value.ToString();
                textHangsx.Text = row.Cells[2].Value.ToString();
                textBoxNamsx.Text = row.Cells[3].Value.ToString();
                textGiaban.Text = row.Cells[4].Value.ToString();
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control trên form
            string maXM = textMaXM.Text;
            string tenXM = textTenXM.Text;
            string hangSx = textHangsx.Text;
            int namSx = 0;
            decimal giaBan = 0;

            // Chuyển đổi giá trị của namSx từ string sang int
            if (!int.TryParse(textBoxNamsx.Text, out namSx))
            {
                // Xử lý nếu không thể chuyển đổi
                MessageBox.Show("Năm sản xuất phải là một số nguyên.");
                return;
            }

            // Chuyển đổi giá trị của giaBan từ string sang decimal
            if (!decimal.TryParse(textGiaban.Text, out giaBan))
            {
                // Xử lý nếu không thể chuyển đổi
                MessageBox.Show("Giá bán phải là một số.");
                return;
            }

            // Tạo câu lệnh SQL UPDATE
            string query = "UPDATE XeMay SET TenXeMay = @TenXeMay, HangSanXuat = @HangSanXuat, NamSanXuat = @NamSanXuat, GiaBan = @GiaBan WHERE MaXeMay = @MaXeMay";

            try
            {
                // Tạo kết nối
                using (SqlConnection connection = KetNoi.connectDB())
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số cho câu lệnh SQL
                        command.Parameters.AddWithValue("@MaXeMay", maXM);
                        command.Parameters.AddWithValue("@TenXeMay", tenXM);
                        command.Parameters.AddWithValue("@HangSanXuat", hangSx);
                        command.Parameters.AddWithValue("@NamSanXuat", namSx);
                        command.Parameters.AddWithValue("@GiaBan", giaBan);

                        // Thực thi câu lệnh SQL UPDATE
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có dòng nào được sửa không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa dữ liệu thành công!");
                            connection.Close();

                            // Load lại dữ liệu sau khi sửa
                            LoadDataToDataGridView(connection);

                            // Xóa trắng các control
                            XoaTrang();
                        }
                        else
                        {
                            MessageBox.Show("Sửa dữ liệu không thành công!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            // Lấy mã xe máy từ control
            string maXM = textMaXM.Text;

            // Xác nhận việc xóa dữ liệu
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Tạo câu lệnh SQL DELETE
                string query = "DELETE FROM XeMay WHERE MaXeMay = @MaXeMay";

                try
                {
                    // Tạo kết nối
                    using (SqlConnection connection = KetNoi.connectDB())
                    {
                        // Mở kết nối
                        connection.Open();

                        // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm tham số cho câu lệnh SQL
                            command.Parameters.AddWithValue("@MaXeMay", maXM);

                            // Thực thi câu lệnh SQL DELETE
                            int rowsAffected = command.ExecuteNonQuery();

                            // Kiểm tra xem có dòng nào bị xóa không
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa dữ liệu thành công!");
                                connection.Close ();

                                // Load lại dữ liệu sau khi xóa
                                LoadDataToDataGridView(connection);

                                // Xóa trắng các control
                                XoaTrang();
                            }
                            else
                            {
                                MessageBox.Show("Không có dữ liệu nào được xóa!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý nếu có lỗi xảy ra
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
                }
            }
        }

        private void buttonTk_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ control tìm kiếm
            string tuKhoa = textTimkiem.Text.Trim();
            // Kiểm tra xem người dùng đã nhập dữ liệu hay chưa
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                try
                {
                    // Tạo kết nối
                    using (SqlConnection connection = KetNoi.connectDB())
                    {
                        // Mở kết nối
                        connection.Open();

                        // Tạo câu truy vấn SQL
                        string query = "SELECT * FROM XeMay WHERE TenXeMay LIKE @TuKhoa";


                        // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm tham số cho câu lệnh SQL
                            command.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");

                            // Tạo DataAdapter để lấy dữ liệu từ SQL Server
                            SqlDataAdapter adapter = new SqlDataAdapter(command);

                            // Tạo DataTable để chứa dữ liệu
                            DataTable dataTable = new DataTable();

                            // Đổ dữ liệu từ DataAdapter vào DataTable
                            adapter.Fill(dataTable);

                            // Hiển thị dữ liệu từ DataTable lên DataGridView
                            dataGridViewXeMay.DataSource = dataTable;

                            // Kiểm tra xem có dữ liệu trả về hay không
                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("Không tìm thấy dữ liệu!");
                                connection.Close ();
                                LoadDataToDataGridView(connection);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý nếu có lỗi xảy ra
                    MessageBox.Show("Lỗi khi tìm kiếm dữ liệu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên xe máy cần tìm kiếm!");
            }
        }
    }
}
