namespace KlijentskaAplikacija
{
    partial class frm_glavna
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
            panel1 = new Panel();
            bt_logout = new Button();
            lb_username = new Label();
            bt_prijava = new Button();
            bt_prikaz = new Button();
            pnl_glavni = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 84, 215);
            panel1.Controls.Add(bt_logout);
            panel1.Controls.Add(lb_username);
            panel1.Controls.Add(bt_prijava);
            panel1.Controls.Add(bt_prikaz);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 40);
            panel1.TabIndex = 0;
            // 
            // bt_logout
            // 
            bt_logout.BackColor = Color.FromArgb(83, 118, 223);
            bt_logout.FlatStyle = FlatStyle.Popup;
            bt_logout.Font = new Font("Segoe UI", 12F);
            bt_logout.ForeColor = Color.FromArgb(201, 199, 241);
            bt_logout.Location = new Point(213, 2);
            bt_logout.Name = "bt_logout";
            bt_logout.Size = new Size(109, 35);
            bt_logout.TabIndex = 4;
            bt_logout.Text = "Odloguj se";
            bt_logout.UseVisualStyleBackColor = false;
            bt_logout.Click += bt_logout_Click;
            // 
            // lb_username
            // 
            lb_username.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_username.ForeColor = Color.FromArgb(201, 199, 241);
            lb_username.Location = new Point(556, 0);
            lb_username.Margin = new Padding(10, 8, 12, 0);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(149, 40);
            lb_username.TabIndex = 3;
            lb_username.Text = "label1";
            lb_username.TextAlign = ContentAlignment.MiddleRight;
            lb_username.Click += lb_username_Click;
            // 
            // bt_prijava
            // 
            bt_prijava.BackColor = Color.FromArgb(83, 118, 223);
            bt_prijava.FlatStyle = FlatStyle.Popup;
            bt_prijava.Font = new Font("Segoe UI", 12F);
            bt_prijava.ForeColor = Color.FromArgb(201, 199, 241);
            bt_prijava.Location = new Point(108, 2);
            bt_prijava.Name = "bt_prijava";
            bt_prijava.Size = new Size(109, 35);
            bt_prijava.TabIndex = 1;
            bt_prijava.Text = "Prijava";
            bt_prijava.UseVisualStyleBackColor = false;
            bt_prijava.Click += bt_prijava_Click;
            // 
            // bt_prikaz
            // 
            bt_prikaz.BackColor = Color.FromArgb(83, 118, 223);
            bt_prikaz.FlatStyle = FlatStyle.Popup;
            bt_prikaz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_prikaz.ForeColor = Color.FromArgb(201, 199, 241);
            bt_prikaz.Location = new Point(3, 2);
            bt_prikaz.Name = "bt_prikaz";
            bt_prikaz.Size = new Size(109, 35);
            bt_prikaz.TabIndex = 0;
            bt_prikaz.Text = "Prikaz";
            bt_prikaz.UseVisualStyleBackColor = false;
            bt_prikaz.Click += bt_prikaz_Click;
            // 
            // pnl_glavni
            // 
            pnl_glavni.Location = new Point(3, 46);
            pnl_glavni.Name = "pnl_glavni";
            pnl_glavni.Size = new Size(714, 387);
            pnl_glavni.TabIndex = 4;
            pnl_glavni.Paint += pnl_glavni_Paint;
            // 
            // frm_glavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(713, 434);
            Controls.Add(pnl_glavni);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_glavna";
            Text = "frm_glavna";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bt_prikaz;
        private Button bt_prijava;
        private Label lb_username;
        private Panel pnl_glavni;
        private Button bt_logout;
    }
}