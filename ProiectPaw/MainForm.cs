using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProiectPaw
{
    public partial class MainForm : Form
    {
        private PortofoliuAsigurari portofoliu = new PortofoliuAsigurari();
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        public MainForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeMenu();
        }

        private void InitializeMenu()
        {
            MenuStrip menu = new MenuStrip();
            menu.Dock = DockStyle.Top;
            this.Controls.Add(menu);

            ToolStripMenuItem fileMenu = new ToolStripMenuItem("Fisier");
            ToolStripMenuItem saveItem = new ToolStripMenuItem("Salveaza", null, SaveMenu_Click);
            ToolStripMenuItem loadItem = new ToolStripMenuItem("Incarca", null, LoadMenu_Click);
            ToolStripMenuItem printItem = new ToolStripMenuItem("Tipareste", null, PrintMenu_Click);
            ToolStripMenuItem exitItem = new ToolStripMenuItem("Iesire", null, ExitMenu_Click);

            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { saveItem, loadItem, printItem, new ToolStripSeparator(), exitItem });

            ToolStripMenuItem viewMenu = new ToolStripMenuItem("Vizualizare");
            ToolStripMenuItem chartItem = new ToolStripMenuItem("Grafic", null, ChartMenu_Click);
            viewMenu.DropDownItems.Add(chartItem);

            menu.Items.Add(fileMenu);
            menu.Items.Add(viewMenu);

            this.MainMenuStrip = menu;
        }

        private void PrintMenu_Click(object sender, EventArgs e)
        {
            PrintForm printForm = new PrintForm(portofoliu);
            printForm.ShowDialog();  
        }

        private void ChartMenu_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm(portofoliu); 
            chartForm.ShowDialog();
        }

        private void InitializeDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumarPolita",
                HeaderText = "Numar Polita"
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeClient",
                HeaderText = "Client"
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SumaAsigurata",
                HeaderText = "Suma Asigurata",
                DefaultCellStyle = { Format = "C2" }
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Tip",
                HeaderText = "Tip Asigurare"
            });
        }

        private void btnAdaugaClient_Click(object sender, EventArgs e)
        {
            AdaugaClientForm form = new AdaugaClientForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                portofoliu.AdaugaClient(form.Client);
                MessageBox.Show("Client adaugat cu succes!");
            }
        }

        private void btnAdaugaAsigurare_Click(object sender, EventArgs e)
        {
            using (AdaugaAsigurareForm form = new AdaugaAsigurareForm(portofoliu.GetClienti()))
            {
                if (form.ShowDialog() == DialogResult.OK && form.AsigurareCreeata != null)
                {
                    portofoliu.AdaugaAsigurare(form.AsigurareCreeata);
                    ActualizeazaLista();
                }
            }
        }

        private void ActualizeazaLista()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = portofoliu.ToateAsigurarile();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var asigurare = dataGridView.SelectedRows[0].DataBoundItem as Asigurare;
                if (asigurare != null)
                {
                    portofoliu.StergeAsigurare(asigurare.NumarPolita);
                    ActualizeazaLista();
                }
            }
        }

      
        private void SaveMenu_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Fisiere text (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                portofoliu.SalveazaInFisier(saveFileDialog.FileName);
                MessageBox.Show("Date salvate cu succes!");
            }
        }

        private void LoadMenu_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Fisiere text (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                portofoliu.IncarcaDinFisier(openFileDialog.FileName);
                ActualizeazaLista();
                MessageBox.Show("Date încărcate cu succes!");
            }
        }

      
     

        private void ExitMenu_Click(object sender, EventArgs e) => Application.Exit();

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}