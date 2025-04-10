using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Prijava
    {
        string ime;
        string prezime;
        string zemlje;
        long jmbg;
        long brojpasosa;
        DateTime datum_ulaska;
        DateTime datum_izlaska;
        string nacin_prevoza;
        int id_prijave;
        public Prijava()
        {

        }
        public Prijava(string ime, string prezime, string zemlje, long jmbg, long brojpasosa, DateTime datum_ulaska, DateTime datum_izlaska, string nacin_prevoza)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.zemlje = zemlje;
            this.jmbg = jmbg;
            this.brojpasosa = brojpasosa;
            this.datum_ulaska = datum_ulaska;
            this.datum_izlaska = datum_izlaska;
            this.nacin_prevoza = nacin_prevoza;
        }
        public Prijava(string ime, string prezime, string zemlje, long jmbg, DateTime datum_ulaska, DateTime datum_izlaska, string nacin_prevoza)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.zemlje = zemlje;
            this.jmbg = jmbg;
            this.datum_ulaska = datum_ulaska;
            this.datum_izlaska = datum_izlaska;
            this.nacin_prevoza = nacin_prevoza;
           
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Zemlje { get => zemlje; set => zemlje = value; }
        public long Jmbg { get => jmbg; set => jmbg = value; }
        public long Brojpasosa { get => brojpasosa; set => brojpasosa = value; }
        public DateTime Datum_ulaska { get => datum_ulaska; set => datum_ulaska = value; }
        public DateTime Datum_izlaska { get => datum_izlaska; set => datum_izlaska = value; }
        public string Nacin_prevoza { get => nacin_prevoza; set => nacin_prevoza = value; }
        public int Id_prijave { get => id_prijave; }
    }
}
