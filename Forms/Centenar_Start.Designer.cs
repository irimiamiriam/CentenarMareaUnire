namespace CentenarMareaUnire.Forms
{
    partial class Centenar_Start
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
            this.buttonLogare = new System.Windows.Forms.Button();
            this.buttonVizualizare = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonGhiceste = new System.Windows.Forms.Button();
            this.buttonTraseu = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogare
            // 
            this.buttonLogare.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonLogare.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogare.Location = new System.Drawing.Point(114, 45);
            this.buttonLogare.Name = "buttonLogare";
            this.buttonLogare.Size = new System.Drawing.Size(321, 112);
            this.buttonLogare.TabIndex = 0;
            this.buttonLogare.Text = "Logare utilizator";
            this.buttonLogare.UseVisualStyleBackColor = false;
            this.buttonLogare.Click += new System.EventHandler(this.buttonLogare_Click);
            // 
            // buttonVizualizare
            // 
            this.buttonVizualizare.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonVizualizare.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVizualizare.Location = new System.Drawing.Point(609, 45);
            this.buttonVizualizare.Name = "buttonVizualizare";
            this.buttonVizualizare.Size = new System.Drawing.Size(321, 112);
            this.buttonVizualizare.TabIndex = 1;
            this.buttonVizualizare.Text = "Vizualizare lectii";
            this.buttonVizualizare.UseVisualStyleBackColor = false;
            this.buttonVizualizare.Click += new System.EventHandler(this.buttonVizualizare_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonCreate.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(27, 204);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(321, 112);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Creare lectie";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Visible = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonGhiceste
            // 
            this.buttonGhiceste.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonGhiceste.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGhiceste.Location = new System.Drawing.Point(354, 204);
            this.buttonGhiceste.Name = "buttonGhiceste";
            this.buttonGhiceste.Size = new System.Drawing.Size(321, 112);
            this.buttonGhiceste.TabIndex = 3;
            this.buttonGhiceste.Text = "Ghiceste regiunea";
            this.buttonGhiceste.UseVisualStyleBackColor = false;
            this.buttonGhiceste.Visible = false;
            this.buttonGhiceste.Click += new System.EventHandler(this.buttonGhiceste_Click);
            // 
            // buttonTraseu
            // 
            this.buttonTraseu.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonTraseu.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTraseu.Location = new System.Drawing.Point(681, 204);
            this.buttonTraseu.Name = "buttonTraseu";
            this.buttonTraseu.Size = new System.Drawing.Size(321, 112);
            this.buttonTraseu.TabIndex = 4;
            this.buttonTraseu.Text = "Generare Traseu";
            this.buttonTraseu.UseVisualStyleBackColor = false;
            this.buttonTraseu.Visible = false;
            this.buttonTraseu.Click += new System.EventHandler(this.buttonTraseu_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonExit.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(365, 393);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(321, 46);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Iesire";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Centenar_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1051, 451);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonTraseu);
            this.Controls.Add(this.buttonGhiceste);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonVizualizare);
            this.Controls.Add(this.buttonLogare);
            this.Name = "Centenar_Start";
            this.Text = "Centenar_Start";
            this.Load += new System.EventHandler(this.Centenar_Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogare;
        private System.Windows.Forms.Button buttonVizualizare;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonGhiceste;
        private System.Windows.Forms.Button buttonTraseu;
        private System.Windows.Forms.Button buttonExit;
    }
}