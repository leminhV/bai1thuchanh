namespace bai1thuchanh
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            chkNho = new CheckBox();
            btnDangNhap = new Button();
            bthXoa = new Button();
            bthDung = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 58);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            label2.Click += label2_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(141, 25);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(194, 23);
            txtUser.TabIndex = 2;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.InactiveBorder;
            txtPass.Location = new Point(141, 54);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(194, 23);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // chkNho
            // 
            chkNho.AutoSize = true;
            chkNho.Location = new Point(67, 84);
            chkNho.Name = "chkNho";
            chkNho.Size = new Size(70, 19);
            chkNho.TabIndex = 4;
            chkNho.Text = "Ghi Nhớ";
            chkNho.UseVisualStyleBackColor = true;
            chkNho.CheckedChanged += chkNho_CheckedChanged;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(65, 115);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(75, 23);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // bthXoa
            // 
            bthXoa.Location = new Point(165, 115);
            bthXoa.Name = "bthXoa";
            bthXoa.Size = new Size(75, 23);
            bthXoa.TabIndex = 6;
            bthXoa.Text = "Xoá";
            bthXoa.UseVisualStyleBackColor = true;
            bthXoa.Click += bthXoa_Click;
            // 
            // bthDung
            // 
            bthDung.Location = new Point(283, 115);
            bthDung.Name = "bthDung";
            bthDung.Size = new Size(75, 23);
            bthDung.TabIndex = 7;
            bthDung.Text = "Dừng";
            bthDung.UseVisualStyleBackColor = true;
            bthDung.Click += bthDung_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 178);
            Controls.Add(bthDung);
            Controls.Add(bthXoa);
            Controls.Add(btnDangNhap);
            Controls.Add(chkNho);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "FormĐăngNhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPass;
        private CheckBox chkNho;
        private Button btnDangNhap;
        private Button bthXoa;
        private Button bthDung;
    }
}
