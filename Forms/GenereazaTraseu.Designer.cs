namespace CentenarMareaUnire.Forms
{
    partial class GenereazaTraseu
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
            this.pictureBoxTraseu = new System.Windows.Forms.PictureBox();
            this.buttonGenerare = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTraseu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTraseu
            // 
            this.pictureBoxTraseu.Location = new System.Drawing.Point(75, 67);
            this.pictureBoxTraseu.Name = "pictureBoxTraseu";
            this.pictureBoxTraseu.Size = new System.Drawing.Size(1230, 821);
            this.pictureBoxTraseu.TabIndex = 0;
            this.pictureBoxTraseu.TabStop = false;
            // 
            // buttonGenerare
            // 
            this.buttonGenerare.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonGenerare.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerare.Location = new System.Drawing.Point(498, 930);
            this.buttonGenerare.Name = "buttonGenerare";
            this.buttonGenerare.Size = new System.Drawing.Size(294, 71);
            this.buttonGenerare.TabIndex = 3;
            this.buttonGenerare.Text = "Genereaza traseu";
            this.buttonGenerare.UseVisualStyleBackColor = false;
            this.buttonGenerare.Click += new System.EventHandler(this.buttonGenerare_Click);
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GenereazaTraseu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1427, 1057);
            this.Controls.Add(this.buttonGenerare);
            this.Controls.Add(this.pictureBoxTraseu);
            this.Name = "GenereazaTraseu";
            this.Text = "GenereazaTraseu";
            this.Load += new System.EventHandler(this.GenereazaTraseu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTraseu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTraseu;
        private System.Windows.Forms.Button buttonGenerare;
        private System.Windows.Forms.Timer timer;
    }
}