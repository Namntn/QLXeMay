namespace QLXeMay
{
    partial class ChiTietPN
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
            dataGridViewCTPN = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            buttonTkNV = new Button();
            textTimkiemNV = new TextBox();
            dateTimePickerTK = new DateTimePicker();
            buttonTKNN = new Button();
            buttonTKXM = new Button();
            textBoxTkXM = new TextBox();
            buttonThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCTPN).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCTPN
            // 
            dataGridViewCTPN.AllowUserToAddRows = false;
            dataGridViewCTPN.AllowUserToDeleteRows = false;
            dataGridViewCTPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCTPN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCTPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCTPN.Location = new Point(0, 107);
            dataGridViewCTPN.Name = "dataGridViewCTPN";
            dataGridViewCTPN.ReadOnly = true;
            dataGridViewCTPN.RowHeadersWidth = 51;
            dataGridViewCTPN.RowTemplate.Height = 29;
            dataGridViewCTPN.Size = new Size(1080, 289);
            dataGridViewCTPN.TabIndex = 75;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 104);
            panel1.TabIndex = 74;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Constantia", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1080, 104);
            label1.TabIndex = 2;
            label1.Text = "CHI TIẾT PHIẾU NHẬP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonTkNV
            // 
            buttonTkNV.FlatStyle = FlatStyle.Flat;
            buttonTkNV.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTkNV.ForeColor = Color.Teal;
            buttonTkNV.Location = new Point(12, 422);
            buttonTkNV.Name = "buttonTkNV";
            buttonTkNV.Size = new Size(285, 47);
            buttonTkNV.TabIndex = 77;
            buttonTkNV.Text = "Tìm kiếm theo tên nhân viên";
            buttonTkNV.UseVisualStyleBackColor = true;
            buttonTkNV.Click += buttonTkNV_Click;
            // 
            // textTimkiemNV
            // 
            textTimkiemNV.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textTimkiemNV.Location = new Point(12, 475);
            textTimkiemNV.Name = "textTimkiemNV";
            textTimkiemNV.Size = new Size(285, 32);
            textTimkiemNV.TabIndex = 76;
            // 
            // dateTimePickerTK
            // 
            dateTimePickerTK.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerTK.Location = new Point(316, 477);
            dateTimePickerTK.Name = "dateTimePickerTK";
            dateTimePickerTK.Size = new Size(264, 30);
            dateTimePickerTK.TabIndex = 81;
            // 
            // buttonTKNN
            // 
            buttonTKNN.FlatStyle = FlatStyle.Flat;
            buttonTKNN.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTKNN.ForeColor = Color.Teal;
            buttonTKNN.Location = new Point(315, 422);
            buttonTKNN.Name = "buttonTKNN";
            buttonTKNN.Size = new Size(265, 47);
            buttonTKNN.TabIndex = 80;
            buttonTKNN.Text = "Tìm kiếm theo ngày nhập";
            buttonTKNN.UseVisualStyleBackColor = true;
            buttonTKNN.Click += buttonTKNN_Click;
            // 
            // buttonTKXM
            // 
            buttonTKXM.FlatStyle = FlatStyle.Flat;
            buttonTKXM.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTKXM.ForeColor = Color.Teal;
            buttonTKXM.Location = new Point(598, 422);
            buttonTKXM.Name = "buttonTKXM";
            buttonTKXM.Size = new Size(255, 47);
            buttonTKXM.TabIndex = 83;
            buttonTKXM.Text = "Tìm kiếm theo tên xe máy";
            buttonTKXM.UseVisualStyleBackColor = true;
            buttonTKXM.Click += buttonTKXM_Click;
            // 
            // textBoxTkXM
            // 
            textBoxTkXM.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTkXM.Location = new Point(598, 475);
            textBoxTkXM.Name = "textBoxTkXM";
            textBoxTkXM.Size = new Size(255, 32);
            textBoxTkXM.TabIndex = 82;
            // 
            // buttonThoat
            // 
            buttonThoat.BackColor = Color.White;
            buttonThoat.FlatStyle = FlatStyle.Flat;
            buttonThoat.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThoat.ForeColor = Color.Red;
            buttonThoat.Location = new Point(889, 422);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(152, 85);
            buttonThoat.TabIndex = 84;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = false;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // ChiTietPN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 519);
            Controls.Add(buttonThoat);
            Controls.Add(buttonTKXM);
            Controls.Add(textBoxTkXM);
            Controls.Add(dateTimePickerTK);
            Controls.Add(buttonTKNN);
            Controls.Add(buttonTkNV);
            Controls.Add(textTimkiemNV);
            Controls.Add(dataGridViewCTPN);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChiTietPN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChiTietPN";
            Load += ChiTietPN_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCTPN).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCTPN;
        private Panel panel1;
        private Label label1;
        private Button buttonTkNV;
        private TextBox textTimkiemNV;
        private DateTimePicker dateTimePickerTK;
        private Button buttonTKNN;
        private Button buttonTKXM;
        private TextBox textBoxTkXM;
        private Button buttonThoat;
    }
}