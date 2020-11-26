namespace PPE3_VELIBERTE
{
    partial class FormGestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.gbTable = new System.Windows.Forms.GroupBox();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.dgvDonnees = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.ConAdmin = new System.Windows.Forms.Label();
            this.gbTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonnees)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnFermer
            // 
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnFermer.Location = new System.Drawing.Point(348, 491);
            this.BtnFermer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(143, 41);
            this.BtnFermer.TabIndex = 0;
            this.BtnFermer.Text = "FERMER";
            this.BtnFermer.UseVisualStyleBackColor = true;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // gbTable
            // 
            this.gbTable.Controls.Add(this.cbTables);
            this.gbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbTable.Location = new System.Drawing.Point(277, 32);
            this.gbTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTable.Name = "gbTable";
            this.gbTable.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTable.Size = new System.Drawing.Size(281, 73);
            this.gbTable.TabIndex = 1;
            this.gbTable.TabStop = false;
            this.gbTable.Text = "Liste des tables";
            // 
            // cbTables
            // 
            this.cbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(45, 26);
            this.cbTables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(212, 33);
            this.cbTables.TabIndex = 0;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // dgvDonnees
            // 
            this.dgvDonnees.AllowUserToAddRows = false;
            this.dgvDonnees.AllowUserToDeleteRows = false;
            this.dgvDonnees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDonnees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonnees.Location = new System.Drawing.Point(40, 132);
            this.dgvDonnees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDonnees.Name = "dgvDonnees";
            this.dgvDonnees.ReadOnly = true;
            this.dgvDonnees.RowHeadersWidth = 51;
            this.dgvDonnees.Size = new System.Drawing.Size(780, 294);
            this.dgvDonnees.TabIndex = 2;
            this.dgvDonnees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonnees_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 76);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 455);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Click Droit pour Ajouter/Modifier/Supprimer";
            // 
            // ConAdmin
            // 
            this.ConAdmin.AutoSize = true;
            this.ConAdmin.Location = new System.Drawing.Point(195, 567);
            this.ConAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConAdmin.Name = "ConAdmin";
            this.ConAdmin.Size = new System.Drawing.Size(480, 17);
            this.ConAdmin.TabIndex = 5;
            this.ConAdmin.Text = "Vous dever être connecter en administrateur pour accéder aux réparations";
            // 
            // FormGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 622);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.ConAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDonnees);
            this.Controls.Add(this.gbTable);
            this.Controls.Add(this.BtnFermer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application VELIBERTE : Gestion des données";
            this.Load += new System.EventHandler(this.FormGestion_Load);
            this.gbTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonnees)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.GroupBox gbTable;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.DataGridView dgvDonnees;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ConAdmin;
    }
}