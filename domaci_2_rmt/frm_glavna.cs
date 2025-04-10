using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;
using KlijentskaAplikacija.uiKontroler;

namespace KlijentskaAplikacija
{
    public partial class frm_glavna : Form
    {
        Korisnik k = new Korisnik();
      
        public frm_glavna(Korisnik j)
        {
            InitializeComponent();

           
       
            if (j != null)
                k = j;
            lb_username.Text = k.Ime + " " + k.Prezime;
          
            bt_prikaz_Click(this, EventArgs.Empty);
        }

        private void pn_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_prikaz_Click(object sender, EventArgs e)
        {
           
            pnl_glavni.Controls.Clear();
            ucPrikaz ucPrikaz = new ucPrikaz(k);
            ucPrikaz.Dock = DockStyle.Fill;
            pnl_glavni.Controls.Add(ucPrikaz);
        }

        private void pnl_glavni_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_prijava_Click(object sender, EventArgs e)
        {
            pnl_glavni.Controls.Clear();
            ucPrijava ucPrijava = new ucPrijava(k);
            ucPrijava.Dock = DockStyle.Fill;
            pnl_glavni.Controls.Add(ucPrijava);
        }

        private void lb_username_Click(object sender, EventArgs e)
        {

        }

        private void bt_logout_Click(object sender, EventArgs e)
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
