namespace WinFormsApp1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panelLogin = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textTK = new TextBox();
            textMK = new TextBox();
            label3 = new Label();
            label4 = new Label();
            buttonDN = new Button();
            buttonThoat = new Button();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.Teal;
            panelLogin.Controls.Add(label7);
            panelLogin.Controls.Add(label6);
            panelLogin.Controls.Add(label5);
            panelLogin.Controls.Add(label2);
            panelLogin.Dock = DockStyle.Left;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(278, 462);
            panelLogin.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 429);
            label7.Name = "label7";
            label7.Size = new Size(104, 24);
            label7.TabIndex = 7;
            label7.Text = "Version 1.0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Teal;
            label6.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 234);
            label6.Name = "label6";
            label6.Size = new Size(125, 37);
            label6.TabIndex = 4;
            label6.Text = "XE MÁY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Teal;
            label5.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 187);
            label5.Name = "label5";
            label5.Size = new Size(145, 37);
            label5.TabIndex = 3;
            label5.Text = "QUẢN LÝ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Teal;
            label2.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 140);
            label2.Name = "label2";
            label2.Size = new Size(178, 37);
            label2.TabIndex = 2;
            label2.Text = "PHẦN MỀM";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(403, 19);
            label1.Name = "label1";
            label1.Size = new Size(159, 37);
            label1.TabIndex = 1;
            label1.Text = "Đăng nhập";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(412, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textTK
            // 
            textTK.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textTK.Location = new Point(327, 214);
            textTK.Name = "textTK";
            textTK.Size = new Size(288, 32);
            textTK.TabIndex = 3;
            // 
            // textMK
            // 
            textMK.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textMK.Location = new Point(327, 294);
            textMK.Name = "textMK";
            textMK.PasswordChar = '*';
            textMK.Size = new Size(288, 32);
            textMK.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(327, 187);
            label3.Name = "label3";
            label3.Size = new Size(98, 24);
            label3.TabIndex = 6;
            label3.Text = "Tài khoản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(327, 267);
            label4.Name = "label4";
            label4.Size = new Size(94, 24);
            label4.TabIndex = 7;
            label4.Text = "Mật khẩu";
            // 
            // buttonDN
            // 
            buttonDN.FlatStyle = FlatStyle.Flat;
            buttonDN.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDN.ForeColor = Color.Teal;
            buttonDN.Location = new Point(381, 348);
            buttonDN.Name = "buttonDN";
            buttonDN.Size = new Size(190, 47);
            buttonDN.TabIndex = 8;
            buttonDN.Text = "Đăng nhập";
            buttonDN.UseVisualStyleBackColor = true;
            buttonDN.Click += buttonDN_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.FlatStyle = FlatStyle.Flat;
            buttonThoat.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThoat.ForeColor = Color.Red;
            buttonThoat.Location = new Point(381, 406);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(190, 47);
            buttonThoat.TabIndex = 9;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(676, 462);
            Controls.Add(buttonThoat);
            Controls.Add(buttonDN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textMK);
            Controls.Add(textTK);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panelLogin);
            Font = new Font("Constantia", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLogin;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textTK;
        private TextBox textMK;
        private Label label3;
        private Label label4;
        private Button buttonDN;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button buttonThoat;
    }
}
