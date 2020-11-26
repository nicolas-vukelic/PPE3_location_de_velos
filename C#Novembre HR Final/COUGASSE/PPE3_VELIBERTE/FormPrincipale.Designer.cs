using System.Windows.Forms;

namespace PPE3_VELIBERTE
{
    partial class FormPrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rendreLeVéloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionDesDonneesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seConnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réparateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprunteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.générerUnPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reparationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Connected = new System.Windows.Forms.CheckBox();
            this.ConnectY = new System.Windows.Forms.Label();
            this.Emprunter = new System.Windows.Forms.Button();
            this.Mesemprunts = new System.Windows.Forms.DataGridView();
            this.Labemprunts = new System.Windows.Forms.Label();
            this.Invisible = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mesemprunts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Invisible)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ContextMenuStrip = this.contextMenuStrip1;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestionDesDonneesToolStripMenuItem,
            this.seConnecterToolStripMenuItem,
            this.générerUnPDFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rendreLeVéloToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 28);
            // 
            // rendreLeVéloToolStripMenuItem
            // 
            this.rendreLeVéloToolStripMenuItem.Name = "rendreLeVéloToolStripMenuItem";
            this.rendreLeVéloToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.rendreLeVéloToolStripMenuItem.Text = "Rendre le vélo";
            this.rendreLeVéloToolStripMenuItem.Click += new System.EventHandler(this.rendreLeVéloToolStripMenuItem_Click);
            // 
            // GestionDesDonneesToolStripMenuItem
            // 
            this.GestionDesDonneesToolStripMenuItem.Name = "GestionDesDonneesToolStripMenuItem";
            this.GestionDesDonneesToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.GestionDesDonneesToolStripMenuItem.Text = "Gestion des données";
            this.GestionDesDonneesToolStripMenuItem.Click += new System.EventHandler(this.GestionDesDonneesToolStripMenuItem_Click);
            // 
            // seConnecterToolStripMenuItem
            // 
            this.seConnecterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réparateurToolStripMenuItem,
            this.emprunteurToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.seConnecterToolStripMenuItem.Name = "seConnecterToolStripMenuItem";
            this.seConnecterToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.seConnecterToolStripMenuItem.Text = "Se connecter";
            this.seConnecterToolStripMenuItem.Click += new System.EventHandler(this.SeConnecterToolStripMenuItem_Click);
            // 
            // réparateurToolStripMenuItem
            // 
            this.réparateurToolStripMenuItem.Name = "réparateurToolStripMenuItem";
            this.réparateurToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.réparateurToolStripMenuItem.Text = "Réparateur";
            this.réparateurToolStripMenuItem.Click += new System.EventHandler(this.RéparateurToolStripMenuItem_Click);
            // 
            // emprunteurToolStripMenuItem
            // 
            this.emprunteurToolStripMenuItem.Name = "emprunteurToolStripMenuItem";
            this.emprunteurToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.emprunteurToolStripMenuItem.Text = "Emprunteur";
            this.emprunteurToolStripMenuItem.Click += new System.EventHandler(this.EmprunteurToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.AdminToolStripMenuItem_Click);
            // 
            // générerUnPDFToolStripMenuItem
            // 
            this.générerUnPDFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reparationToolStripMenuItem,
            this.empruntsToolStripMenuItem});
            this.générerUnPDFToolStripMenuItem.Name = "générerUnPDFToolStripMenuItem";
            this.générerUnPDFToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.générerUnPDFToolStripMenuItem.Text = "Générer un PDF";
            // 
            // reparationToolStripMenuItem
            // 
            this.reparationToolStripMenuItem.Name = "reparationToolStripMenuItem";
            this.reparationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reparationToolStripMenuItem.Text = "Reparation";
            this.reparationToolStripMenuItem.Click += new System.EventHandler(this.ReparationToolStripMenuItem_Click);
            // 
            // empruntsToolStripMenuItem
            // 
            this.empruntsToolStripMenuItem.Name = "empruntsToolStripMenuItem";
            this.empruntsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.empruntsToolStripMenuItem.Text = "Emprunts";
            this.empruntsToolStripMenuItem.Click += new System.EventHandler(this.EmpruntsToolStripMenuItem_Click);
            // 
            // Connected
            // 
            this.Connected.AutoSize = true;
            this.Connected.BackColor = System.Drawing.Color.OliveDrab;
            this.Connected.Enabled = false;
            this.Connected.Location = new System.Drawing.Point(495, 0);
            this.Connected.Name = "Connected";
            this.Connected.Size = new System.Drawing.Size(127, 29);
            this.Connected.TabIndex = 1;
            this.Connected.Text = "Connecté";
            this.Connected.UseVisualStyleBackColor = false;
            // 
            // ConnectY
            // 
            this.ConnectY.AutoSize = true;
            this.ConnectY.Location = new System.Drawing.Point(17, 416);
            this.ConnectY.Name = "ConnectY";
            this.ConnectY.Size = new System.Drawing.Size(242, 25);
            this.ConnectY.TabIndex = 2;
            this.ConnectY.Text = "Veuillez vous connecter";
            // 
            // Emprunter
            // 
            this.Emprunter.Location = new System.Drawing.Point(21, 368);
            this.Emprunter.Name = "Emprunter";
            this.Emprunter.Size = new System.Drawing.Size(238, 29);
            this.Emprunter.TabIndex = 3;
            this.Emprunter.Text = "Emprunter un vélo";
            this.Emprunter.UseVisualStyleBackColor = true;
            this.Emprunter.Click += new System.EventHandler(this.Emprunter_Click);
            // 
            // Mesemprunts
            // 
            this.Mesemprunts.AllowUserToAddRows = false;
            this.Mesemprunts.AllowUserToDeleteRows = false;
            this.Mesemprunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mesemprunts.ContextMenuStrip = this.contextMenuStrip1;
            this.Mesemprunts.Location = new System.Drawing.Point(12, 64);
            this.Mesemprunts.Name = "Mesemprunts";
            this.Mesemprunts.ReadOnly = true;
            this.Mesemprunts.RowHeadersWidth = 51;
            this.Mesemprunts.Size = new System.Drawing.Size(559, 262);
            this.Mesemprunts.TabIndex = 4;
            this.Mesemprunts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Labemprunts
            // 
            this.Labemprunts.AutoSize = true;
            this.Labemprunts.Location = new System.Drawing.Point(28, 329);
            this.Labemprunts.Name = "Labemprunts";
            this.Labemprunts.Size = new System.Drawing.Size(145, 25);
            this.Labemprunts.TabIndex = 5;
            this.Labemprunts.Text = "Vos emprunts";
            // 
            // Invisible
            // 
            this.Invisible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Invisible.Location = new System.Drawing.Point(283, 329);
            this.Invisible.Name = "Invisible";
            this.Invisible.RowHeadersWidth = 51;
            this.Invisible.RowTemplate.Height = 24;
            this.Invisible.Size = new System.Drawing.Size(240, 150);
            this.Invisible.TabIndex = 6;
            this.Invisible.Visible = false;
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 469);
            this.Controls.Add(this.Invisible);
            this.Controls.Add(this.Labemprunts);
            this.Controls.Add(this.Mesemprunts);
            this.Controls.Add(this.Emprunter);
            this.Controls.Add(this.ConnectY);
            this.Controls.Add(this.Connected);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Application VELIBERTE : gestion des données et Réparations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipale_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Mesemprunts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Invisible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GestionDesDonneesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seConnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réparateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprunteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private CheckBox Connected;
        private Label ConnectY;
        private Button Emprunter;
        private ToolStripMenuItem générerUnPDFToolStripMenuItem;
        private ToolStripMenuItem reparationToolStripMenuItem;
        private ToolStripMenuItem empruntsToolStripMenuItem;
        private DataGridView Mesemprunts;
        private Label Labemprunts;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem rendreLeVéloToolStripMenuItem;
        private DataGridView Invisible;

        public ToolStripMenuItem SeConnecterToolStripMenuItem { get => seConnecterToolStripMenuItem; set => seConnecterToolStripMenuItem = value; }
        public ToolStripMenuItem RéparateurToolStripMenuItem { get => réparateurToolStripMenuItem; set => réparateurToolStripMenuItem = value; }
        public ToolStripMenuItem EmprunteurToolStripMenuItem { get => emprunteurToolStripMenuItem; set => emprunteurToolStripMenuItem = value; }
        public ToolStripMenuItem AdminToolStripMenuItem { get => adminToolStripMenuItem; set => adminToolStripMenuItem = value; }
        public CheckBox Connected1 { get => Connected; set => Connected = value; }
        public Label ConnectY1 { get => ConnectY; set => ConnectY = value; }
        public ToolStripMenuItem GestionDesDonneesToolStripMenuItem1 { get => GestionDesDonneesToolStripMenuItem; set => GestionDesDonneesToolStripMenuItem = value; }
        public Button Emprunter1 { get => Emprunter; set => Emprunter = value; }
        public DataGridView Mesemprunts1 { get => Mesemprunts; set => Mesemprunts = value; }
        public Label Labemprunts1 { get => Labemprunts; set => Labemprunts = value; }
        public ToolStripMenuItem GénérerUnPDFToolStripMenuItem { get => générerUnPDFToolStripMenuItem; set => générerUnPDFToolStripMenuItem = value; }
        public ToolStripMenuItem ReparationToolStripMenuItem { get => reparationToolStripMenuItem; set => reparationToolStripMenuItem = value; }
        public ToolStripMenuItem EmpruntsToolStripMenuItem { get => empruntsToolStripMenuItem; set => empruntsToolStripMenuItem = value; }
       
        public ToolStripMenuItem GénérerUnPDFToolStripMenuItem1 { get => générerUnPDFToolStripMenuItem; set => générerUnPDFToolStripMenuItem = value; }
    }
}

