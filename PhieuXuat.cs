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
    public partial class PhieuXuat : Form
    {
        public PhieuXuat()
        {
            InitializeComponent();
        }

        private void PhieuXuat_Load(object sender, EventArgs e)
        {
            // Tạo kết nối
            SqlConnection connection = KetNoi.connectDB();
            // Load dữ liệu vào DataGridView khi form được load
            LoadDataToDataGridView(connection);
            // Chỉnh sửa tiêu đề của các cột trong DataGridView
            dataGridViewPX.Columns[0].HeaderText = "Mã phiếu xuất";
            dataGridViewPX.Columns[1].HeaderText = "Mã nhân viên";
            dataGridViewPX.Columns[2].HeaderText = "Mã xe máy";
            dataGridViewPX.Columns[3].HeaderText = "Ngày xuất";
            dataGridViewPX.Columns[4].HeaderText = "Số lượng";
        }
        private void LoadDataToDataGridView(SqlConnection connection)
        {
            try
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SQL
                string query = "SELECT * FROM PhieuXuat";

                // Tạo DataAdapter để lấy dữ liệu từ SQL Server
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Tạo DataTable để chứa dữ liệu
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu từ DataAdapter vào DataTable
                adapter.Fill(dataTable);

                // Hiển thị dữ liệu từ DataTable lên DataGridView
                dataGridViewPX.DataSource = dataTable;
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

        private void dataGridViewPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = dataGridViewPX.Rows[e.RowIndex];

                // Hiển thị dữ liệu từ các ô trong hàng đó lên các controls
                textMaPX.Text = row.Cells[0].Value.ToString();
                textMaNV.Text = row.Cells[1].Value.ToString();
                textMaXM.Text = row.Cells[2].Value.ToString();
                dateTimePickerNX.Value = Convert.ToDateTime(row.Cells[3].Value);
                textSL.Text = row.Cells[4].Value.ToString();
            }
        }

        public void XoaTrang()
        {
            textMaPX.Text = "";
            textMaNV.Text = "";
            textMaXM.Text = "";
            dateTimePickerNX.Value = DateTime.Now;
            textSL.Text = "";
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control trên form
            string maPX = textMaPX.Text;
            string maNV = textMaNV.Text;
            string maXM = textMaXM.Text;
            DateTime ngayXuat = dateTimePickerNX.Value;
            int soLuong = 0;

            // Kiểm tra và chuyển đổi giá trị của số lượng từ string sang int
            if (!int.TryParse(textSL.Text, out soLuong))
            {
                MessageBox.Show("Số lượng phải là một số nguyên.");
                return;
            }

            // Tạo câu lệnh SQL INSERT
            string query = "INSERT INTO PhieuXuat (MaPhieu, MaNhanVien, MaXeMay, NgayXuat, SoLuong) " +
                           "VALUES (@MaPhieu, @MaNhanVien, @MaXeMay, @NgayXuat, @SoLuong)";

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
                        command.Parameters.AddWithValue("@MaPhieu", maPX);
                        command.Parameters.AddWithValue("@MaNhanVien", maNV);
                        command.Parameters.AddWithValue("@MaXeMay", maXM);
                        command.Parameters.AddWithValue("@NgayXuat", ngayXuat);
                        command.Parameters.AddWithValue("@SoLuong", soLuong);

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

        private void buttonSua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control trên form
            string maPX = textMaPX.Text;
            string maNV = textMaNV.Text;
            string maXM = textMaXM.Text;
            DateTime ngayXuat = dateTimePickerNX.Value;
            int soLuong = 0;

            // Kiểm tra và chuyển đổi giá trị của số lượng từ string sang int
            if (!int.TryParse(textSL.Text, out soLuong))
            {
                MessageBox.Show("Số lượng phải là một số nguyên.");
                return;
            }

            // Tạo câu lệnh SQL UPDATE
            string query = "UPDATE PhieuXuat SET MaNhanVien = @MaNhanVien, MaXeMay = @MaXeMay, NgayXuat = @NgayXuat, SoLuong = @SoLuong WHERE MaPhieu = @MaPhieu";

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
                        command.Parameters.AddWithValue("@MaPhieu", maPX);
                        command.Parameters.AddWithValue("@MaNhanVien", maNV);
                        command.Parameters.AddWithValue("@MaXeMay", maXM);
                        command.Parameters.AddWithValue("@NgayXuat", ngayXuat);
                        command.Parameters.AddWithValue("@SoLuong", soLuong);

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
            // Lấy mã phiếu xuất từ control
            string maPX = textMaPX.Text;

            // Xác nhận việc xóa dữ liệu
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Tạo câu lệnh SQL DELETE
                string query = "DELETE FROM PhieuXuat WHERE MaPhieu = @MaPhieu";

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
                            command.Parameters.AddWithValue("@MaPhieu", maPX);

                            // Thực thi câu lệnh SQL DELETE
                            int rowsAffected = command.ExecuteNonQuery();

                            // Kiểm tra xem có dòng nào bị xóa không
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa dữ liệu thành công!");
                                connection.Close();

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
            // Lấy ngày tìm kiếm từ datetimepickerTK và chuyển đổi định dạng
            string ngayTK = dateTimePickerTK.Value.ToString("yyyy-MM-dd");

            try
            {
                // Tạo kết nối
                using (SqlConnection connection = KetNoi.connectDB())
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT * FROM PhieuXuat WHERE NgayXuat = @NgayXuat";

                    // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho câu lệnh SQL
                        command.Parameters.AddWithValue("@NgayXuat", ngayTK);

                        // Tạo DataAdapter để lấy dữ liệu từ SQL Server
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        // Tạo DataTable để chứa dữ liệu
                        DataTable dataTable = new DataTable();

                        // Đổ dữ liệu từ DataAdapter vào DataTable
                        adapter.Fill(dataTable);

                        // Hiển thị dữ liệu từ DataTable lên DataGridView
                        dataGridViewPX.DataSource = dataTable;

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
    }
}
