using System;

namespace ProiectPaw
{
    public class Client : ICloneable, IComparable<Client>
    {
        private string nume;
        private string cnp;
        private string adresa;
        private string telefon;

        public Client(string nume, string cnp, string adresa, string telefon)
        {
            this.nume = nume;
            this.cnp = cnp;
            this.adresa = adresa;
            this.telefon = telefon;
        }

        public string Nume { get => nume; set => nume = value; }
        public string Cnp { get => cnp; set => cnp = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public object Clone() => MemberwiseClone();

        public int CompareTo(Client other) => nume.CompareTo(other.nume);

        public static string operator +(Client a, Client b) => $"{a.nume} & {b.nume}";
        public static bool operator >(Client a, Client b) => a.nume.Length > b.nume.Length;
        public static bool operator <(Client a, Client b) => a.nume.Length < b.nume.Length;

        public override string ToString() => $"{nume} ({cnp})";
    }
}