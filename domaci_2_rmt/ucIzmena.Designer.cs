namespace KlijentskaAplikacija
{
    partial class ucIzmena
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_izmeni = new Button();
            label8 = new Label();
            cb_nacinprevoza = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            dtp_izlazak = new DateTimePicker();
            dtp_ulazak = new DateTimePicker();
            tb_jmbg = new TextBox();
            label4 = new Label();
            clb_zemlja = new CheckedListBox();
            label3 = new Label();
            label2 = new Label();
            tb_prezime = new TextBox();
            label1 = new Label();
            tb_ime = new TextBox();
            SuspendLayout();
            // 
            // bt_izmeni
            // 
            bt_izmeni.BackColor = Color.FromArgb(83, 118, 223);
            bt_izmeni.FlatStyle = FlatStyle.Flat;
            bt_izmeni.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_izmeni.ForeColor = Color.FromArgb(201, 199, 241);
            bt_izmeni.Location = new Point(320, 234);
            bt_izmeni.Name = "bt_izmeni";
            bt_izmeni.Size = new Size(200, 34);
            bt_izmeni.TabIndex = 33;
            bt_izmeni.Text = "IZMENI PUTOVANJE";
            bt_izmeni.UseVisualStyleBackColor = false;
            bt_izmeni.Click += bt_izmeni_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.FromArgb(13, 17, 16);
            label8.Location = new Point(320, 187);
            label8.Name = "label8";
            label8.Size = new Size(112, 21);
            label8.TabIndex = 32;
            label8.Text = "Nacin prevoza:";
            // 
            // cb_nacinprevoza
            // 
            cb_nacinprevoza.BackColor = Color.White;
            cb_nacinprevoza.FormattingEnabled = true;
            cb_nacinprevoza.Items.AddRange(new object[] { "Automobil", "Motocikl", "Avio-prevoz", "Autobus" });
            cb_nacinprevoza.Location = new Point(436, 187);
            cb_nacinprevoza.Name = "cb_nacinprevoza";
            cb_nacinprevoza.Size = new Size(84, 23);
            cb_nacinprevoza.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.FromArgb(13, 17, 16);
            label7.Location = new Point(320, 120);
            label7.Name = "label7";
            label7.Size = new Size(110, 21);
            label7.TabIndex = 30;
            label7.Text = "Datum izlaska:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.FromArgb(13, 17, 16);
            label6.Location = new Point(320, 46);
            label6.Name = "label6";
            label6.Size = new Size(108, 21);
            label6.TabIndex = 29;
            label6.Text = "Datum ulaska:";
            // 
            // dtp_izlazak
            // 
            dtp_izlazak.CalendarMonthBackground = Color.FromArgb(201, 199, 241);
            dtp_izlazak.CalendarTitleBackColor = Color.FromArgb(201, 199, 241);
            dtp_izlazak.CalendarTitleForeColor = Color.FromArgb(201, 199, 241);
            dtp_izlazak.CalendarTrailingForeColor = Color.FromArgb(201, 199, 241);
            dtp_izlazak.CustomFormat = "dd/MM/yyyy";
            dtp_izlazak.Format = DateTimePickerFormat.Custom;
            dtp_izlazak.Location = new Point(320, 144);
            dtp_izlazak.Name = "dtp_izlazak";
            dtp_izlazak.ShowUpDown = true;
            dtp_izlazak.Size = new Size(200, 23);
            dtp_izlazak.TabIndex = 28;
            // 
            // dtp_ulazak
            // 
            dtp_ulazak.CalendarMonthBackground = Color.FromArgb(201, 199, 241);
            dtp_ulazak.CalendarTitleBackColor = Color.FromArgb(201, 199, 241);
            dtp_ulazak.CalendarTitleForeColor = Color.FromArgb(201, 199, 241);
            dtp_ulazak.CalendarTrailingForeColor = Color.FromArgb(201, 199, 241);
            dtp_ulazak.CustomFormat = "dd/MM/yyyy";
            dtp_ulazak.Format = DateTimePickerFormat.Custom;
            dtp_ulazak.Location = new Point(320, 71);
            dtp_ulazak.Name = "dtp_ulazak";
            dtp_ulazak.ShowUpDown = true;
            dtp_ulazak.Size = new Size(200, 23);
            dtp_ulazak.TabIndex = 27;
            // 
            // tb_jmbg
            // 
            tb_jmbg.BackColor = Color.FromArgb(201, 199, 241);
            tb_jmbg.Location = new Point(119, 203);
            tb_jmbg.Name = "tb_jmbg";
            tb_jmbg.Size = new Size(124, 23);
            tb_jmbg.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(13, 17, 16);
            label4.Location = new Point(20, 201);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 23;
            label4.Text = "JMBG:";
            // 
            // clb_zemlja
            // 
            clb_zemlja.FormattingEnabled = true;
            clb_zemlja.Items.AddRange(new object[] { "Austrija", "Belgija", "Bugarska", "Hrvatska", "Kipar", "Češka", "Danska", "Estonija", "Finska", "Francuska", "Nemačka", "Grčka", "Mađarska", "Irska", "Italija", "Latvija", "Litvanija", "Luksemburg", "Malta", "Holandija", "Poljska", "Portugalija", "Rumunija", "Slovačka", "Slovenija", "Španija", "Švedska" });
            clb_zemlja.Location = new Point(119, 144);
            clb_zemlja.Name = "clb_zemlja";
            clb_zemlja.Size = new Size(107, 40);
            clb_zemlja.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(13, 17, 16);
            label3.Location = new Point(20, 144);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 21;
            label3.Text = "Zemlja/e:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(13, 17, 16);
            label2.Location = new Point(20, 101);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 20;
            label2.Text = "Prezime:";
            // 
            // tb_prezime
            // 
            tb_prezime.BackColor = Color.FromArgb(201, 199, 241);
            tb_prezime.Location = new Point(119, 99);
            tb_prezime.Name = "tb_prezime";
            tb_prezime.Size = new Size(124, 23);
            tb_prezime.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(13, 17, 16);
            label1.Location = new Point(20, 49);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 18;
            label1.Text = "Ime:";
            // 
            // tb_ime
            // 
            tb_ime.BackColor = Color.FromArgb(201, 199, 241);
            tb_ime.Location = new Point(119, 49);
            tb_ime.Name = "tb_ime";
            tb_ime.Size = new Size(124, 23);
            tb_ime.TabIndex = 17;
            // 
            // ucIzmena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bt_izmeni);
            Controls.Add(label8);
            Controls.Add(cb_nacinprevoza);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtp_izlazak);
            Controls.Add(dtp_ulazak);
            Controls.Add(tb_jmbg);
            Controls.Add(label4);
            Controls.Add(clb_zemlja);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_prezime);
            Controls.Add(label1);
            Controls.Add(tb_ime);
            Name = "ucIzmena";
            Size = new Size(565, 350);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_izmeni;
        private Label label8;
        private ComboBox cb_nacinprevoza;
        private Label label7;
        private Label label6;
        private DateTimePicker dtp_izlazak;
        private DateTimePicker dtp_ulazak;
        private TextBox tb_jmbg;
        private Label label4;
        private CheckedListBox clb_zemlja;
        private Label label3;
        private Label label2;
        private TextBox tb_prezime;
        private Label label1;
        private TextBox tb_ime;
    }
}
