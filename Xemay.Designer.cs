namespace QLXeMay
{
    partial class Xemay
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
            buttonTk = new Button();
            buttonThoat = new Button();
            textTimkiem = new TextBox();
            buttonSua = new Button();
            buttonThem = new Button();
            buttonXoa = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            textGiaban = new TextBox();
            dataGridViewXeMay = new DataGridView();
            textBoxNamsx = new TextBox();
            textHangsx = new TextBox();
            textTenXM = new TextBox();
            textMaXM = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewXeMay).BeginInit();
            SuspendLayout();
            // 
            // buttonTk
            // 
            buttonTk.FlatStyle = FlatStyle.Flat;
            buttonTk.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTk.ForeColor = Color.Teal;
            buttonTk.Location = new Point(13, 427);
            buttonTk.Name = "buttonTk";
            buttonTk.Size = new Size(190, 47);
            buttonTk.TabIndex = 35;
            buttonTk.Text = "Tìm kiếm theo tên";
            buttonTk.UseVisualStyleBackColor = true;
            buttonTk.Click += buttonTk_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.BackColor = Color.White;
            buttonThoat.FlatStyle = FlatStyle.Flat;
            buttonThoat.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThoat.ForeColor = Color.Red;
            buttonThoat.Location = new Point(173, 571);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(152, 47);
            buttonThoat.TabIndex = 34;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = false;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // textTimkiem
            // 
            textTimkiem.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textTimkiem.Location = new Point(13, 480);
            textTimkiem.Name = "textTimkiem";
            textTimkiem.Size = new Size(311, 32);
            textTimkiem.TabIndex = 33;
            // 
            // buttonSua
            // 
            buttonSua.BackColor = Color.PaleTurquoise;
            buttonSua.FlatStyle = FlatStyle.Flat;
            buttonSua.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSua.ForeColor = Color.Teal;
            buttonSua.Location = new Point(173, 518);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(152, 47);
            buttonSua.TabIndex = 32;
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
            buttonThem.Location = new Point(15, 518);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(152, 47);
            buttonThem.TabIndex = 31;
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
            buttonXoa.Location = new Point(15, 571);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(152, 47);
            buttonXoa.TabIndex = 30;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(14, 362);
            label5.Name = "label5";
            label5.Size = new Size(78, 24);
            label5.TabIndex = 29;
            label5.Text = "Giá bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(13, 300);
            label4.Name = "label4";
            label4.Size = new Size(130, 24);
            label4.TabIndex = 28;
            label4.Text = "Năm sản xuất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(15, 238);
            label2.Name = "label2";
            label2.Size = new Size(136, 24);
            label2.TabIndex = 27;
            label2.Text = "Hãng sản xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(12, 176);
            label3.Name = "label3";
            label3.Size = new Size(110, 24);
            label3.TabIndex = 26;
            label3.Text = "Tên xe máy";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 104);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Constantia", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1041, 104);
            label1.TabIndex = 2;
            label1.Text = "THÔNG TIN XE MÁY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textGiaban
            // 
            textGiaban.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textGiaban.Location = new Point(13, 389);
            textGiaban.Name = "textGiaban";
            textGiaban.Size = new Size(310, 32);
            textGiaban.TabIndex = 21;
            // 
            // dataGridViewXeMay
            // 
            dataGridViewXeMay.AllowUserToAddRows = false;
            dataGridViewXeMay.AllowUserToDeleteRows = false;
            dataGridViewXeMay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewXeMay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewXeMay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewXeMay.Dock = DockStyle.Right;
            dataGridViewXeMay.Location = new Point(395, 104);
            dataGridViewXeMay.Name = "dataGridViewXeMay";
            dataGridViewXeMay.ReadOnly = true;
            dataGridViewXeMay.RowHeadersWidth = 51;
            dataGridViewXeMay.RowTemplate.Height = 29;
            dataGridViewXeMay.Size = new Size(646, 526);
            dataGridViewXeMay.TabIndex = 36;
            dataGridViewXeMay.CellClick += dataGridViewXeMay_CellClick;
            // 
            // textBoxNamsx
            // 
            textBoxNamsx.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNamsx.Location = new Point(13, 327);
            textBoxNamsx.Name = "textBoxNamsx";
            textBoxNamsx.Size = new Size(310, 32);
            textBoxNamsx.TabIndex = 37;
            // 
            // textHangsx
            // 
            textHangsx.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textHangsx.Location = new Point(15, 265);
            textHangsx.Name = "textHangsx";
            textHangsx.Size = new Size(310, 32);
            textHangsx.TabIndex = 38;
            // 
            // textTenXM
            // 
            textTenXM.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textTenXM.Location = new Point(14, 203);
            textTenXM.Name = "textTenXM";
            textTenXM.Size = new Size(310, 32);
            textTenXM.TabIndex = 39;
            // 
            // textMaXM
            // 
            textMaXM.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textMaXM.Location = new Point(15, 141);
            textMaXM.Name = "textMaXM";
            textMaXM.Size = new Size(310, 32);
            textMaXM.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(15, 114);
            label6.Name = "label6";
            label6.Size = new Size(105, 24);
            label6.TabIndex = 41;
            label6.Text = "Mã xe máy";
            // 
            // Xemay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 630);
            Controls.Add(label6);
            Controls.Add(textMaXM);
            Controls.Add(textTenXM);
            Controls.Add(textHangsx);
            Controls.Add(textBoxNamsx);
            Controls.Add(dataGridViewXeMay);
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
            Controls.Add(panel1);
            Controls.Add(textGiaban);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Xemay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xemay";
            Load += Xemay_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewXeMay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTk;
        private Button buttonThoat;
        private TextBox textTimkiem;
        private Button buttonSua;
        private Button buttonThem;
        private Button buttonXoa;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox textGiaban;
        private DataGridView dataGridViewXeMay;
        private TextBox textBoxNamsx;
        private TextBox textHangsx;
        private TextBox textTenXM;
        private Label label1;
        private TextBox textMaXM;
        private Label label6;
    }
}