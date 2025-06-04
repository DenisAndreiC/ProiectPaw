




namespace ProiectPaw
{
    partial class AdaugaAsigurareForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbClienti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipAsigurare = new System.Windows.Forms.ComboBox();
            this.dtpDataInceput = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataSfarsit = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSumaAsigurata = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblBeneficiar = new System.Windows.Forms.Label();
            this.txtBeneficiar = new System.Windows.Forms.TextBox();
            this.lblRiscuri = new System.Windows.Forms.Label();
            this.txtRiscuri = new System.Windows.Forms.TextBox();
            this.lblTipBun = new System.Windows.Forms.Label();
            this.cmbTipBun = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            
            this.cmbClienti.FormattingEnabled = true;
            this.cmbClienti.Location = new System.Drawing.Point(120, 20);
            this.cmbClienti.Name = "cmbClienti";
            this.cmbClienti.Size = new System.Drawing.Size(200, 21);
            this.cmbClienti.TabIndex = 0;
             
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client:";
            
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip asigurare:";
           
            this.cmbTipAsigurare.FormattingEnabled = true;
            this.cmbTipAsigurare.Location = new System.Drawing.Point(120, 57);
            this.cmbTipAsigurare.Name = "cmbTipAsigurare";
            this.cmbTipAsigurare.Size = new System.Drawing.Size(200, 21);
            this.cmbTipAsigurare.TabIndex = 3;
            this.cmbTipAsigurare.SelectedIndexChanged += new System.EventHandler(this.cmbTipAsigurare_SelectedIndexChanged);
            
            this.dtpDataInceput.Location = new System.Drawing.Point(120, 95);
            this.dtpDataInceput.Name = "dtpDataInceput";
            this.dtpDataInceput.Size = new System.Drawing.Size(200, 20);
            this.dtpDataInceput.TabIndex = 4;
             
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data început:";
            
            this.dtpDataSfarsit.Location = new System.Drawing.Point(120, 135);
            this.dtpDataSfarsit.Name = "dtpDataSfarsit";
            this.dtpDataSfarsit.Size = new System.Drawing.Size(200, 20);
            this.dtpDataSfarsit.TabIndex = 6;
            
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data sfârșit:";
            
            this.txtSumaAsigurata.Location = new System.Drawing.Point(120, 175);
            this.txtSumaAsigurata.Name = "txtSumaAsigurata";
            this.txtSumaAsigurata.Size = new System.Drawing.Size(200, 20);
            this.txtSumaAsigurata.TabIndex = 8;
            
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Suma asigurată:";
          
            this.btnOK.Location = new System.Drawing.Point(70, 350);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 30);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
             
            this.btnCancel.Location = new System.Drawing.Point(180, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Anulează";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
             
            this.lblBeneficiar.AutoSize = true;
            this.lblBeneficiar.Location = new System.Drawing.Point(20, 220);
            this.lblBeneficiar.Name = "lblBeneficiar";
            this.lblBeneficiar.Size = new System.Drawing.Size(65, 15);
            this.lblBeneficiar.TabIndex = 12;
            this.lblBeneficiar.Text = "Beneficiar:";
             
            this.txtBeneficiar.Location = new System.Drawing.Point(120, 217);
            this.txtBeneficiar.Name = "txtBeneficiar";
            this.txtBeneficiar.Size = new System.Drawing.Size(200, 20);
            this.txtBeneficiar.TabIndex = 13;
            
            this.lblRiscuri.AutoSize = true;
            this.lblRiscuri.Location = new System.Drawing.Point(20, 259);
            this.lblRiscuri.Name = "lblRiscuri";
            this.lblRiscuri.Size = new System.Drawing.Size(166, 15);
            this.lblRiscuri.TabIndex = 14;
            this.lblRiscuri.Text = "Riscuri (imobil/auto/inventar):";
            this.lblRiscuri.Click += new System.EventHandler(this.lblRiscuri_Click);
           
            this.txtRiscuri.Location = new System.Drawing.Point(120, 277);
            this.txtRiscuri.Name = "txtRiscuri";
            this.txtRiscuri.Size = new System.Drawing.Size(200, 20);
            this.txtRiscuri.TabIndex = 15;
           
            this.lblTipBun.AutoSize = true;
            this.lblTipBun.Location = new System.Drawing.Point(20, 220);
            this.lblTipBun.Name = "lblTipBun";
            this.lblTipBun.Size = new System.Drawing.Size(51, 15);
            this.lblTipBun.TabIndex = 16;
            this.lblTipBun.Text = "Tip bun:";
            this.lblTipBun.Visible = false;
           
            this.cmbTipBun.FormattingEnabled = true;
            this.cmbTipBun.Location = new System.Drawing.Point(120, 217);
            this.cmbTipBun.Name = "cmbTipBun";
            this.cmbTipBun.Size = new System.Drawing.Size(200, 21);
            this.cmbTipBun.TabIndex = 17;
            this.cmbTipBun.Visible = false;
             
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.cmbTipBun);
            this.Controls.Add(this.lblTipBun);
            this.Controls.Add(this.txtRiscuri);
            this.Controls.Add(this.lblRiscuri);
            this.Controls.Add(this.txtBeneficiar);
            this.Controls.Add(this.lblBeneficiar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSumaAsigurata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDataSfarsit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataInceput);
            this.Controls.Add(this.cmbTipAsigurare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClienti);
            this.Name = "AdaugaAsigurareForm";
            this.Text = "Adaugă Asigurare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmbClienti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipAsigurare;
        private System.Windows.Forms.DateTimePicker dtpDataInceput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataSfarsit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSumaAsigurata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBeneficiar;
        private System.Windows.Forms.TextBox txtBeneficiar;
        private System.Windows.Forms.Label lblRiscuri;
        private System.Windows.Forms.TextBox txtRiscuri;
        private System.Windows.Forms.Label lblTipBun;
        private System.Windows.Forms.ComboBox cmbTipBun;
    }
}