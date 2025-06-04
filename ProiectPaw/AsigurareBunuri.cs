using System;
using System.Linq;

namespace ProiectPaw
{
    public class AsigurareBunuri : Asigurare
    {
        private string tipBun;
        private double[] daune;

        public AsigurareBunuri(string numarPolita, Client client, DateTime dataInceput,
                             DateTime dataSfarsit, double sumaAsigurata,
                             string tipBun, double[] daune)
            : base(numarPolita, client, dataInceput, dataSfarsit, sumaAsigurata)
        {
            this.tipBun = tipBun;
            this.daune = daune ?? new double[0];
        }

        public double[] Daune { get; private set; } 

        public override string Tip => "Bunuri";
        public string TipBun { get => tipBun; set => tipBun = value; }

        public double this[int index]
        {
            get => daune[index];
            set => daune[index] = value;
        }

        public int NumarDaune => daune.Length;

        public override double CalculPrima()
        {
            double factorRisc;
            if (tipBun == "Imobil")
                factorRisc = 0.02;
            else if (tipBun == "Auto")
                factorRisc = 0.05;
            else if (tipBun == "Inventar")
                factorRisc = 0.03;
            else
                factorRisc = 0.04;

            return SumaAsigurata * factorRisc;
        }

        public double TotalDaune() => daune.Sum();

        public override string ToString() => base.ToString() + $" [Bunuri] Tip: {tipBun}";
    }
}