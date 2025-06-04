using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProiectPaw
{
    public class PortofoliuAsigurari : IEnumerable<Asigurare>, ICloneable
    {
        private List<Asigurare> asigurari = new List<Asigurare>();
        private List<Client> clienti = new List<Client>();

        public void AdaugaAsigurare(Asigurare asigurare) => asigurari.Add(asigurare);
        public void StergeAsigurare(string numarPolita) => asigurari.RemoveAll(a => a.NumarPolita == numarPolita);
        public Asigurare GasesteAsigurare(string numarPolita) => asigurari.Find(a => a.NumarPolita == numarPolita);

        public void AdaugaClient(Client client)
        {
            if (!clienti.Any(c => c.Cnp == client.Cnp))
                clienti.Add(client);
        }

        public List<Client> GetClienti() => new List<Client>(clienti);
        public Client GasesteClient(string cnp) => clienti.FirstOrDefault(c => c.Cnp == cnp);

        public IEnumerator<Asigurare> GetEnumerator() => asigurari.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public object Clone()
        {
            PortofoliuAsigurari clone = new PortofoliuAsigurari();
            foreach (var a in asigurari)
                clone.AdaugaAsigurare((Asigurare)a.Clone());
            return clone;
        }

        public double ValoareTotalaAsigurari() => asigurari.Sum(a => a.SumaAsigurata);

        public List<Asigurare> FiltreazaDupaClient(string numeClient) =>
            asigurari.FindAll(a => a.Client.Nume.ToLower().Contains(numeClient.ToLower()));

        public List<Asigurare> ToateAsigurarile() => new List<Asigurare>(asigurari);


        public void SalveazaInFisier(string numeFisier)
        {
            using (StreamWriter sw = new StreamWriter(numeFisier))
            {
                
                foreach (var client in clienti)
                {
                    sw.WriteLine($"CLIENT|{client.Nume ?? ""}|{client.Cnp ?? ""}|{client.Adresa ?? ""}|{client.Telefon ?? ""}");
                }

              
                foreach (var asig in asigurari)
                {
                    string tip = asig.GetType().Name;
                    string line = $"ASIGURARE|{asig.NumarPolita}|{asig.Client?.Cnp ?? ""}|" +
                                  $"{asig.DataInceput:yyyy-MM-dd}|{asig.DataSfarsit:yyyy-MM-dd}|" +
                                  $"{asig.SumaAsigurata}|{tip}";

                    if (asig is AsigurareViata av)
                    {
                        line += $"|{av.Beneficiar ?? ""}|{string.Join(";", av.RiscuriAcoperite ?? Array.Empty<string>())}";
                    }
                    else if (asig is AsigurareBunuri ab)
                    {
                        line += $"|{ab.TipBun ?? ""}|{string.Join(";", ab.Daune ?? Array.Empty<double>())}";
                    }

                    sw.WriteLine(line);
                }
            }
        }

        public void IncarcaDinFisier(string numeFisier)
        {
            clienti.Clear();
            asigurari.Clear();

            if (!File.Exists(numeFisier)) return;

            string[] lines = File.ReadAllLines(numeFisier);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts[0] == "CLIENT")
                {
                    clienti.Add(new Client(parts[1], parts[2], parts[3], parts[4]));
                }
                else if (parts[0] == "ASIGURARE")
                {
                    string cnp = parts[2];
                    Client client = clienti.FirstOrDefault(c => c.Cnp == cnp);

                    if (client == null) continue;
                    if (parts[6] == "AsigurareViata")
                    {
                        asigurari.Add(new AsigurareViata(
                            parts[1], client,
                            DateTime.Parse(parts[3]),
                            DateTime.Parse(parts[4]),
                            double.Parse(parts[5]),
                            parts[7],
                            parts[8].Split(';')
                        ));
                    }
                    else if (parts[6] == "AsigurareBunuri")
                    {
                        asigurari.Add(new AsigurareBunuri(
                            parts[1], client,
                            DateTime.Parse(parts[3]),
                            DateTime.Parse(parts[4]),
                            double.Parse(parts[5]),
                            parts[7],
                            parts[8].Split(';').Select(double.Parse).ToArray()
                        ));
                    }
                }
            }
        }
    }
        
   }
