namespace KlijentskaAplikacija
{
    partial class ucPrikaz
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
            dataGridView1 = new DataGridView();
            bt_izmeni = new Button();
            bt_prikaz_jmbg = new Button();
            tb_jmbg = new TextBox();
            tb_brojpasosa = new TextBox();
            lb_1 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 15);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(449, 344);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bt_izmeni
            // 
            bt_izmeni.BackColor = Color.FromArgb(83, 118, 223);
            bt_izmeni.FlatStyle = FlatStyle.Flat;
            bt_izmeni.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_izmeni.ForeColor = Color.FromArgb(201, 199, 241);
            bt_izmeni.Location = new Point(480, 325);
            bt_izmeni.Name = "bt_izmeni";
            bt_izmeni.Size = new Size(200, 34);
            bt_izmeni.TabIndex = 17;
            bt_izmeni.Text = "MOD IZMENE";
            bt_izmeni.UseVisualStyleBackColor = false;
            bt_izmeni.Click += bt_izmeni_Click;
            // 
            // bt_prikaz_jmbg
            // 
            bt_prikaz_jmbg.BackColor = Color.FromArgb(83, 118, 223);
            bt_prikaz_jmbg.FlatStyle = FlatStyle.Flat;
            bt_prikaz_jmbg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_prikaz_jmbg.ForeColor = Color.FromArgb(201, 199, 241);
            bt_prikaz_jmbg.Location = new Point(480, 285);
            bt_prikaz_jmbg.Name = "bt_prikaz_jmbg";
            bt_prikaz_jmbg.Size = new Size(200, 34);
            bt_prikaz_jmbg.TabIndex = 18;
            bt_prikaz_jmbg.Text = "PRIKAZ(JMBG)";
            bt_prikaz_jmbg.UseVisualStyleBackColor = false;
            bt_prikaz_jmbg.Click += bt_prikaz_jmbg_Click;
            // 
            // tb_jmbg
            // 
            tb_jmbg.BackColor = Color.FromArgb(201, 199, 241);
            tb_jmbg.BorderStyle = BorderStyle.None;
            tb_jmbg.Font = new Font("Segoe UI", 14.25F);
            tb_jmbg.Location = new Point(480, 145);
            tb_jmbg.Name = "tb_jmbg";
            tb_jmbg.Size = new Size(200, 26);
            tb_jmbg.TabIndex = 19;
            // 
            // tb_brojpasosa
            // 
            tb_brojpasosa.BackColor = Color.FromArgb(201, 199, 241);
            tb_brojpasosa.BorderStyle = BorderStyle.None;
            tb_brojpasosa.Font = new Font("Segoe UI", 14.25F);
            tb_brojpasosa.Location = new Point(480, 194);
            tb_brojpasosa.Name = "tb_brojpasosa";
            tb_brojpasosa.Size = new Size(200, 26);
            tb_brojpasosa.TabIndex = 20;
            // 
            // lb_1
            // 
            lb_1.AutoSize = true;
            lb_1.Location = new Point(480, 127);
            lb_1.Name = "lb_1";
            lb_1.Size = new Size(40, 15);
            lb_1.TabIndex = 21;
            lb_1.Text = "JMBG:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 176);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 22;
            label1.Text = "BROJ PASOSA:";
            // 
            // ucPrikaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(lb_1);
            Controls.Add(tb_brojpasosa);
            Controls.Add(tb_jmbg);
            Controls.Add(bt_prikaz_jmbg);
            Controls.Add(bt_izmeni);
            Controls.Add(dataGridView1);
            Name = "ucPrikaz";
            Size = new Size(714, 387);
            Load += ucPrikaz_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button bt_izmeni;
        private Button bt_prikaz_jmbg;
        private TextBox tb_jmbg;
        private TextBox tb_brojpasosa;
        private Label lb_1;
        private Label label1;
    }
}
