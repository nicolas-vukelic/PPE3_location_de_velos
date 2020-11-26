using System.Windows.Forms;

namespace PPE3_VELIBERTE
{
    partial class FormCRUDBorne
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
            this.tbNomBorne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnumAdresseRue = new System.Windows.Forms.TextBox();
            this.tbNomAdresseRue = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.LongitudeTB = new System.Windows.Forms.TextBox();
            this.LatitudeTB = new System.Windows.Forms.TextBox();
            this.latitude = new System.Windows.Forms.Label();
            this.LongitudeBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la Borne :";
            // 
            // tbNomBorne
            // 
            this.tbNomBorne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomBorne.Location = new System.Drawing.Point(148, 33);
            this.tbNomBorne.Name = "tbNomBorne";
            this.tbNomBorne.Size = new System.Drawing.Size(190, 22);
            this.tbNomBorne.TabIndex = 1;
            this.tbNomBorne.TextChanged += new System.EventHandler(this.TbNomBorne_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numéro de rue  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom rue  :";
            // 
            // tbnumAdresseRue
            // 
            this.tbnumAdresseRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnumAdresseRue.Location = new System.Drawing.Point(148, 80);
            this.tbnumAdresseRue.Name = "tbnumAdresseRue";
            this.tbnumAdresseRue.Size = new System.Drawing.Size(47, 22);
            this.tbnumAdresseRue.TabIndex = 4;
            this.tbnumAdresseRue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnumAdresseRue_KeyPress);
            // 
            // tbNomAdresseRue
            // 
            this.tbNomAdresseRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomAdresseRue.Location = new System.Drawing.Point(148, 118);
            this.tbNomAdresseRue.Name = "tbNomAdresseRue";
            this.tbNomAdresseRue.Size = new System.Drawing.Size(190, 22);
            this.tbNomAdresseRue.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOK.Location = new System.Drawing.Point(148, 312);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 36);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK\r\n";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // LongitudeTB
            // 
            this.LongitudeTB.Location = new System.Drawing.Point(148, 157);
            this.LongitudeTB.Name = "LongitudeTB";
            this.LongitudeTB.Size = new System.Drawing.Size(218, 20);
            this.LongitudeTB.TabIndex = 7;
            // 
            // LatitudeTB
            // 
            this.LatitudeTB.Location = new System.Drawing.Point(148, 201);
            this.LatitudeTB.Name = "LatitudeTB";
            this.LatitudeTB.Size = new System.Drawing.Size(218, 20);
            this.LatitudeTB.TabIndex = 8;
            // 
            // latitude
            // 
            this.latitude.AutoSize = true;
            this.latitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.latitude.Location = new System.Drawing.Point(27, 201);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(77, 16);
            this.latitude.TabIndex = 9;
            this.latitude.Text = "latitudeBox:";
            // 
            // LongitudeBox
            // 
            this.LongitudeBox.AutoSize = true;
            this.LongitudeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongitudeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LongitudeBox.Location = new System.Drawing.Point(27, 161);
            this.LongitudeBox.Name = "LongitudeBox";
            this.LongitudeBox.Size = new System.Drawing.Size(73, 16);
            this.LongitudeBox.TabIndex = 10;
            this.LongitudeBox.Text = "Longitude :";
            this.LongitudeBox.Click += new System.EventHandler(this.Label5_Click);
            // 
            // FormCRUDBorne
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 369);
            this.Controls.Add(this.LongitudeBox);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.LatitudeTB);
            this.Controls.Add(this.LongitudeTB);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbNomAdresseRue);
            this.Controls.Add(this.tbnumAdresseRue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomBorne);
            this.Controls.Add(this.label1);
            this.Name = "FormCRUDBorne";
            this.Text = "Ajouter/Modifier : table BORNE";
            this.Load += new System.EventHandler(this.FormCRUDBorne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomBorne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnumAdresseRue;
        private System.Windows.Forms.TextBox tbNomAdresseRue;
        private System.Windows.Forms.Button btnOK;
        private Label latitude;
        private Label LongitudeBox;
        private TextBox LongitudeTB;
        private TextBox LatitudeTB;

        public TextBox TbNomBorne
        {
            get
            {
                return tbNomBorne;
            }

            set
            {
                tbNomBorne = value;
            }
        }

        public TextBox TbnumAdresseRue
        {
            get
            {
                return tbnumAdresseRue;
            }

            set
            {
                tbnumAdresseRue = value;
            }
        }

        public TextBox TbNomAdresseRue
        {
            get
            {
                return tbNomAdresseRue;
            }

            set
            {
                tbNomAdresseRue = value;
            }
        }

        public TextBox LongitudeTB1 { get => LongitudeTB; set => LongitudeTB = value; }
        public TextBox LatitudeTB1 { get => LatitudeTB; set => LatitudeTB = value; }
    }
}