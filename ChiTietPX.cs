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
    public partial class ChiTietPX : Form
    {
        public ChiTietPX()
        {
            InitializeComponent();
        }

        private void ChiTietPX_Load(object sender, EventArgs e)
        {
            // Tạo kết nối
            SqlConnection connection = KetNoi.connectDB();
            // Load dữ liệu vào DataGridView khi form được load
            LoadDataToDataGridView(connection);
            // Chỉnh sửa tiêu đề của các cột trong DataGridView
            dataGridViewCTPX.Columns[0].HeaderText = "Mã phiếu xuất";
            dataGridViewCTPX.Columns[1].HeaderText = "Tên nhân viên";
            dataGridViewCTPX.Columns[2].HeaderText = "Chức vụ";
            dataGridViewCTPX.Columns[3].HeaderText = "Tên xe máy";
            dataGridViewCTPX.Columns[4].HeaderText = "Giá bán";
            dataGridViewCTPX.Columns[5].HeaderText = "Ngày xuất";
            dataGridViewCTPX.Columns[6].HeaderText = "Số lượng";
            dataGridViewCTPX.Columns[7].HeaderText = "Doanh thu";
        }
        private void LoadDataToDataGridView(SqlConnection connection)
        {
            try
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SQL
                string query = @"
                SELECT PX.MaPhieu, NV.HoTen, NV.ChucVu, XM.TenXeMay, XM.GiaBan, PX.NgayXuat, PX.SoLuong, PX.SoLuong * XM.GiaBan 
                FROM PhieuXuat PX
                INNER JOIN NhanVien NV ON PX.MaNhanVien = NV.MaNhanVien
                INNER JOIN XeMay XM ON PX.MaXeMay = XM.MaXeMay";

                // Tạo DataAdapter để lấy dữ liệu từ SQL Server
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Tạo DataTable để chứa dữ liệu
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu từ DataAdapter vào DataTable
                adapter.Fill(dataTable);

                // Hiển thị dữ liệu từ DataTable lên DataGridView
                dataGridViewCTPX.DataSource = dataTable;
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

        private void buttonTkNV_Click(object sender, EventArgs e)
        {
            string tenNhanVien = textTimkiemNV.Text.Trim();

            // Kiểm tra xem người dùng đã nhập dữ liệu hay chưa
            if (!string.IsNullOrEmpty(tenNhanVien))
            {
                try
                {
                    // Tạo kết nối
                    using (SqlConnection connection = KetNoi.connectDB())
                    {
                        // Mở kết nối
                        connection.Open();

                        // Tạo câu truy vấn SQL
                        string query = @"
                        SELECT PX.MaPhieu, NV.HoTen, NV.ChucVu, XM.TenXeMay, XM.GiaBan, PX.NgayXuat, PX.SoLuong, PX.SoLuong * XM.GiaBan
                        FROM PhieuXuat PX
                        INNER JOIN NhanVien NV ON PX.MaNhanVien = NV.MaNhanVien
                        INNER JOIN XeMay XM ON PX.MaXeMay = XM.MaXeMay
                        WHERE NV.HoTen LIKE @TenNhanVien";

                        // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm tham số cho câu lệnh SQL
                            command.Parameters.AddWithValue("@TenNhanVien", "%" + tenNhanVien + "%");

                            // Tạo DataAdapter để lấy dữ liệu từ SQL Server
                            SqlDataAdapter adapter = new SqlDataAdapter(command);

                            // Tạo DataTable để chứa dữ liệu
                            DataTable dataTable = new DataTable();

                            // Đổ dữ liệu từ DataAdapter vào DataTable
                            adapter.Fill(dataTable);

                            // Hiển thị dữ liệu từ DataTable lên DataGridView
                            dataGridViewCTPX.DataSource = dataTable;
                            // Kiểm tra xem có dữ liệu trả về hay không
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
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm kiếm!");
            }
        }

        private void buttonTKNX_Click(object sender, EventArgs e)
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
                    string query = @"
                    SELECT PX.MaPhieu, NV.HoTen, NV.ChucVu, XM.TenXeMay, XM.GiaBan, PX.NgayXuat, PX.SoLuong, PX.SoLuong * XM.GiaBan
                    FROM PhieuXuat PX
                    INNER JOIN NhanVien NV ON PX.MaNhanVien = NV.MaNhanVien
                    INNER JOIN XeMay XM ON PX.MaXeMay = XM.MaXeMay
                    WHERE PX.NgayXuat = @NgayXuat";

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
                        dataGridViewCTPX.DataSource = dataTable;
                        // Kiểm tra xem có dữ liệu trả về hay không
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
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void buttonTKXM_Click(object sender, EventArgs e)
        {
            string tenXeMay = textBoxTkXM.Text.Trim();

            // Kiểm tra xem người dùng đã nhập dữ liệu hay chưa
            if (!string.IsNullOrEmpty(tenXeMay))
            {
                try
                {
                    // Tạo kết nối
                    using (SqlConnection connection = KetNoi.connectDB())
                    {
                        // Mở kết nối
                        connection.Open();

                        // Tạo câu truy vấn SQL
                        string query = @"
                        SELECT PX.MaPhieu, NV.HoTen, NV.ChucVu, XM.TenXeMay, XM.GiaBan, PX.NgayXuat, PX.SoLuong, PX.SoLuong * XM.GiaBan
                        FROM PhieuXuat PX
                        INNER JOIN NhanVien NV ON PX.MaNhanVien = NV.MaNhanVien
                        INNER JOIN XeMay XM ON PX.MaXeMay = XM.MaXeMay
                        WHERE XM.TenXeMay LIKE @TenXeMay";

                        // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm tham số cho câu lệnh SQL
                            command.Parameters.AddWithValue("@TenXeMay", "%" + tenXeMay + "%");

                            // Tạo DataAdapter để lấy dữ liệu từ SQL Server
                            SqlDataAdapter adapter = new SqlDataAdapter(command);

                            // Tạo DataTable để chứa dữ liệu
                            DataTable dataTable = new DataTable();

                            // Đổ dữ liệu từ DataAdapter vào DataTable
                            adapter.Fill(dataTable);

                            // Hiển thị dữ liệu từ DataTable lên DataGridView
                            dataGridViewCTPX.DataSource = dataTable;
                            // Kiểm tra xem có dữ liệu trả về hay không
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
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên xe máy cần tìm kiếm!");
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
