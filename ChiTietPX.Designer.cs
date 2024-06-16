namespace QLXeMay
{
    partial class ChiTietPX
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
            buttonThoat = new Button();
            buttonTKXM = new Button();
            textBoxTkXM = new TextBox();
            dateTimePickerTK = new DateTimePicker();
            buttonTKNX = new Button();
            buttonTkNV = new Button();
            textTimkiemNV = new TextBox();
            dataGridViewCTPX = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCTPX).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonThoat
            // 
            buttonThoat.BackColor = Color.White;
            buttonThoat.FlatStyle = FlatStyle.Flat;
            buttonThoat.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThoat.ForeColor = Color.Red;
            buttonThoat.Location = new Point(924, 425);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(152, 85);
            buttonThoat.TabIndex = 93;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = false;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // buttonTKXM
            // 
            buttonTKXM.FlatStyle = FlatStyle.Flat;
            buttonTKXM.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTKXM.ForeColor = Color.Teal;
            buttonTKXM.Location = new Point(634, 425);
            buttonTKXM.Name = "buttonTKXM";
            buttonTKXM.Size = new Size(255, 47);
            buttonTKXM.TabIndex = 92;
            buttonTKXM.Text = "Tìm kiếm theo tên xe máy";
            buttonTKXM.UseVisualStyleBackColor = true;
            buttonTKXM.Click += buttonTKXM_Click;
            // 
            // textBoxTkXM
            // 
            textBoxTkXM.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTkXM.Location = new Point(634, 478);
            textBoxTkXM.Name = "textBoxTkXM";
            textBoxTkXM.Size = new Size(255, 32);
            textBoxTkXM.TabIndex = 91;
            // 
            // dateTimePickerTK
            // 
            dateTimePickerTK.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerTK.Location = new Point(331, 480);
            dateTimePickerTK.Name = "dateTimePickerTK";
            dateTimePickerTK.Size = new Size(264, 30);
            dateTimePickerTK.TabIndex = 90;
            // 
            // buttonTKNX
            // 
            buttonTKNX.FlatStyle = FlatStyle.Flat;
            buttonTKNX.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTKNX.ForeColor = Color.Teal;
            buttonTKNX.Location = new Point(330, 425);
            buttonTKNX.Name = "buttonTKNX";
            buttonTKNX.Size = new Size(265, 47);
            buttonTKNX.TabIndex = 89;
            buttonTKNX.Text = "Tìm kiếm theo ngày xuất";
            buttonTKNX.UseVisualStyleBackColor = true;
            buttonTKNX.Click += buttonTKNX_Click;
            // 
            // buttonTkNV
            // 
            buttonTkNV.FlatStyle = FlatStyle.Flat;
            buttonTkNV.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTkNV.ForeColor = Color.Teal;
            buttonTkNV.Location = new Point(12, 425);
            buttonTkNV.Name = "buttonTkNV";
            buttonTkNV.Size = new Size(285, 47);
            buttonTkNV.TabIndex = 88;
            buttonTkNV.Text = "Tìm kiếm theo tên nhân viên";
            buttonTkNV.UseVisualStyleBackColor = true;
            buttonTkNV.Click += buttonTkNV_Click;
            // 
            // textTimkiemNV
            // 
            textTimkiemNV.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textTimkiemNV.Location = new Point(12, 478);
            textTimkiemNV.Name = "textTimkiemNV";
            textTimkiemNV.Size = new Size(285, 32);
            textTimkiemNV.TabIndex = 87;
            // 
            // dataGridViewCTPX
            // 
            dataGridViewCTPX.AllowUserToAddRows = false;
            dataGridViewCTPX.AllowUserToDeleteRows = false;
            dataGridViewCTPX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCTPX.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCTPX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCTPX.Location = new Point(-11, 110);
            dataGridViewCTPX.Name = "dataGridViewCTPX";
            dataGridViewCTPX.ReadOnly = true;
            dataGridViewCTPX.RowHeadersWidth = 51;
            dataGridViewCTPX.RowTemplate.Height = 29;
            dataGridViewCTPX.Size = new Size(1099, 289);
            dataGridViewCTPX.TabIndex = 86;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 104);
            panel1.TabIndex = 85;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Constantia", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1088, 104);
            label1.TabIndex = 2;
            label1.Text = "CHI TIẾT PHIẾU XUẤT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChiTietPX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 522);
            Controls.Add(buttonThoat);
            Controls.Add(buttonTKXM);
            Controls.Add(textBoxTkXM);
            Controls.Add(dateTimePickerTK);
            Controls.Add(buttonTKNX);
            Controls.Add(buttonTkNV);
            Controls.Add(textTimkiemNV);
            Controls.Add(dataGridViewCTPX);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChiTietPX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChiTietPX";
            Load += ChiTietPX_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCTPX).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonThoat;
        private Button buttonTKXM;
        private TextBox textBoxTkXM;
        private DateTimePicker dateTimePickerTK;
        private Button buttonTKNX;
        private Button buttonTkNV;
        private TextBox textTimkiemNV;
        private DataGridView dataGridViewCTPX;
        private Panel panel1;
        private Label label1;
    }
}