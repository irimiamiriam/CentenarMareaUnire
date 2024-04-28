namespace CentenarMareaUnire.Forms
{
    partial class GhicesteRegiunea
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRaspuns = new System.Windows.Forms.Button();
            this.buttonDiploma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(74, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1233, 779);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonStart.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(1364, 235);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(294, 71);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1368, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nota:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1463, 341);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 31);
            this.textBox1.TabIndex = 5;
            // 
            // buttonRaspuns
            // 
            this.buttonRaspuns.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonRaspuns.Enabled = false;
            this.buttonRaspuns.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRaspuns.Location = new System.Drawing.Point(1373, 417);
            this.buttonRaspuns.Name = "buttonRaspuns";
            this.buttonRaspuns.Size = new System.Drawing.Size(294, 71);
            this.buttonRaspuns.TabIndex = 6;
            this.buttonRaspuns.Text = "Raspunde";
            this.buttonRaspuns.UseVisualStyleBackColor = false;
            this.buttonRaspuns.Click += new System.EventHandler(this.buttonRaspuns_Click);
            // 
            // buttonDiploma
            // 
            this.buttonDiploma.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonDiploma.Enabled = false;
            this.buttonDiploma.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiploma.Location = new System.Drawing.Point(1373, 535);
            this.buttonDiploma.Name = "buttonDiploma";
            this.buttonDiploma.Size = new System.Drawing.Size(294, 71);
            this.buttonDiploma.TabIndex = 7;
            this.buttonDiploma.Text = "Genereaza diploma";
            this.buttonDiploma.UseVisualStyleBackColor = false;
            this.buttonDiploma.Click += new System.EventHandler(this.buttonDiploma_Click);
            // 
            // GhicesteRegiunea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1707, 917);
            this.Controls.Add(this.buttonDiploma);
            this.Controls.Add(this.buttonRaspuns);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GhicesteRegiunea";
            this.Text = "GhicesteRegiunea";
            this.Load += new System.EventHandler(this.GhicesteRegiunea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRaspuns;
        private System.Windows.Forms.Button buttonDiploma;
    }
}