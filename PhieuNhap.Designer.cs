namespace QLXeMay
{
    partial class PhieuNhap
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
            dateTimePickerTK = new DateTimePicker();
            dateTimePickerNN = new DateTimePicker();
            label6 = new Label();
            textMaPN = new TextBox();
            textMaNV = new TextBox();
            textMaXM = new TextBox();
            dataGridViewPN = new DataGridView();
            buttonTk = new Button();
            buttonThoat = new Button();
            buttonSua = new Button();
            buttonThem = new Button();
            buttonXoa = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            textSL = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPN).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePickerTK
            // 
            dateTimePickerTK.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerTK.Location = new Point(12, 492);
            dateTimePickerTK.Name = "dateTimePickerTK";
            dateTimePickerTK.Size = new Size(310, 30);
            dateTimePickerTK.TabIndex = 79;
            // 
            // dateTimePickerNN
            // 
            dateTimePickerNN.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerNN.Location = new Point(11, 339);
            dateTimePickerNN.Name = "dateTimePickerNN";
            dateTimePickerNN.Size = new Size(310, 30);
            dateTimePickerNN.TabIndex = 78;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(13, 124);
            label6.Name = "label6";
            label6.Size = new Size(93, 24);
            label6.TabIndex = 77;
            label6.Text = "Mã phiếu";
            // 
            // textMaPN
            // 
            textMaPN.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textMaPN.Location = new Point(13, 151);
            textMaPN.Name = "textMaPN";
            textMaPN.Size = new Size(310, 32);
            textMaPN.TabIndex = 76;
            // 
            // textMaNV
            // 
            textMaNV.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textMaNV.Location = new Point(12, 213);
            textMaNV.Name = "textMaNV";
            textMaNV.Size = new Size(310, 32);
            textMaNV.TabIndex = 75;
            // 
            // textMaXM
            // 
            textMaXM.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textMaXM.Location = new Point(13, 275);
            textMaXM.Name = "textMaXM";
            textMaXM.Size = new Size(310, 32);
            textMaXM.TabIndex = 74;
            // 
            // dataGridViewPN
            // 
            dataGridViewPN.AllowUserToAddRows = false;
            dataGridViewPN.AllowUserToDeleteRows = false;
            dataGridViewPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPN.Dock = DockStyle.Right;
            dataGridViewPN.Location = new Point(382, 104);
            dataGridViewPN.Name = "dataGridViewPN";
            dataGridViewPN.ReadOnly = true;
            dataGridViewPN.RowHeadersWidth = 51;
            dataGridViewPN.RowTemplate.Height = 29;
            dataGridViewPN.Size = new Size(646, 559);
            dataGridViewPN.TabIndex = 73;
            dataGridViewPN.CellClick += dataGridViewPN_CellClick;
            // 
            // buttonTk
            // 
            buttonTk.FlatStyle = FlatStyle.Flat;
            buttonTk.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTk.ForeColor = Color.Teal;
            buttonTk.Location = new Point(11, 437);
            buttonTk.Name = "buttonTk";
            buttonTk.Size = new Size(253, 47);
            buttonTk.TabIndex = 72;
            buttonTk.Text = "Tìm kiếm theo ngày nhập";
            buttonTk.UseVisualStyleBackColor = true;
            buttonTk.Click += buttonTk_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.BackColor = Color.White;
            buttonThoat.FlatStyle = FlatStyle.Flat;
            buttonThoat.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThoat.ForeColor = Color.Red;
            buttonThoat.Location = new Point(168, 597);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(152, 47);
            buttonThoat.TabIndex = 71;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = false;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // buttonSua
            // 
            buttonSua.BackColor = Color.PaleTurquoise;
            buttonSua.FlatStyle = FlatStyle.Flat;
            buttonSua.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSua.ForeColor = Color.Teal;
            buttonSua.Location = new Point(168, 544);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(152, 47);
            buttonSua.TabIndex = 70;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = false;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonThem
            // 
            buttonThem.BackColor = Color.Teal;
            buttonThem.FlatStyle = FlatStyle.Flat;
            buttonThem.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThem.ForeColor = Color.White;
            buttonThem.Location = new Point(10, 544);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(152, 47);
            buttonThem.TabIndex = 69;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.LightCoral;
            buttonXoa.FlatStyle = FlatStyle.Flat;
            buttonXoa.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonXoa.ForeColor = Color.Teal;
            buttonXoa.Location = new Point(10, 597);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(152, 47);
            buttonXoa.TabIndex = 68;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(12, 372);
            label5.Name = "label5";
            label5.Size = new Size(90, 24);
            label5.TabIndex = 67;
            label5.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(11, 310);
            label4.Name = "label4";
            label4.Size = new Size(105, 24);
            label4.TabIndex = 66;
            label4.Text = "Ngày nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(13, 248);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
            label2.TabIndex = 65;
            label2.Text = "Mã xe máy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(10, 186);
            label3.Name = "label3";
            label3.Size = new Size(131, 24);
            label3.TabIndex = 64;
            label3.Text = "Mã nhân viên";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 104);
            panel1.TabIndex = 63;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Constantia", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1028, 104);
            label1.TabIndex = 2;
            label1.Text = "THÔNG TIN PHIẾU NHẬP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textSL
            // 
            textSL.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSL.Location = new Point(11, 399);
            textSL.Name = "textSL";
            textSL.Size = new Size(310, 32);
            textSL.TabIndex = 62;
            // 
            // PhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 663);
            Controls.Add(dateTimePickerTK);
            Controls.Add(dateTimePickerNN);
            Controls.Add(label6);
            Controls.Add(textMaPN);
            Controls.Add(textMaNV);
            Controls.Add(textMaXM);
            Controls.Add(dataGridViewPN);
            Controls.Add(buttonTk);
            Controls.Add(buttonThoat);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(buttonXoa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(textSL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhieuNhap";
            Load += PhieuNhap_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPN).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerTK;
        private DateTimePicker dateTimePickerNN;
        private Label label6;
        private TextBox textMaPN;
        private TextBox textMaNV;
        private TextBox textMaXM;
        private DataGridView dataGridViewPN;
        private Button buttonTk;
        private Button buttonThoat;
        private Button buttonSua;
        private Button buttonThem;
        private Button buttonXoa;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private TextBox textSL;
    }
}