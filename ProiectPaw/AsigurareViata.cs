using System;

namespace ProiectPaw
{
    public class AsigurareViata : Asigurare
    {
        private string beneficiar;
        private string[] riscuriAcoperite;

        public AsigurareViata(string numarPolita, Client client, DateTime dataInceput,
                            DateTime dataSfarsit, double sumaAsigurata,
                            string beneficiar, string[] riscuriAcoperite)
            : base(numarPolita, client, dataInceput, dataSfarsit, sumaAsigurata)
        {
            this.beneficiar = beneficiar;
            this.riscuriAcoperite = riscuriAcoperite ?? new string[0];
        }

        public string[] RiscuriAcoperite { get; private set; }

        public override string Tip => "Viata";
        public string Beneficiar { get => beneficiar; set => beneficiar = value; }

        public string this[int index]
        {
            get => riscuriAcoperite[index];
            set => riscuriAcoperite[index] = value;
        }

        public int NumarRiscuri => riscuriAcoperite.Length;

        public override double CalculPrima()
        {
            int anNastere;
            if (Client.Cnp.StartsWith("1") || Client.Cnp.StartsWith("2"))
                anNastere = 1900 + int.Parse(Client.Cnp.Substring(1, 2));
            else
                anNastere = 2000 + int.Parse(Client.Cnp.Substring(1, 2));

            int varsta = DateTime.Now.Year - anNastere;
            double factorVarsta = varsta * 0.01;
            return SumaAsigurata * 0.03 * (1 + factorVarsta);
        }

        public string[] FiltreazaRiscuri(string cuvantCheie)
        {
            System.Collections.Generic.List<string> rezultate = new System.Collections.Generic.List<string>();
            foreach (string r in riscuriAcoperite)
                if (r.ToLower().Contains(cuvantCheie.ToLower()))
                    rezultate.Add(r);
            return rezultate.ToArray();
        }

        public override string ToString()
        {
            return base.ToString() + $" [Viata] Beneficiar: {beneficiar}";
        }
    }
}