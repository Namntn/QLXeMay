using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLXeMay
{
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            // Tạo kết nối
            SqlConnection connection = KetNoi.connectDB();
            // Load dữ liệu vào DataGridView khi form được load
            LoadDataToDataGridView(connection);
            // Chỉnh sửa tiêu đề của các cột trong DataGridView
            dataGridViewNhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dataGridViewNhanvien.Columns[1].HeaderText = "Họ và tên";
            dataGridViewNhanvien.Columns[2].HeaderText = "Ngày sinh";
            dataGridViewNhanvien.Columns[3].HeaderText = "Chức vụ";
        }

        private void LoadDataToDataGridView(SqlConnection connection)
        {
            try
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SQL
                string query = "SELECT * FROM NhanVien";

                // Tạo DataAdapter để lấy dữ liệu từ SQL Server
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Tạo DataTable để chứa dữ liệu
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu từ DataAdapter vào DataTable
                adapter.Fill(dataTable);

                // Hiển thị dữ liệu từ DataTable lên DataGridView
                dataGridViewNhanvien.DataSource = dataTable;
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

        private void dataGridViewNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = dataGridViewNhanvien.Rows[e.RowIndex];

                // Hiển thị dữ liệu từ các ô trong hàng đó lên các controls
                textMaNV.Text = row.Cells[0].Value.ToString();
                textHoten.Text = row.Cells[1].Value.ToString();
                dateTimePickerNS.Value = Convert.ToDateTime(row.Cells[2].Value);
                comboChucvu.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control trên form
            string maNV = textMaNV.Text;
            string hoTen = textHoten.Text;
            DateTime ngaySinh = dateTimePickerNS.Value;
            // Kiểm tra combobox trước khi lấy giá trị
            string chucVu = comboChucvu.SelectedItem != null ? comboChucvu.SelectedItem.ToString() : string.Empty;
            // Kiểm tra xem combobox có giá trị không
            if (string.IsNullOrEmpty(chucVu))
            {
                MessageBox.Show("Vui lòng chọn chức vụ!");
                return; // Dừng việc thêm dữ liệu nếu combobox không có giá trị
            }

            // Tạo câu lệnh SQL INSERT
            string query = "INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, ChucVu) VALUES (@MaNhanVien, @HoTen, @NgaySinh, @ChucVu)";

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
                        command.Parameters.AddWithValue("@MaNhanVien", maNV);
                        command.Parameters.AddWithValue("@HoTen", hoTen);
                        command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        command.Parameters.AddWithValue("@ChucVu", chucVu);

                        // Thực thi câu lệnh SQL INSERT
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có dòng nào được thêm vào không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm nhân viên thành công!");
                            connection.Close();

                            // Load lại dữ liệu sau khi thêm
                            LoadDataToDataGridView(connection);

                            // Xóa trắng các control
                            XoaTrang();
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên không thành công!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }
        public void XoaTrang()
        {
            textMaNV.Text = "";
            textHoten.Text = "";
            dateTimePickerNS.Value = DateTime.Now;
            comboChucvu.SelectedIndex = -1; // Chọn mục đầu tiên trong combobox
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control trên form
            string maNV = textMaNV.Text;
            string hoTen = textHoten.Text;
            DateTime ngaySinh = dateTimePickerNS.Value;
            string chucVu = comboChucvu.SelectedItem.ToString();

            // Tạo câu lệnh SQL UPDATE
            string query = "UPDATE NhanVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, ChucVu = @ChucVu WHERE MaNhanVien = @MaNhanVien";

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
                        command.Parameters.AddWithValue("@MaNhanVien", maNV);
                        command.Parameters.AddWithValue("@HoTen", hoTen);
                        command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        command.Parameters.AddWithValue("@ChucVu", chucVu);

                        // Thực thi câu lệnh SQL UPDATE
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có dòng nào được sửa không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa nhân viên thành công!");
                            connection.Close();

                            // Load lại dữ liệu sau khi sửa
                            LoadDataToDataGridView(connection);

                            // Xóa trắng các control
                            XoaTrang();
                        }
                        else
                        {
                            MessageBox.Show("Sửa nhân viên không thành công!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra
                MessageBox.Show("Lỗi khi sửa nhân viên: " + ex.Message);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            // Lấy mã nhân viên từ textboxMaNV
            string maNV = textMaNV.Text;

            // Tạo câu lệnh SQL DELETE
            string query = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien";

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
                        command.Parameters.AddWithValue("@MaNhanVien", maNV);

                        // Thực thi câu lệnh SQL DELETE
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có dòng nào bị xóa không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa nhân viên thành công!");
                            connection.Close();

                            // Load lại dữ liệu sau khi xóa
                            LoadDataToDataGridView(connection);

                            // Xóa trắng các control
                            XoaTrang();
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhân viên không thành công!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
            }
        }

        private void buttonTk_Click(object sender, EventArgs e)
        {
            // Lấy giá trị nhập vào từ TextBox tìm kiếm
            string tenCanTim = textTimkiem.Text.Trim();

            // Kiểm tra xem người dùng đã nhập dữ liệu hay chưa
            if (!string.IsNullOrEmpty(tenCanTim))
            {
                try
                {
                    // Tạo kết nối
                    using (SqlConnection connection = KetNoi.connectDB())
                    {
                        // Mở kết nối
                        connection.Open();

                        // Tạo câu truy vấn SQL
                        string query = "SELECT * FROM NhanVien WHERE HoTen LIKE @TenNhanVien";

                        // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm tham số cho câu lệnh SQL
                            command.Parameters.AddWithValue("@TenNhanVien", "%" + tenCanTim + "%");

                            // Tạo DataAdapter để lấy dữ liệu từ SQL Server
                            SqlDataAdapter adapter = new SqlDataAdapter(command);

                            // Tạo DataTable để chứa dữ liệu
                            DataTable dataTable = new DataTable();

                            // Đổ dữ liệu từ DataAdapter vào DataTable
                            adapter.Fill(dataTable);

                            // Hiển thị dữ liệu từ DataTable lên DataGridView
                            dataGridViewNhanvien.DataSource = dataTable;
                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("Không tìm thấy dữ liệu!");
                                connection.Close();
                                LoadDataToDataGridView(connection);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý nếu có lỗi xảy ra
                    MessageBox.Show("Lỗi khi tìm kiếm nhân viên: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm kiếm!");
            }
        }
    }
}
