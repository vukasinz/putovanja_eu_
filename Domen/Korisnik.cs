namespace Domen
{
    public class Korisnik
    {
        private string ime;
        private string prezime;
        private string email;
        private string username;
        private string password;
        private long jmbg;
        private long broj_pasosa;
        public Korisnik()
        {

        }
        public Korisnik(string ime, string prezime, string email, string username, string password, long jmbg, long broj_pasosa)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.username = username;
            this.password = password;
            this.jmbg = jmbg;
            this.broj_pasosa = broj_pasosa;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public long Jmbg { get => jmbg; set => jmbg = value; }
        public long Broj_pasosa { get => broj_pasosa; set => broj_pasosa = value; }
    }
}
