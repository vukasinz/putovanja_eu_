namespace KlijentskaAplikacija
{
    partial class ucPrijava
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
            tb_ime = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tb_prezime = new TextBox();
            label3 = new Label();
            clb_zemlja = new CheckedListBox();
            label4 = new Label();
            tb_jmbg = new TextBox();
            label5 = new Label();
            tb_brojpasosa = new TextBox();
            dtp_ulazak = new DateTimePicker();
            dtp_izlazak = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            cb_nacinprevoza = new ComboBox();
            label8 = new Label();
            bt_prijavi = new Button();
            SuspendLayout();
            // 
            // tb_ime
            // 
            tb_ime.Location = new Point(123, 52);
            tb_ime.Name = "tb_ime";
            tb_ime.Size = new Size(124, 23);
            tb_ime.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(13, 17, 16);
            label1.Location = new Point(24, 52);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 1;
            label1.Text = "Ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(13, 17, 16);
            label2.Location = new Point(24, 104);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 3;
            label2.Text = "Prezime:";
            // 
            // tb_prezime
            // 
            tb_prezime.Location = new Point(123, 102);
            tb_prezime.Name = "tb_prezime";
            tb_prezime.Size = new Size(124, 23);
            tb_prezime.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(13, 17, 16);
            label3.Location = new Point(24, 147);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 4;
            label3.Text = "Zemlja/e:";
            // 
            // clb_zemlja
            // 
            clb_zemlja.FormattingEnabled = true;
            clb_zemlja.Items.AddRange(new object[] { "Austrija", "Belgija", "Bugarska", "Hrvatska", "Kipar", "Češka", "Danska", "Estonija", "Finska", "Francuska", "Nemačka", "Grčka", "Mađarska", "Irska", "Italija", "Latvija", "Litvanija", "Luksemburg", "Malta", "Holandija", "Poljska", "Portugalija", "Rumunija", "Slovačka", "Slovenija", "Španija", "Švedska" });
            clb_zemlja.Location = new Point(123, 147);
            clb_zemlja.Name = "clb_zemlja";
            clb_zemlja.Size = new Size(107, 40);
            clb_zemlja.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(13, 17, 16);
            label4.Location = new Point(24, 204);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 6;
            label4.Text = "JMBG:";
            // 
            // tb_jmbg
            // 
            tb_jmbg.Location = new Point(123, 206);
            tb_jmbg.Name = "tb_jmbg";
            tb_jmbg.Size = new Size(124, 23);
            tb_jmbg.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.FromArgb(13, 17, 16);
            label5.Location = new Point(24, 248);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 8;
            label5.Text = "Broj pasosa:";
            // 
            // tb_brojpasosa
            // 
            tb_brojpasosa.Location = new Point(123, 246);
            tb_brojpasosa.Name = "tb_brojpasosa";
            tb_brojpasosa.Size = new Size(124, 23);
            tb_brojpasosa.TabIndex = 9;
            // 
            // dtp_ulazak
            // 
            dtp_ulazak.CustomFormat = "dd/MM/yyyy";
            dtp_ulazak.Format = DateTimePickerFormat.Custom;
            dtp_ulazak.Location = new Point(324, 74);
            dtp_ulazak.Name = "dtp_ulazak";
            dtp_ulazak.ShowUpDown = true;
            dtp_ulazak.Size = new Size(200, 23);
            dtp_ulazak.TabIndex = 10;
            dtp_ulazak.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtp_izlazak
            // 
            dtp_izlazak.CustomFormat = "dd/MM/yyyy";
            dtp_izlazak.Format = DateTimePickerFormat.Custom;
            dtp_izlazak.Location = new Point(324, 147);
            dtp_izlazak.Name = "dtp_izlazak";
            dtp_izlazak.ShowUpDown = true;
            dtp_izlazak.Size = new Size(200, 23);
            dtp_izlazak.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.FromArgb(13, 17, 16);
            label6.Location = new Point(324, 49);
            label6.Name = "label6";
            label6.Size = new Size(108, 21);
            label6.TabIndex = 12;
            label6.Text = "Datum ulaska:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.FromArgb(13, 17, 16);
            label7.Location = new Point(324, 123);
            label7.Name = "label7";
            label7.Size = new Size(110, 21);
            label7.TabIndex = 13;
            label7.Text = "Datum izlaska:";
            // 
            // cb_nacinprevoza
            // 
            cb_nacinprevoza.FormattingEnabled = true;
            cb_nacinprevoza.Items.AddRange(new object[] { "Automobil", "Motocikl", "Avio-prevoz", "Autobus" });
            cb_nacinprevoza.Location = new Point(440, 190);
            cb_nacinprevoza.Name = "cb_nacinprevoza";
            cb_nacinprevoza.Size = new Size(84, 23);
            cb_nacinprevoza.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.FromArgb(13, 17, 16);
            label8.Location = new Point(324, 190);
            label8.Name = "label8";
            label8.Size = new Size(112, 21);
            label8.TabIndex = 15;
            label8.Text = "Nacin prevoza:";
            // 
            // bt_prijavi
            // 
            bt_prijavi.BackColor = Color.FromArgb(83, 118, 223);
            bt_prijavi.FlatStyle = FlatStyle.Flat;
            bt_prijavi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_prijavi.ForeColor = Color.FromArgb(201, 199, 241);
            bt_prijavi.Location = new Point(324, 235);
            bt_prijavi.Name = "bt_prijavi";
            bt_prijavi.Size = new Size(200, 34);
            bt_prijavi.TabIndex = 16;
            bt_prijavi.Text = "PRIJAVI PUTOVANJE";
            bt_prijavi.UseVisualStyleBackColor = false;
            bt_prijavi.Click += bt_prijavi_Click;
            // 
            // ucPrijava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bt_prijavi);
            Controls.Add(label8);
            Controls.Add(cb_nacinprevoza);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtp_izlazak);
            Controls.Add(dtp_ulazak);
            Controls.Add(tb_brojpasosa);
            Controls.Add(label5);
            Controls.Add(tb_jmbg);
            Controls.Add(label4);
            Controls.Add(clb_zemlja);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_prezime);
            Controls.Add(label1);
            Controls.Add(tb_ime);
            Name = "ucPrijava";
            Size = new Size(565, 350);
            Load += ucPrijava_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_ime;
        private Label label1;
        private Label label2;
        private TextBox tb_prezime;
        private Label label3;
        private CheckedListBox clb_zemlja;
        private Label label4;
        private TextBox tb_jmbg;
        private Label label5;
        private TextBox tb_brojpasosa;
        private DateTimePicker dtp_ulazak;
        private DateTimePicker dtp_izlazak;
        private Label label6;
        private Label label7;
        private ComboBox cb_nacinprevoza;
        private Label label8;
        private Button bt_prijavi;
    }
}
