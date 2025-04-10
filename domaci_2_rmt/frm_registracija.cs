using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazaPodataka;
using Domen;
using KlijentskaAplikacija.uiKontroler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace KlijentskaAplikacija
{
    public partial class frm_registracija : Form
    {
        public frm_registracija()
        {
            this.Draggable(true);
            InitializeComponent();
        }
        public void Ocisti()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
            }
        }
        bool proveraPolja()
        {
            long res;
            if(!tb_email.Text.Contains("@") && !tb_email.Text.Contains("."))
            {
                MessageBox.Show("Nedozvoljen format za email!");
                return false;
            }
            if (tb_jmbg.Text.Length != 13 || !long.TryParse(tb_jmbg.Text, out res))
            {
                MessageBox.Show("Nedozvoljen format za JMBG!");
                return false;
            }
            if (tb_username.Text == "" || tb_username.Text.Contains(" "))
            {
                MessageBox.Show("Nedozvoljen format za korisnicko ime!");
                return false;
            }
            if (tb_brojpasosa.Text.Length != 13 || !long.TryParse(tb_brojpasosa.Text, out res))
            {
                MessageBox.Show("Nedozvoljen format za broj pasosa!");
                return false;
            }
            return true;
        }
        private void bt_registruj_Click(object sender, EventArgs e)
        {

            if (!proveraPolja())
            {
                return;
            }
            if (UIKontroler.Instance.proveraStanovnistva(long.Parse(tb_jmbg.Text), long.Parse(tb_brojpasosa.Text)) && UIKontroler.Instance.proveraUsername(tb_username.Text))
            {
                Korisnik k = new Korisnik(tb_ime.Text, tb_prezime.Text, tb_email.Text, tb_username.Text, tb_sifra.Text, long.Parse(tb_jmbg.Text), long.Parse(tb_brojpasosa.Text));
                if (UIKontroler.Instance.RegistrujSe(k))
                {
                    MessageBox.Show("Korisnik je uspesno registrovan!");
                    lk_login_LinkClicked(this, null);
                }

                else
                    MessageBox.Show("Neuspesna registracija.Pokusajte opet.");
                Ocisti();
            }
            else
                MessageBox.Show("Ne mozete se registrovati jer niste drzavljanin Srbije!");
        }

        private void lk_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frm_login log = new frm_login();
            int centerX = this.Left + (this.Width - log.Width) / 2;
            int centerY = this.Top + (this.Height - log.Height) / 2;
            log.StartPosition = FormStartPosition.Manual;
            log.Location = new Point(centerX, centerY);

            log.Draggable(true);
            this.Hide();
            log.ShowDialog();
            this.Close();
        }
    }
}
