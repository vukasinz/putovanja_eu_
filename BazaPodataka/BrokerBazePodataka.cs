using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace BazaPodataka
{
    public class BrokerBazePodataka
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PutovanjaEU;Integrated Security=True");
        public static BrokerBazePodataka instance;
        public static BrokerBazePodataka Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BrokerBazePodataka();
                }
                return instance;
            }
        }
        public void Connect()
        {
            try
            {
                con.Open();
            }
            catch (Exception x)
            {

              
            }
        }
        public void Disconnect()
        {
            con.Close();
        }
   
        public void izmeniPrijavu(Prijava p,int id_prijave)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand($"update Prijava set zemlja = '{p.Zemlje}', datum_ulaska = '{p.Datum_ulaska}', datum_izlaska = '{p.Datum_izlaska}', nacin_prevoza = '{p.Nacin_prevoza}' WHERE jmbg = '{p.Jmbg}' AND id_prijave = '{id_prijave}'", con);
                cmd.ExecuteNonQuery();
                Disconnect();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool proveraUsername(string username)
        {
          
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand($"select count(*) from Korisnik where korisnicko_ime = '{username}'", con);
                int b = (int)cmd.ExecuteScalar();
                if (b == 0)
                {
                    Disconnect();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Disconnect();
            }
            return false;
        }
        public bool proveraStanovnistva(long jmbg, long broj_pasosa)
        {
            Connect();
            try
            {
                
                SqlCommand cmd = new SqlCommand($"select jmbg,broj_pasosa from Stanovnistvo where jmbg = '{jmbg}' and broj_pasosa = '{broj_pasosa}'", con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                     
                        string procitaniJmbg = reader["jmbg"].ToString();
                        string procitaniBrojPasosa = reader["broj_pasosa"].ToString();
                        if (procitaniJmbg == jmbg.ToString() && procitaniBrojPasosa == broj_pasosa.ToString())
                        {
                            Disconnect();
                            return true;
                        }

                    }
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Disconnect();
              
            }
            return false;
        }

        public bool proveriBazu(Prijava p)
        {
            Connect();
            List<DateTime> datumi_ulaska = new();
            List<DateTime> datumi_izlaska = new();
            List<string> zemlje = new();
            try
            {
                SqlCommand cmd = new SqlCommand($"SELECT zemlja, datum_ulaska, datum_izlaska FROM Prijava WHERE jmbg = @Jmbg", con);
                cmd.Parameters.AddWithValue("@Jmbg", p.Jmbg);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime datum_ulaska = reader.IsDBNull(reader.GetOrdinal("datum_ulaska"))
                                                ? DateTime.MinValue
                                                : reader.GetDateTime(reader.GetOrdinal("datum_ulaska"));
                        DateTime datum_izlaska = reader.IsDBNull(reader.GetOrdinal("datum_izlaska"))
                                                ? DateTime.MinValue
                                                : reader.GetDateTime(reader.GetOrdinal("datum_izlaska"));

                        datumi_ulaska.Add(datum_ulaska);
                        datumi_izlaska.Add(datum_izlaska);

                        string z = reader.IsDBNull(reader.GetOrdinal("zemlja"))
                                   ? ""
                                   : reader.GetString(reader.GetOrdinal("zemlja"));
                        string[] baza_zemlje = z.Split(',').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

                        zemlje.AddRange(baza_zemlje);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while accessing the database.", ex);
            }
            finally
            {
                Disconnect();
            }

            if (!datumi_ulaska.Any() || !datumi_izlaska.Any())
                return true;

            string[] prijava_zemlje = p.Zemlje.Split(',').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

            for (int i = 0; i < datumi_ulaska.Count; i++)
            {
                if (!(p.Datum_izlaska <= datumi_ulaska[i] || p.Datum_ulaska >= datumi_izlaska[i]))
                {
                    if (prijava_zemlje.Any(z => zemlje.Contains(z)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }


        public void unesiPrijavu(Prijava p)
        {
            Connect();
            try
            {
                
                SqlCommand cmd = new SqlCommand($"insert into Prijava values(@zemlja,@jmbg,@broj_pasosa,@datum_ulaska,@datum_izlaska,@nacin_prevoza)", con);
                cmd.Parameters.AddWithValue("zemlja", p.Zemlje);
                cmd.Parameters.AddWithValue("jmbg", p.Jmbg);
                cmd.Parameters.AddWithValue("broj_pasosa", p.Brojpasosa);
                cmd.Parameters.AddWithValue("datum_ulaska", p.Datum_ulaska);
                cmd.Parameters.AddWithValue("datum_izlaska", p.Datum_izlaska);
                cmd.Parameters.AddWithValue("nacin_prevoza", p.Nacin_prevoza);
                cmd.ExecuteNonQuery();



                Disconnect();
                

            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable ucitajPodatke(long jmbg)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand($"select k.ime,k.prezime,k.jmbg,p.id_prijave,p.zemlja,p.datum_ulaska,p.datum_izlaska,p.nacin_prevoza from Prijava p join Korisnik k on p.jmbg = '{jmbg}' where k.jmbg = '{jmbg}'",con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns.Add("prijava",typeof(string));
                
                Disconnect();
                return dt;
            }
            catch (Exception x)
            {

                throw;
            }

        }
        public Korisnik UlogujSe(string username,string password)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand($"select * from Korisnik where korisnicko_ime = @username and sifra = @lozinka", con);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("lozinka", password);

                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        long jmbg = reader.IsDBNull(reader.GetOrdinal("jmbg")) ? 0 : Convert.ToInt64(reader["jmbg"]);
                        long brojPasosa = reader.IsDBNull(reader.GetOrdinal("broj_pasosa")) ? 0 : Convert.ToInt64(reader["broj_pasosa"]);
                        Korisnik k = new Korisnik(reader["ime"].ToString(), reader["prezime"].ToString(), reader["email"].ToString(), reader["korisnicko_ime"].ToString(), reader["sifra"].ToString(), jmbg,brojPasosa);
                        Disconnect();
                        return k;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            Disconnect();
            return null;
          
        }
        public bool RegistrujSe(Korisnik k)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand($"insert into Korisnik values(@ime,@prezime,@email,@jmbg,@broj_pasosa,@korisnicko_ime,@sifra)", con);
                cmd.Parameters.AddWithValue("ime", k.Ime);
                cmd.Parameters.AddWithValue("prezime", k.Prezime);
                cmd.Parameters.AddWithValue("email", k.Email);
                cmd.Parameters.AddWithValue("jmbg", k.Jmbg);
                cmd.Parameters.AddWithValue("broj_pasosa", k.Broj_pasosa);
                cmd.Parameters.AddWithValue("korisnicko_ime", k.Username);
                cmd.Parameters.AddWithValue("sifra", k.Password);
                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                Disconnect();
                return false;
            }
            finally
            {
                Disconnect();

            }
            return true;
        }
    }
}
