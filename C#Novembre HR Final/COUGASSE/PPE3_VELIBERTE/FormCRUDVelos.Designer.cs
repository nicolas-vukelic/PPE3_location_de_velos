using System.Windows.Forms;

namespace PPE3_VELIBERTE
{
    partial class FormCRUDVelos
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
            this.CheckElec = new System.Windows.Forms.CheckBox();
            this.CBorne = new System.Windows.Forms.ComboBox();
            this.TBorne = new System.Windows.Forms.Label();
            this.EtatBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.T2 = new System.Windows.Forms.TextBox();
            this.T1 = new System.Windows.Forms.TextBox();
            this.LA2 = new System.Windows.Forms.Label();
            this.LA1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckElec
            // 
            this.CheckElec.AutoSize = true;
            this.CheckElec.Location = new System.Drawing.Point(37, 47);
            this.CheckElec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckElec.Name = "CheckElec";
            this.CheckElec.Size = new System.Drawing.Size(116, 21);
            this.CheckElec.TabIndex = 0;
            this.CheckElec.Text = "Est electrique";
            this.CheckElec.UseVisualStyleBackColor = true;
            this.CheckElec.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CBorne
            // 
            this.CBorne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBorne.FormattingEnabled = true;
            this.CBorne.Location = new System.Drawing.Point(37, 75);
            this.CBorne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBorne.Name = "CBorne";
            this.CBorne.Size = new System.Drawing.Size(160, 24);
            this.CBorne.TabIndex = 1;
            this.CBorne.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // TBorne
            // 
            this.TBorne.AutoSize = true;
            this.TBorne.Location = new System.Drawing.Point(207, 79);
            this.TBorne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TBorne.Name = "TBorne";
            this.TBorne.Size = new System.Drawing.Size(91, 17);
            this.TBorne.TabIndex = 2;
            this.TBorne.Text = "Borne affiliée";
            this.TBorne.Click += new System.EventHandler(this.Label1_Click);
            // 
            // EtatBox
            // 
            this.EtatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EtatBox.FormattingEnabled = true;
            this.EtatBox.Items.AddRange(new object[] {
            "D",
            "R"});
            this.EtatBox.Location = new System.Drawing.Point(37, 132);
            this.EtatBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EtatBox.Name = "EtatBox";
            this.EtatBox.Size = new System.Drawing.Size(160, 24);
            this.EtatBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "État du véhicule";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(211, 416);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 37);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OK_Click);
            // 
            // T2
            // 
            this.T2.Location = new System.Drawing.Point(33, 305);
            this.T2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(163, 22);
            this.T2.TabIndex = 6;
            this.T2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCP_KeyPress);
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(33, 262);
            this.T1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(163, 22);
            this.T1.TabIndex = 7;
            this.T1.TextChanged += new System.EventHandler(this.T1_TextChanged);
            this.T1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCP_KeyPress);
            // 
            // LA2
            // 
            this.LA2.AutoSize = true;
            this.LA2.Location = new System.Drawing.Point(243, 268);
            this.LA2.Name = "LA2";
            this.LA2.Size = new System.Drawing.Size(59, 17);
            this.LA2.TabIndex = 8;
            this.LA2.Text = "Latitude";
            // 
            // LA1
            // 
            this.LA1.AutoSize = true;
            this.LA1.Location = new System.Drawing.Point(243, 310);
            this.LA1.Name = "LA1";
            this.LA1.Size = new System.Drawing.Size(71, 17);
            this.LA1.TabIndex = 9;
            this.LA1.Text = "Longitude";
            // 
            // FormCRUDVelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 506);
            this.Controls.Add(this.LA1);
            this.Controls.Add(this.LA2);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EtatBox);
            this.Controls.Add(this.TBorne);
            this.Controls.Add(this.CBorne);
            this.Controls.Add(this.CheckElec);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCRUDVelos";
            this.Text = "Gestion des vélos";
            this.Load += new System.EventHandler(this.FormCRUDVelos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckElec;
        private System.Windows.Forms.ComboBox CBorne;
        private System.Windows.Forms.Label TBorne;
        private System.Windows.Forms.ComboBox EtatBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox T2;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.Label LA2;
        private System.Windows.Forms.Label LA1;

        public TextBox T1Lon { get => T2; set => T2 = value; }
        public TextBox T1Lat { get => T1; set => T1 = value; }
        public ComboBox CBorne1 { get => CBorne; set => CBorne = value; }
        public CheckBox CheckElec1 { get => CheckElec; set => CheckElec = value; }
        public ComboBox EtatBox1 { get => EtatBox; set => EtatBox = value; }
        public Button OK1 { get => btnOK; set => btnOK = value; }
    }
}