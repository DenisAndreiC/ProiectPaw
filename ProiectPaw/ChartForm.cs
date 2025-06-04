using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProiectPaw
{
    public partial class ChartForm : Form
    {
        private PortofoliuAsigurari portofoliu;

        public ChartForm(PortofoliuAsigurari portofoliu)
        {
            InitializeComponent();
            this.portofoliu = portofoliu;
            InitializeChart();
        }

        private void InitializeChart()
        {
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;
            this.Controls.Add(chart);

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series("Tipuri");
            chart.Series.Add(series);

            var tipuri = portofoliu.ToateAsigurarile()
                .GroupBy(a => a.Tip)
                .Select(g => new { Tip = g.Key, Count = g.Count() })
                .ToList();

            foreach (var tip in tipuri)
            {
                series.Points.AddXY(tip.Tip, tip.Count);
            }

            series.ChartType = SeriesChartType.Pie;
            chartArea.Area3DStyle.Enable3D = true;

            chart.Titles.Add("Distributie Tipuri Asigurari");
        }
    }
}