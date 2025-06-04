using System.Windows.Forms;
using System;

namespace ProiectPaw
{
    public partial class AdaugaClientForm : Form
    {
        public Client Client { get; private set; }

        public AdaugaClientForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text))
            {
                MessageBox.Show("Introduceti numele clientului!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCNP.Text) || txtCNP.Text.Length != 13)
            {
                MessageBox.Show("CNP invalid! Trebuie sa aiba 13 cifre.");
                return;
            }

            Client = new Client(txtNume.Text, txtCNP.Text, txtAdresa.Text, txtTelefon.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}