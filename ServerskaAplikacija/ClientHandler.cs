using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BazaPodataka;
using Domen;
using Zajednicki;
using Newtonsoft.Json;
using System.Data;
using JsonSerializer = System.Text.Json.JsonSerializer;
namespace ServerskaAplikacija
{
    public class ClientHandler
    {
        private Socket klijentSoket;
        
        private JsonNetworkSerializer serializer;
        private BrokerBazePodataka bbp = new BrokerBazePodataka();

        public ClientHandler(Socket klijentSoket)
        {
            this.klijentSoket = klijentSoket;
            serializer = new JsonNetworkSerializer(klijentSoket);
        }
        internal void Handle()
        {
            try
            {
                while (true)
                {

                    Zahtev z = serializer.Primi<Zahtev>();
                    Console.WriteLine($"Stigao je zahtev od klijenta: {z.operacija}");
                    Odgovor o = Procesuiraj(z);
                    serializer.Posalji(o);
                    Console.WriteLine("Klijentu je poslat odgovor");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Doslo je do greske prilikom citanja zahteva");
                Console.WriteLine(ex.Message);

            }
            finally
            {
                serializer.Zatvori();
                klijentSoket.Shutdown(SocketShutdown.Both);
                klijentSoket.Close();
            }
        }
        private Odgovor Procesuiraj(Zahtev z)
        {
            Odgovor o = new Odgovor()
            {
                signal = true
            };

            try
            {
                switch (z.operacija)
                {
                    case Operacija.izmeniPrijavu:
                        o.poruka = "Uspesno izmenjena prijava";
                       JsonElement podaci = serializer.ReadType<JsonElement>(z.podaci);
                       Prijava prijava = JsonSerializer.Deserialize<Prijava>(podaci.GetProperty("PRIJAVE").GetRawText());
                        var idPrijave = podaci.GetProperty("ID_PRIJAVE").GetInt32();
                        bbp.izmeniPrijavu(prijava, idPrijave);
                        break;

                    case Operacija.proveraUsername:
                        o.poruka = "Uspesno proveren username";
                        podaci = serializer.ReadType<JsonElement>(z.podaci);
                        string username = podaci.GetProperty("USERNAME").GetString();
                        o.podaci = bbp.proveraUsername(username);
                        break;

                    case Operacija.proveraStanovnistva:
                        o.poruka = "Uspesno provereno stanovnistvo";
                        podaci = serializer.ReadType<dynamic>(z.podaci);
                        long jmbg = podaci.GetProperty("JMBG").GetInt64();
                        long broj_pasosa = podaci.GetProperty("BROJ_PASOSA").GetInt64();
                        o.podaci = bbp.proveraStanovnistva(jmbg, broj_pasosa);
                        break;

                    case Operacija.proveriBazu:
                        o.poruka = "Uspesno proverena baza";
                        podaci = serializer.ReadType<dynamic>(z.podaci);
                        prijava = JsonSerializer.Deserialize<Prijava>(podaci.GetProperty("PRIJAVE").GetRawText());
                        o.podaci = bbp.proveriBazu(prijava);
                        break;

                    case Operacija.unesiPrijavu:
                        o.poruka = "Uspesno uneta prijava";
                        podaci = serializer.ReadType<dynamic>(z.podaci);
                        prijava = JsonSerializer.Deserialize<Prijava>(podaci.GetProperty("PRIJAVE").GetRawText());
                        bbp.unesiPrijavu(prijava);
                        break;

                    case Operacija.ucitajPodatke:
                        o.poruka = "Uspesno ucitani podaci";
                        podaci = serializer.ReadType<dynamic>(z.podaci);
                        jmbg = podaci.GetProperty("JMBG").GetInt64();
                        DataTable dataTable = bbp.ucitajPodatke(jmbg);
                        o.podaci = JsonConvert.SerializeObject(dataTable);
                        break;

                    case Operacija.UlogujSe:
                        o.poruka = "Uspesno ulogovan korisnik";
                        podaci = serializer.ReadType<JsonElement>(z.podaci);
                         username = podaci.GetProperty("USERNAME").GetString();
                        string password = podaci.GetProperty("PASSWORD").GetString();
                        o.podaci = bbp.UlogujSe(username, password);
                        break;

                    case Operacija.RegistrujSe:
                        o.poruka = "Uspesno registrovan korisnik";
                        podaci = serializer.ReadType<dynamic>(z.podaci);
                        Korisnik korisnik = JsonSerializer.Deserialize<Korisnik>(podaci.GetProperty("KORISNIK").GetRawText());
                        o.podaci = bbp.RegistrujSe(korisnik);
                        break;

                    default:
                        throw new Exception("Greska pri citanju operacije " + z.operacija);

                }
            }
            catch (Exception ex)
            {
                o.signal = false;
                o.poruka = ex.Message;
            }
            return o;
        }
    }
}
