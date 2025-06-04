using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ProiectPaw
{
    public partial class PrintForm : Form
    {
        public PrintForm(PortofoliuAsigurari portofoliu)
        {
            InitializeComponent();
            InitializePrinting(portofoliu);
        }

        private void InitializePrinting(PortofoliuAsigurari portofoliu)
        {
            PrintDocument printDocument = new PrintDocument();
            List<string> linesToPrint = new List<string>();
            int currentLineIndex = 0;

            // Prepare print data
            linesToPrint.Add("PORTOFOLIU ASIGURĂRI");
            linesToPrint.Add($"Data raport: {DateTime.Now:dd.MM.yyyy}");
            linesToPrint.Add($"Total asigurări: {portofoliu.ToateAsigurarile().Count}");
            linesToPrint.Add($"Valoare totală: {portofoliu.ValoareTotalaAsigurari():C2}");
            linesToPrint.Add("");
            linesToPrint.Add("DETALII ASIGURARI:");

            foreach (var asig in portofoliu.ToateAsigurarile())
            {
                linesToPrint.Add($"- {asig.NumarPolita}: {asig.Client.Nume} ({asig.Tip}) - {asig.SumaAsigurata:C2}");
            }

           
            printDocument.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;
                Font font = new Font("Arial", 12);
                float yPos = 50;
                float lineHeight = font.GetHeight();

                while (currentLineIndex < linesToPrint.Count)
                {
                    g.DrawString(linesToPrint[currentLineIndex], font, Brushes.Black, 50, yPos);
                    yPos += lineHeight + 5;
                    currentLineIndex++;

                    if (yPos > e.MarginBounds.Height)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }

                currentLineIndex = 0;
                e.HasMorePages = false;
            };

           
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.ShowDialog();
        }
    }
}