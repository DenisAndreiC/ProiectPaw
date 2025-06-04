namespace ProiectPaw
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAdaugaClient;
        private System.Windows.Forms.Button btnAdaugaAsigurare;
        private System.Windows.Forms.Button btnSterge;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdaugaClient = new System.Windows.Forms.Button();
            this.btnAdaugaAsigurare = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            

            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 58);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(705, 428);
            this.dataGridView.TabIndex = 0;
            

            this.btnAdaugaClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdaugaClient.Location = new System.Drawing.Point(725, 58);
            this.btnAdaugaClient.Name = "btnAdaugaClient";
            this.btnAdaugaClient.Size = new System.Drawing.Size(150, 40);
            this.btnAdaugaClient.TabIndex = 1;
            this.btnAdaugaClient.Text = "Adauga Client";
            this.btnAdaugaClient.UseVisualStyleBackColor = true;
            this.btnAdaugaClient.Click += new System.EventHandler(this.btnAdaugaClient_Click);
            

            this.btnAdaugaAsigurare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdaugaAsigurare.Location = new System.Drawing.Point(725, 116);
            this.btnAdaugaAsigurare.Name = "btnAdaugaAsigurare";
            this.btnAdaugaAsigurare.Size = new System.Drawing.Size(150, 40);
            this.btnAdaugaAsigurare.TabIndex = 2;
            this.btnAdaugaAsigurare.Text = "Adauga Asigurare";
            this.btnAdaugaAsigurare.UseVisualStyleBackColor = true;
            this.btnAdaugaAsigurare.Click += new System.EventHandler(this.btnAdaugaAsigurare_Click);
            

            this.btnSterge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSterge.Location = new System.Drawing.Point(725, 182);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(150, 40);
            this.btnSterge.TabIndex = 3;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(905, 524);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnAdaugaAsigurare);
            this.Controls.Add(this.btnAdaugaClient);
            this.Controls.Add(this.dataGridView);
            this.Name = "MainForm";
            this.Text = "Gestionare Asigurari";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }
    }
}