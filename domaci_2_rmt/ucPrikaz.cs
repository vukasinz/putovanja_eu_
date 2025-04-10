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

namespace KlijentskaAplikacija
{
    public partial class ucPrikaz : UserControl
    {
        Korisnik j = new Korisnik();

        public ucPrikaz(Korisnik k)
        {
            InitializeComponent();

            j = k;
            dataGridView1.DataSource = UIKontroler.Instance.ucitajPodatke(j.Jmbg);
            editujPrikaz();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_izmeni_Click(object sender, EventArgs e)
        {

            this.Controls.Clear();
            string ime = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string prezime = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            long jmbg = long.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            int id_p = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

            string zemlje = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            DateTime datum_ulaska = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            DateTime datum_izlaska = DateTime.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            string nacin_prevoza = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            ucIzmena ucIzmena = new ucIzmena(j, ime, prezime, jmbg, zemlje, datum_ulaska, datum_izlaska, nacin_prevoza, id_p);
            ucIzmena.Dock = DockStyle.Fill;
            this.Controls.Add(ucIzmena);

        }

        private void ucPrikaz_Load(object sender, EventArgs e)
        {

        }
        void editujPrikaz()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
              
                    DateTime datum_ulaska = Convert.ToDateTime(row.Cells[5].Value);  
                    DateTime datum_izlaska = Convert.ToDateTime(row.Cells[6].Value);

                if (datum_ulaska < DateTime.Now && datum_ulaska.AddHours(48) >= DateTime.Now) { 
                    row.Cells["prijava"].Value = "Zakljucana";
                }
                else if (DateTime.Now < datum_ulaska) { 
                    row.Cells["prijava"].Value = "U Obradi";
                }
                else if (datum_izlaska <= DateTime.Now) {
                    row.Cells["prijava"].Value = "Zavrsena"; 
                }



            }
            dataGridView1.Refresh();
        }
        private void bt_prikaz_jmbg_Click(object sender, EventArgs e)
        {
            string jmbg = tb_jmbg.Text;
            string broj_pasosa = tb_brojpasosa.Text;
           
            if (jmbg == broj_pasosa)
            {
                dataGridView1.DataSource = UIKontroler.Instance.ucitajPodatke(long.Parse(jmbg));
                editujPrikaz();
            }
            else
                MessageBox.Show("JMBG i broj pasosa se ne poklapaju!");
        }
    }
}
