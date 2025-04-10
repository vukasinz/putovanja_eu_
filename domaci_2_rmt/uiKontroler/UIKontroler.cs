using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Zajednicki;

namespace KlijentskaAplikacija.uiKontroler
{
    internal class UIKontroler
    {
        public Socket soket;
        public JsonNetworkSerializer serializer;
        private static UIKontroler instance;
        public static UIKontroler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UIKontroler();
                }
                return instance;
            }
        }
        public UIKontroler()
        {
            soket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

        }
        public void PoveziSe()
        {
            try
            {
                soket.Connect("127.0.0.1", 9999);
                
                serializer = new JsonNetworkSerializer(soket);
            }
            catch (Exception x)
            {

                throw new Exception("Neuspesno povezivanje");
            }
        }
       
        public void izmeniPrijavu(Prijava p, int id_prijave)
        {
            Zahtev z = new Zahtev
            {
                operacija = Operacija.izmeniPrijavu,
                podaci = new
                {
                    PRIJAVE = p,
                    ID_PRIJAVE = id_prijave
                }
            };
            serializer.Posalji(z);
            Odgovor o = serializer.Primi<Odgovor>();
            if (!o.signal)
                throw new Exception(o.poruka);
        }
        public bool proveraUsername(string username)
        {
            Zahtev z = new Zahtev()
            {
                operacija = Operacija.proveraUsername,
                podaci = new
                {
                    USERNAME = username
                }
            };
            serializer.Posalji(z);
            Odgovor o = serializer.Primi<Odgovor>();
            if (o.signal)
            {
                return serializer.ReadType<bool>(o.podaci);

            }
            else
                throw new Exception(o.poruka);
        }
        public bool proveraStanovnistva(long jmbg, long broj_pasosa)
        {
            Zahtev z = new Zahtev()
            {
                operacija = Operacija.proveraStanovnistva,
                podaci = new
                {
                    JMBG = jmbg,
                    BROJ_PASOSA = broj_pasosa
                }
            };
            serializer.Posalji(z);
            Odgovor o = serializer.Primi<Odgovor>();
            if (o.signal)
            {
                return serializer.ReadType<bool>(o.podaci);

            }
            else
                throw new Exception(o.poruka);
        }
        public bool proveriBazu(Prijava p)
        {
            Zahtev z = new Zahtev()
            {
                operacija = Operacija.proveriBazu,
                podaci = new
                {
                    PRIJAVE = p
                }
            };
            serializer.Posalji(z);
            Odgovor o = serializer.Primi<Odgovor>();
            if (o.signal)
            {
                return serializer.ReadType<bool>(o.podaci);

            }
            else
                throw new Exception(o.poruka);
        }
        public void unesiPrijavu(Prijava p)
        {
            Zahtev z = new Zahtev()
            {
                operacija = Operacija.unesiPrijavu,
                podaci = new
                {
                    PRIJAVE = p
                }
            };
            serializer.Posalji(z);
            Odgovor o = serializer.Primi<Odgovor>();
            if (!o.signal)
                throw new Exception(o.poruka);
        }
        public DataTable ucitajPodatke(long jmbg)
        {
            Zahtev z = new Zahtev()
            {
                operacija = Operacija.ucitajPodatke,
                podaci = new
                {
                    JMBG = jmbg
                }
            };
            serializer.Posalji(z);
            Odgovor o = serializer.Primi<Odgovor>();
            if (o.signal)
            {
                return JsonConvert.DeserializeObject<DataTable>(o.podaci.ToString());

            }
            else
                throw new Exception(o.poruka);
        }

        public Korisnik UlogujSe(string username, string password)
        {
            Zahtev z = new Zahtev
            {
                operacija = Operacija.UlogujSe,
                podaci = new 
                {
                    USERNAME = username,
                    PASSWORD = password
                }
            };
            serializer.Posalji(z);
            Odgovor o = serializer.Primi<Odgovor>();
            if(o.signal)
                return serializer.ReadType<Korisnik>(o.podaci);
            else
                throw new Exception(o.poruka);

           
        }
        public bool RegistrujSe(Korisnik k)
        {
            Zahtev z = new Zahtev
            {
                operacija = Operacija.RegistrujSe,
                podaci = new
                {
                    KORISNIK = k
                }
            };
            serializer.Posalji(z);
            Odgovor o = serializer.Primi<Odgovor>();
            if (o.signal)
                return serializer.ReadType<bool>(o.podaci);
            else
                throw new Exception(o.poruka);


        }
    }
}
