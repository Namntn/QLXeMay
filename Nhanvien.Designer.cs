namespace QLXeMay
{
    partial class Nhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textMaNV = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            dataGridViewNhanvien = new DataGridView();
            textHoten = new TextBox();
            dateTimePickerNS = new DateTimePicker();
            comboChucvu = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonXoa = new Button();
            buttonThem = new Button();
            buttonSua = new Button();
            textTimkiem = new TextBox();
            buttonThoat = new Button();
            buttonTk = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanvien).BeginInit();
            SuspendLayout();
            // 
            // textMaNV
            // 
            textMaNV.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textMaNV.Location = new Point(14, 156);
            textMaNV.Name = "textMaNV";
            textMaNV.Size = new Size(310, 32);
            textMaNV.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 104);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Constantia", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1125, 104);
            label1.TabIndex = 1;
            label1.Text = "THÔNG TIN NHÂN VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewNhanvien
            // 
            dataGridViewNhanvien.AllowUserToAddRows = false;
            dataGridViewNhanvien.AllowUserToDeleteRows = false;
            dataGridViewNhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNhanvien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewNhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNhanvien.Dock = DockStyle.Right;
            dataGridViewNhanvien.Location = new Point(371, 104);
            dataGridViewNhanvien.Name = "dataGridViewNhanvien";
            dataGridViewNhanvien.ReadOnly = true;
            dataGridViewNhanvien.RowHeadersWidth = 51;
            dataGridViewNhanvien.RowTemplate.Height = 29;
            dataGridViewNhanvien.Size = new Size(754, 515);
            dataGridViewNhanvien.TabIndex = 6;
            dataGridViewNhanvien.CellClick += dataGridViewNhanvien_CellClick;
            // 
            // textHoten
            // 
            textHoten.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textHoten.Location = new Point(13, 217);
            textHoten.Name = "textHoten";
            textHoten.Size = new Size(310, 32);
            textHoten.TabIndex = 7;
            // 
            // dateTimePickerNS
            // 
            dateTimePickerNS.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerNS.Location = new Point(14, 279);
            dateTimePickerNS.Name = "dateTimePickerNS";
            dateTimePickerNS.Size = new Size(310, 30);
            dateTimePickerNS.TabIndex = 8;
            // 
            // comboChucvu
            // 
            comboChucvu.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboChucvu.FormattingEnabled = true;
            comboChucvu.Items.AddRange(new object[] { "Quan ly", "Nhan vien ban hang", "Nhan vien kho" });
            comboChucvu.Location = new Point(13, 341);
            comboChucvu.Name = "comboChucvu";
            comboChucvu.Size = new Size(310, 32);
            comboChucvu.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(14, 129);
            label3.Name = "label3";
            label3.Size = new Size(131, 24);
            label3.TabIndex = 10;
            label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(13, 190);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 11;
            label2.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(10, 251);
            label4.Name = "label4";
            label4.Size = new Size(98, 24);
            label4.TabIndex = 12;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(10, 314);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 13;
            label5.Text = "Chức vụ";
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.LightCoral;
            buttonXoa.FlatStyle = FlatStyle.Flat;
            buttonXoa.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonXoa.ForeColor = Color.Teal;
            buttonXoa.Location = new Point(10, 550);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(152, 47);
            buttonXoa.TabIndex = 14;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonThem
            // 
            buttonThem.BackColor = Color.Teal;
            buttonThem.FlatStyle = FlatStyle.Flat;
            buttonThem.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThem.ForeColor = Color.White;
            buttonThem.Location = new Point(10, 485);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(152, 47);
            buttonThem.TabIndex = 15;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSua
            // 
            buttonSua.BackColor = Color.PaleTurquoise;
            buttonSua.FlatStyle = FlatStyle.Flat;
            buttonSua.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSua.ForeColor = Color.Teal;
            buttonSua.Location = new Point(171, 485);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(152, 47);
            buttonSua.TabIndex = 16;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = false;
            buttonSua.Click += buttonSua_Click;
            // 
            // textTimkiem
            // 
            textTimkiem.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textTimkiem.Location = new Point(10, 437);
            textTimkiem.Name = "textTimkiem";
            textTimkiem.Size = new Size(311, 32);
            textTimkiem.TabIndex = 18;
            // 
            // buttonThoat
            // 
            buttonThoat.BackColor = Color.White;
            buttonThoat.FlatStyle = FlatStyle.Flat;
            buttonThoat.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThoat.ForeColor = Color.Red;
            buttonThoat.Location = new Point(171, 550);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(152, 47);
            buttonThoat.TabIndex = 19;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = false;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // buttonTk
            // 
            buttonTk.FlatStyle = FlatStyle.Flat;
            buttonTk.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTk.ForeColor = Color.Teal;
            buttonTk.Location = new Point(10, 384);
            buttonTk.Name = "buttonTk";
            buttonTk.Size = new Size(190, 47);
            buttonTk.TabIndex = 20;
            buttonTk.Text = "Tìm kiếm theo tên";
            buttonTk.UseVisualStyleBackColor = true;
            buttonTk.Click += buttonTk_Click;
            // 
            // Nhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 619);
            Controls.Add(buttonTk);
            Controls.Add(buttonThoat);
            Controls.Add(textTimkiem);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(buttonXoa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(comboChucvu);
            Controls.Add(dateTimePickerNS);
            Controls.Add(textHoten);
            Controls.Add(dataGridViewNhanvien);
            Controls.Add(panel1);
            Controls.Add(textMaNV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Nhanvien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhanvien";
            Load += Nhanvien_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textMaNV;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridViewNhanvien;
        private TextBox textHoten;
        private DateTimePicker dateTimePickerNS;
        private ComboBox comboChucvu;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button buttonXoa;
        private Button buttonThem;
        private Button buttonSua;
        private TextBox textTimkiem;
        private Button buttonThoat;
        private Button buttonTk;
    }
}