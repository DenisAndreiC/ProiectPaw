using System;
using System.Collections;

namespace ProiectPaw
{
    public abstract class Asigurare : ICloneable, IComparable<Asigurare>
    {
        private string numarPolita;
        private Client client;
        private DateTime dataInceput;
        private DateTime dataSfarsit;
        private double sumaAsigurata;

        protected Asigurare(string numarPolita, Client client, DateTime dataInceput,
                           DateTime dataSfarsit, double sumaAsigurata)
        {
            this.numarPolita = numarPolita;
            this.client = client;
            this.dataInceput = dataInceput;
            this.dataSfarsit = dataSfarsit;
            this.sumaAsigurata = sumaAsigurata;
        }
        public string NumeClient => Client?.Nume;
        public string NumarPolita { get => numarPolita; set => numarPolita = value; }
        public Client Client { get => client; set => client = value; }
        public DateTime DataInceput { get => dataInceput; set => dataInceput = value; }
        public DateTime DataSfarsit { get => dataSfarsit; set => dataSfarsit = value; }
        public double SumaAsigurata { get => sumaAsigurata; set => sumaAsigurata = value; }

        public abstract double CalculPrima();
        public abstract string Tip { get; }

        public object Clone()
        {
            Asigurare clone = (Asigurare)MemberwiseClone();
            clone.client = (Client)this.client.Clone();
            return clone;
        }

        public int CompareTo(Asigurare other) => sumaAsigurata.CompareTo(other.sumaAsigurata);

        public static double operator +(Asigurare a, Asigurare b) => a.sumaAsigurata + b.sumaAsigurata;
        public static bool operator >(Asigurare a, Asigurare b) => a.sumaAsigurata > b.sumaAsigurata;
        public static bool operator <(Asigurare a, Asigurare b) => a.sumaAsigurata < b.sumaAsigurata;

        public override string ToString() => $"Polita {numarPolita} - {client.Nume}";
    }
}