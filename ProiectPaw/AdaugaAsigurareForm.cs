using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProiectPaw
{
    public partial class AdaugaAsigurareForm : Form
    {
        public Asigurare AsigurareCreeata { get; private set; }
        private List<Client> clientiDisponibili;

        
        public AdaugaAsigurareForm()
        {
            InitializeComponent();
        }

        
        public AdaugaAsigurareForm(List<Client> clienti) : this()
        {
            clientiDisponibili = clienti;
            InitializeForm();
        }

        private void InitializeForm()
        {
            cmbTipAsigurare.Items.AddRange(new string[] { "Viata", "Bunuri" });
            cmbTipAsigurare.SelectedIndex = 0;

            cmbClienti.DisplayMember = "Nume";
            cmbClienti.DataSource = clientiDisponibili;

            
            cmbTipBun.Items.AddRange(new string[] { "Imobil", "Auto", "Inventar", "Altele" });
            cmbTipBun.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ValideazaDate())
                return;

            Client clientSelectat = (Client)cmbClienti.SelectedItem;
            DateTime dataInceput = dtpDataInceput.Value;
            DateTime dataSfarsit = dtpDataSfarsit.Value;
            double suma = double.Parse(txtSumaAsigurata.Text);

            if (cmbTipAsigurare.SelectedItem.ToString() == "Viata")
            {
                AsigurareCreeata = new AsigurareViata(
                    Guid.NewGuid().ToString("N").Substring(0, 10),
                    clientSelectat,
                    dataInceput,
                    dataSfarsit,
                    suma,
                    txtBeneficiar.Text,
                    txtRiscuri.Text.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                );
            }
            else
            {
                AsigurareCreeata = new AsigurareBunuri(
                    Guid.NewGuid().ToString("N").Substring(0, 10),
                    clientSelectat,
                    dataInceput,
                    dataSfarsit,
                    suma,
                    cmbTipBun.SelectedItem.ToString(),
                    new double[0]
                );
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValideazaDate()
        {
            if (cmbClienti.SelectedItem == null)
            {
                MessageBox.Show("Selectati un client!");
                return false;
            }

            if (!double.TryParse(txtSumaAsigurata.Text, out double suma) || suma <= 0)
            {
                MessageBox.Show("Suma asigurata invalida!");
                return false;
            }

            if (dtpDataSfarsit.Value <= dtpDataInceput.Value)
            {
                MessageBox.Show("Data sfarsit trebuie să fie dupa data inceput!");
                return false;
            }

            if (cmbTipAsigurare.SelectedItem.ToString() == "Viata" && string.IsNullOrWhiteSpace(txtBeneficiar.Text))
            {
                MessageBox.Show("Introduceti beneficiarul pentru asigurarea de viata!");
                return false;
            }

            return true;
        }

        private void cmbTipAsigurare_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isViata = cmbTipAsigurare.SelectedItem.ToString() == "Viata";

            lblBeneficiar.Visible = isViata;
            txtBeneficiar.Visible = isViata;
            lblRiscuri.Visible = isViata;
            txtRiscuri.Visible = isViata;

            lblTipBun.Visible = !isViata;
            cmbTipBun.Visible = !isViata;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void lblRiscuri_Click(object sender, EventArgs e)
        {

        }
    }
}