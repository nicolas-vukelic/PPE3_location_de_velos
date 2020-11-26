using System.Windows.Forms;

namespace PPE3_VELIBERTE
{
    partial class FormCRUDEmprunts
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
            this.SelectV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckElec = new System.Windows.Forms.CheckBox();
            this.CheckDate = new System.Windows.Forms.CheckBox();
            this.DATE = new System.Windows.Forms.DateTimePicker();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectV
            // 
            this.SelectV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectV.FormattingEnabled = true;
            this.SelectV.Location = new System.Drawing.Point(35, 69);
            this.SelectV.Name = "SelectV";
            this.SelectV.Size = new System.Drawing.Size(121, 21);
            this.SelectV.TabIndex = 0;
            this.SelectV.SelectedIndexChanged += new System.EventHandler(this.SelectV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sélectionner un véhicule";
            // 
            // SelectD
            // 
            this.SelectD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectD.FormattingEnabled = true;
            this.SelectD.Items.AddRange(new object[] {
            "180",
            "360"});
            this.SelectD.Location = new System.Drawing.Point(35, 169);
            this.SelectD.Name = "SelectD";
            this.SelectD.Size = new System.Drawing.Size(121, 21);
            this.SelectD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Durée de la location en jours";
            // 
            // CheckElec
            // 
            this.CheckElec.AutoSize = true;
            this.CheckElec.Location = new System.Drawing.Point(175, 71);
            this.CheckElec.Name = "CheckElec";
            this.CheckElec.Size = new System.Drawing.Size(78, 17);
            this.CheckElec.TabIndex = 4;
            this.CheckElec.Text = "Éléctriques";
            this.CheckElec.UseVisualStyleBackColor = true;
            this.CheckElec.CheckedChanged += new System.EventHandler(this.CheckElec_CheckedChanged);
            // 
            // CheckDate
            // 
            this.CheckDate.AutoSize = true;
            this.CheckDate.Location = new System.Drawing.Point(125, 280);
            this.CheckDate.Name = "CheckDate";
            this.CheckDate.Size = new System.Drawing.Size(187, 17);
            this.CheckDate.TabIndex = 5;
            this.CheckDate.Text = "Commencer la location aujourd\'hui";
            this.CheckDate.UseVisualStyleBackColor = true;
            this.CheckDate.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // DATE
            // 
            this.DATE.Location = new System.Drawing.Point(22, 330);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(273, 20);
            this.DATE.TabIndex = 6;
            this.DATE.ValueChanged += new System.EventHandler(this.DATE_ValueChanged);
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(113, 403);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 7;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // FormCRUDEmprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 450);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.DATE);
            this.Controls.Add(this.CheckDate);
            this.Controls.Add(this.CheckElec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectV);
            this.Name = "FormCRUDEmprunts";
            this.Text = "Emprunter un véhicule";
            this.Load += new System.EventHandler(this.FormCRUDEmprunts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckElec;
        private System.Windows.Forms.CheckBox CheckDate;
        private System.Windows.Forms.DateTimePicker DATE;
        private Button OK;

        public ComboBox SelectV1 { get => SelectV; set => SelectV = value; }
        public DateTimePicker DATE1 { get => DATE; set => DATE = value; }
        public ComboBox SelectD1 { get => SelectD; set => SelectD = value; }
        public CheckBox CheckDate1 { get => CheckDate; set => CheckDate = value; }
    }
}