using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazaPodataka;
using Domen;
using KlijentskaAplikacija.uiKontroler;

namespace KlijentskaAplikacija
{
    public partial class frm_login : Form
    {
        public frm_login()
        {

            this.Draggable(true);
            InitializeComponent();

        }

        private void lk_registracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_registracija reg = new frm_registracija();
            int centerX = this.Left + (this.Width - reg.Width) / 2;
            int centerY = this.Top + (this.Height - reg.Height) / 2;
            reg.StartPosition = FormStartPosition.Manual;
            reg.Location = new Point(centerX, centerY);



            this.Hide();
            reg.ShowDialog();
            this.Close();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            if (!UIKontroler.Instance.soket.Connected)
                UIKontroler.Instance.PoveziSe();
            Korisnik k = UIKontroler.Instance.UlogujSe(username, password);
            MessageBox.Show("Uspesno ste se ulogovali!");
            if (k != null)
            {

                frm_glavna glavna = new frm_glavna(k);
                int centerX = this.Left + (this.Width - glavna.Width) / 2;
                int centerY = this.Top + (this.Height - glavna.Height) / 2;
                glavna.StartPosition = FormStartPosition.Manual;
                glavna.Location = new Point(centerX, centerY);
                glavna.Draggable(true);

                this.Hide();
                glavna.ShowDialog();
                this.Close();

            }
            else
                MessageBox.Show("Pogresni podaci!");


        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
