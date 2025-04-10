using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazaPodataka;
using Domen;
using KlijentskaAplikacija.uiKontroler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace KlijentskaAplikacija
{
    public partial class ucIzmena : UserControl
    {
        string[] selectedCountries;
        Korisnik k = new Korisnik();
        int id_prijave;
        public bool imaPraznihPolja()
        {
            if (tb_ime.Text == "" || tb_prezime.Text == "" || tb_jmbg.Text == "" || cb_nacinprevoza.SelectedItem == null)
            {
                MessageBox.Show("Morate popuniti sva polja!");
                return true;
            }
            return false;
        }
        public bool proveriDatume()
        {
            if (dtp_ulazak.Value > dtp_izlazak.Value)
                return false;
            return true;
        }
        public ucIzmena(Korisnik j,string ime, string prezime, long jmbg, string zemlje, DateTime datum_ulaska, DateTime datum_izlaska, string nacin_prevoza,int id_p)
        {
            InitializeComponent();
            id_prijave = id_p;
            tb_ime.Text = ime;
            tb_prezime.Text = prezime;
            tb_jmbg.Text = jmbg.ToString();
            selectedCountries = zemlje.Split(',');
            for (int i = 0; i < clb_zemlja.Items.Count; i++)
            {
                if (selectedCountries.Contains(clb_zemlja.Items[i].ToString()))
                    clb_zemlja.SetItemChecked(i, true);
            }
            dtp_ulazak.Value = datum_ulaska;
            dtp_izlazak.Value = datum_izlaska;
            if (cb_nacinprevoza.Items.Contains(nacin_prevoza))
                cb_nacinprevoza.SelectedItem = nacin_prevoza;
            k = j;
        }
        public void proveriTrajanje()
        {
            if ((dtp_izlazak.Value - dtp_ulazak.Value).TotalDays > 90)
            {
                dtp_izlazak.Value = dtp_ulazak.Value.AddDays(90);
            }
        }
        private void bt_izmeni_Click(object sender, EventArgs e)
        {
            if (proveriDatume())
            {
                if (!imaPraznihPolja())
                {
                    long jmbg = long.Parse(tb_jmbg.Text);
                    string zemlje = "";
                    foreach (var x in clb_zemlja.CheckedItems)
                    {
                        zemlje += x.ToString() + ",";
                    }
                    proveriTrajanje();
                    Prijava p = new Prijava(tb_ime.Text, tb_prezime.Text, zemlje, jmbg, dtp_ulazak.Value, dtp_izlazak.Value, cb_nacinprevoza.SelectedItem.ToString());

                    UIKontroler.Instance.izmeniPrijavu(p,id_prijave);
                    MessageBox.Show("Uspesno ste izmenili!!");
                    this.Controls.Clear();
                    ucPrikaz ucPrikaz = new ucPrikaz(k);
                    ucPrikaz.Dock = DockStyle.Fill;
                    this.Controls.Add(ucPrikaz);
                }


            }
            else
                MessageBox.Show("Datum izlaska mora biti veci od datuma ulaska!");
        }
    }
}
