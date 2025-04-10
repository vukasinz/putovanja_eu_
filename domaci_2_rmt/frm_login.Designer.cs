namespace KlijentskaAplikacija
{
    partial class frm_login
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
            label1 = new Label();
            tb_username = new TextBox();
            label3 = new Label();
            tb_password = new TextBox();
            label5 = new Label();
            bt_login = new Button();
            lk_registracija = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 17, 16);
            label1.Location = new Point(3, 46);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 1;
            label1.Text = "korisnicko ime";
            // 
            // tb_username
            // 
            tb_username.BackColor = Color.FromArgb(201, 199, 241);
            tb_username.BorderStyle = BorderStyle.None;
            tb_username.Font = new Font("Segoe UI", 14.25F);
            tb_username.Location = new Point(12, 70);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(172, 26);
            tb_username.TabIndex = 2;
            tb_username.Text = "mikica";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 17, 16);
            label3.Location = new Point(3, 115);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 4;
            label3.Text = "sifra";
            // 
            // tb_password
            // 
            tb_password.BackColor = Color.FromArgb(201, 199, 241);
            tb_password.BorderStyle = BorderStyle.None;
            tb_password.Font = new Font("Segoe UI", 14.25F);
            tb_password.Location = new Point(12, 139);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(172, 26);
            tb_password.TabIndex = 5;
            tb_password.Text = "mikica";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(83, 118, 223);
            label5.Location = new Point(83, 9);
            label5.Name = "label5";
            label5.Size = new Size(84, 30);
            label5.TabIndex = 7;
            label5.Text = "LOG IN";
            // 
            // bt_login
            // 
            bt_login.BackColor = Color.FromArgb(83, 118, 223);
            bt_login.FlatStyle = FlatStyle.Flat;
            bt_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_login.ForeColor = Color.FromArgb(201, 199, 241);
            bt_login.Location = new Point(12, 187);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(193, 34);
            bt_login.TabIndex = 8;
            bt_login.Text = "LOG IN";
            bt_login.UseVisualStyleBackColor = false;
            bt_login.Click += bt_login_Click;
            // 
            // lk_registracija
            // 
            lk_registracija.AutoSize = true;
            lk_registracija.Location = new Point(152, 224);
            lk_registracija.Name = "lk_registracija";
            lk_registracija.Size = new Size(64, 15);
            lk_registracija.TabIndex = 9;
            lk_registracija.TabStop = true;
            lk_registracija.Text = "registruj se";
            lk_registracija.LinkClicked += lk_registracija_LinkClicked;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(261, 270);
            Controls.Add(lk_registracija);
            Controls.Add(bt_login);
            Controls.Add(label5);
            Controls.Add(tb_password);
            Controls.Add(label3);
            Controls.Add(tb_username);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_login";
            Load += frm_login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox tb_username;
        private Label label3;
        private TextBox tb_password;
        private Label label5;
        private Button bt_login;
        private LinkLabel lk_registracija;
    }
}