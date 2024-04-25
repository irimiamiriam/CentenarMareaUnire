namespace CentenarMareaUnire.Forms
{
    partial class VizualizareLectii
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
            this.pictureBoxLectie = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLectii = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAfisare = new System.Windows.Forms.Button();
            this.textBoxDetalii = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLectie)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLectie
            // 
            this.pictureBoxLectie.Location = new System.Drawing.Point(549, 15);
            this.pictureBoxLectie.Name = "pictureBoxLectie";
            this.pictureBoxLectie.Size = new System.Drawing.Size(962, 603);
            this.pictureBoxLectie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLectie.TabIndex = 0;
            this.pictureBoxLectie.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 92);
            this.label1.TabIndex = 1;
            this.label1.Text = "Centenarul Marii Uniri de la 1918 - aceasta platforma este dedicata aprofundarii " +
    "cunostintelor despre regiunile Marii Uniri de la 1918";
            // 
            // comboBoxLectii
            // 
            this.comboBoxLectii.FormattingEnabled = true;
            this.comboBoxLectii.Location = new System.Drawing.Point(25, 173);
            this.comboBoxLectii.Name = "comboBoxLectii";
            this.comboBoxLectii.Size = new System.Drawing.Size(479, 33);
            this.comboBoxLectii.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lectii:";
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonAfisare.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfisare.Location = new System.Drawing.Point(124, 259);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(294, 71);
            this.buttonAfisare.TabIndex = 4;
            this.buttonAfisare.Text = "Afiseaza";
            this.buttonAfisare.UseVisualStyleBackColor = false;
            this.buttonAfisare.Click += new System.EventHandler(this.buttonAfisare_Click);
            // 
            // textBoxDetalii
            // 
            this.textBoxDetalii.Location = new System.Drawing.Point(555, 645);
            this.textBoxDetalii.Multiline = true;
            this.textBoxDetalii.Name = "textBoxDetalii";
            this.textBoxDetalii.ReadOnly = true;
            this.textBoxDetalii.Size = new System.Drawing.Size(955, 219);
            this.textBoxDetalii.TabIndex = 5;
            // 
            // VizualizareLectii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1516, 874);
            this.Controls.Add(this.textBoxDetalii);
            this.Controls.Add(this.buttonAfisare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxLectii);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxLectie);
            this.Name = "VizualizareLectii";
            this.Text = "VizualizareLectii";
            this.Load += new System.EventHandler(this.VizualizareLectii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLectie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLectie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLectii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAfisare;
        private System.Windows.Forms.TextBox textBoxDetalii;
    }
}