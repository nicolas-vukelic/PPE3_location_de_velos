using System.Windows.Forms;

namespace PPE3_VELIBERTE
{
    partial class FormCRUDReparations
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReparationButton = new System.Windows.Forms.Button();
            this.ComboTravaux = new System.Windows.Forms.ComboBox();
            this.ComboVelo = new System.Windows.Forms.ComboBox();
            this.DateRep = new System.Windows.Forms.DateTimePicker();
            this.tempsR = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des réparations";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro du vélo";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Travaux à effectuer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de mise en réparation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Temps de réparation";
            // 
            // ReparationButton
            // 
            this.ReparationButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ReparationButton.Location = new System.Drawing.Point(231, 372);
            this.ReparationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReparationButton.Name = "ReparationButton";
            this.ReparationButton.Size = new System.Drawing.Size(121, 59);
            this.ReparationButton.TabIndex = 9;
            this.ReparationButton.Text = "Valider";
            this.ReparationButton.UseVisualStyleBackColor = true;
            this.ReparationButton.Click += new System.EventHandler(this.ReparationButton_Click);
            // 
            // ComboTravaux
            // 
            this.ComboTravaux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTravaux.FormattingEnabled = true;
            this.ComboTravaux.Location = new System.Drawing.Point(231, 137);
            this.ComboTravaux.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboTravaux.Name = "ComboTravaux";
            this.ComboTravaux.Size = new System.Drawing.Size(220, 24);
            this.ComboTravaux.TabIndex = 10;
            // 
            // ComboVelo
            // 
            this.ComboVelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboVelo.FormattingEnabled = true;
            this.ComboVelo.Location = new System.Drawing.Point(231, 91);
            this.ComboVelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboVelo.Name = "ComboVelo";
            this.ComboVelo.Size = new System.Drawing.Size(220, 24);
            this.ComboVelo.TabIndex = 11;
            this.ComboVelo.SelectedIndexChanged += new System.EventHandler(this.ComboVelo_SelectedIndexChanged);
            // 
            // DateRep
            // 
            this.DateRep.Location = new System.Drawing.Point(231, 193);
            this.DateRep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateRep.Name = "DateRep";
            this.DateRep.Size = new System.Drawing.Size(265, 22);
            this.DateRep.TabIndex = 12;
            // 
            // tempsR
            // 
            this.tempsR.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tempsR.Location = new System.Drawing.Point(231, 236);
            this.tempsR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tempsR.Name = "tempsR";
            this.tempsR.ShowUpDown = true;
            this.tempsR.Size = new System.Drawing.Size(265, 22);
            this.tempsR.TabIndex = 13;
            this.tempsR.TabStop = false;
            // 
            // FormCRUDReparations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(556, 554);
            this.Controls.Add(this.tempsR);
            this.Controls.Add(this.DateRep);
            this.Controls.Add(this.ComboVelo);
            this.Controls.Add(this.ComboTravaux);
            this.Controls.Add(this.ReparationButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCRUDReparations";
            this.Text = "Réparer";
            this.Load += new System.EventHandler(this.FormCRUDReparations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ReparationButton;
        private ComboBox ComboTravaux;
        private ComboBox ComboVelo;
        private DateTimePicker DateRep;
        private DateTimePicker tempsR;

        public ComboBox ComboTravaux1 { get => ComboTravaux; set => ComboTravaux = value; }
        public ComboBox ComboVelo1 { get => ComboVelo; set => ComboVelo = value; }
        public DateTimePicker DateRep1 { get => DateRep; set => DateRep = value; }
  
        public DateTimePicker TempsRepBox1 { get => tempsR; set => tempsR = value; }
    }
}