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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KlijentskaAplikacija
{
    public partial class ucPrijava : UserControl
    {
  
        Korisnik k = new Korisnik();
        public ucPrijava(Korisnik j)
        {
            InitializeComponent();
                k = j;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public bool proveriDatume()
        {
            if (dtp_ulazak.Value > dtp_izlazak.Value)
                return false;
            return true;
        }
        public void ispuniPodatke()
        {
            tb_ime.Text = k.Ime;
            tb_prezime.Text = k.Prezime;
            tb_jmbg.Text = k.Jmbg.ToString();
            tb_brojpasosa.Text = k.Broj_pasosa.ToString();
            tb_ime.ReadOnly = true;
            tb_prezime.ReadOnly = true;
            tb_jmbg.ReadOnly = true;
            tb_brojpasosa.ReadOnly = true;
            

        }
        public void proveriTrajanje()
        {
            if ((dtp_izlazak.Value - dtp_ulazak.Value).TotalDays > 90)
            {
                dtp_izlazak.Value = dtp_ulazak.Value.AddDays(90);
            }
        }
        public bool imaPraznihPolja()
        {
            if (tb_brojpasosa.Text == "" || tb_ime.Text == "" || tb_prezime.Text == "" || tb_jmbg.Text == "" || cb_nacinprevoza.SelectedItem == null)
            {
               
                return true;
            }
            return false;
        }
        public string ProveraPlacanja(string jmbg)
        {
            string dan = jmbg[0].ToString() + jmbg[1].ToString();
            string mesec = jmbg[2].ToString() + jmbg[3].ToString();
            string godina = jmbg[4].ToString() + jmbg[5].ToString() + jmbg[6].ToString();
            if (jmbg[4].ToString() == "9")
                godina = "1" + godina;
            else
                godina = "2" + godina;
            string datum = dan + "." + mesec + "." + godina;
            DateTime datumRodjenja = DateTime.Parse(datum);
            DateTime datumDanas = DateTime.Now;
            int godine_trenutne = datumDanas.Year - datumRodjenja.Year;
            if (datumDanas < datumRodjenja.AddYears(godine_trenutne))
                godine_trenutne--;
            if (godine_trenutne >= 18 && godine_trenutne <= 70)
                return "Placa se";
            else
                return "Ne placa se";
        }
        public void Cuvanje(Prijava p)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string content = "Ime: " + p.Ime + Environment.NewLine +
                                     "Prezime: " + p.Prezime + Environment.NewLine +
                                     "JMBG: " +p.Jmbg + Environment.NewLine +
                                     "Broj pasosa: " + p.Brojpasosa + Environment.NewLine +
                                     "Zemlje: " + p.Zemlje + Environment.NewLine +
                                        "Datum ulaska: " + p.Datum_ulaska + Environment.NewLine +
                                        "Datum izlaska: " + p.Datum_izlaska + Environment.NewLine +
                                        "Nacin prevoza: " + p.Nacin_prevoza + Environment.NewLine +
                                        "Placanje: " + ProveraPlacanja(p.Jmbg.ToString()) + Environment.NewLine;


                 
                    File.WriteAllText(filePath,content);
                    
                }
            }
        }
        private void bt_prijavi_Click(object sender, EventArgs e)
        {
            if (proveriDatume())
            {
                if (!imaPraznihPolja())
                {

                    long jmbg = long.Parse(tb_jmbg.Text);
                    long brojPasosa = long.Parse(tb_brojpasosa.Text);
                    string zemlje = "";
                    foreach (var x in clb_zemlja.CheckedItems)
                    {
                        zemlje += x.ToString() + ",";
                    }
                    if (zemlje == "")
                    {
                        MessageBox.Show("Morate izabrati zemlje!");
                        return;
                    }
                    proveriTrajanje();
                    Prijava p = new Prijava(tb_ime.Text, tb_prezime.Text, zemlje, jmbg, brojPasosa, dtp_ulazak.Value, dtp_izlazak.Value, cb_nacinprevoza.SelectedItem.ToString());
                    if (UIKontroler.Instance.proveriBazu(p))
                    {

                        UIKontroler.Instance.unesiPrijavu(p);
                        Cuvanje(p);
                        MessageBox.Show("Uspesno ste prijavili putovanje!!");

                    }
                    else
                        MessageBox.Show("Vec postoji prijava u tom terminu!"); 
                }
                else
                {
                    MessageBox.Show("Morate popuniti sva polja!");
                }
            }
            else
                MessageBox.Show("Datum izlaska mora biti veci od datuma ulaska!");


        }

        private void ucPrijava_Load(object sender, EventArgs e)
        {
                ispuniPodatke();
        }
    }
}
