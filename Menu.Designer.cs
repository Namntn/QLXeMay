namespace QLXeMay
{
    partial class Menu
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
            buttonDN = new Button();
            buttonXM = new Button();
            buttonPN = new Button();
            buttonPX = new Button();
            buttonCTPX = new Button();
            buttonCTPN = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonThoat
            // 
            buttonThoat.FlatStyle = FlatStyle.Flat;
            buttonThoat.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThoat.ForeColor = Color.Red;
            buttonThoat.Location = new Point(114, 504);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(275, 47);
            buttonThoat.TabIndex = 10;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // buttonDN
            // 
            buttonDN.FlatStyle = FlatStyle.Flat;
            buttonDN.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDN.ForeColor = Color.Teal;
            buttonDN.Location = new Point(114, 125);
            buttonDN.Name = "buttonDN";
            buttonDN.Size = new Size(275, 47);
            buttonDN.TabIndex = 11;
            buttonDN.Text = "Thông tin nhân viên";
            buttonDN.UseVisualStyleBackColor = true;
            buttonDN.Click += buttonDN_Click;
            // 
            // buttonXM
            // 
            buttonXM.FlatStyle = FlatStyle.Flat;
            buttonXM.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonXM.ForeColor = Color.Teal;
            buttonXM.Location = new Point(114, 187);
            buttonXM.Name = "buttonXM";
            buttonXM.Size = new Size(275, 47);
            buttonXM.TabIndex = 12;
            buttonXM.Text = "Thông tin xe máy";
            buttonXM.UseVisualStyleBackColor = true;
            buttonXM.Click += buttonXM_Click;
            // 
            // buttonPN
            // 
            buttonPN.FlatStyle = FlatStyle.Flat;
            buttonPN.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPN.ForeColor = Color.Teal;
            buttonPN.Location = new Point(114, 249);
            buttonPN.Name = "buttonPN";
            buttonPN.Size = new Size(275, 47);
            buttonPN.TabIndex = 13;
            buttonPN.Text = "Phiếu nhập";
            buttonPN.UseVisualStyleBackColor = true;
            buttonPN.Click += buttonPN_Click;
            // 
            // buttonPX
            // 
            buttonPX.FlatStyle = FlatStyle.Flat;
            buttonPX.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPX.ForeColor = Color.Teal;
            buttonPX.Location = new Point(114, 311);
            buttonPX.Name = "buttonPX";
            buttonPX.Size = new Size(275, 47);
            buttonPX.TabIndex = 14;
            buttonPX.Text = "Phiếu xuất";
            buttonPX.UseVisualStyleBackColor = true;
            buttonPX.Click += buttonPX_Click;
            // 
            // buttonCTPX
            // 
            buttonCTPX.FlatStyle = FlatStyle.Flat;
            buttonCTPX.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCTPX.ForeColor = Color.Teal;
            buttonCTPX.Location = new Point(114, 438);
            buttonCTPX.Name = "buttonCTPX";
            buttonCTPX.Size = new Size(275, 47);
            buttonCTPX.TabIndex = 15;
            buttonCTPX.Text = "Chi tiết phiếu xuất";
            buttonCTPX.UseVisualStyleBackColor = true;
            buttonCTPX.Click += buttonCTPX_Click;
            // 
            // buttonCTPN
            // 
            buttonCTPN.FlatStyle = FlatStyle.Flat;
            buttonCTPN.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCTPN.ForeColor = Color.Teal;
            buttonCTPN.Location = new Point(114, 374);
            buttonCTPN.Name = "buttonCTPN";
            buttonCTPN.Size = new Size(275, 47);
            buttonCTPN.TabIndex = 16;
            buttonCTPN.Text = "Chi tiết phiếu nhập";
            buttonCTPN.UseVisualStyleBackColor = true;
            buttonCTPN.Click += buttonCTPN_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 105);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Constantia", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(502, 105);
            label1.TabIndex = 0;
            label1.Text = "MENU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 572);
            Controls.Add(panel1);
            Controls.Add(buttonCTPN);
            Controls.Add(buttonCTPX);
            Controls.Add(buttonPX);
            Controls.Add(buttonPN);
            Controls.Add(buttonXM);
            Controls.Add(buttonDN);
            Controls.Add(buttonThoat);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button buttonThoat;
        private Button buttonDN;
        private Button buttonXM;
        private Button buttonPN;
        private Button buttonPX;
        private Button buttonCTPX;
        private Button buttonCTPN;
        private Panel panel1;
        private Label label1;
    }
}