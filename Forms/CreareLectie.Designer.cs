namespace CentenarMareaUnire.Forms
{
    partial class CreareLectie
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
            this.textBoxRegiune = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitlu = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonNewRow = new System.Windows.Forms.Button();
            this.buttonDeleteRow = new System.Windows.Forms.Button();
            this.buttonDeleteColumn = new System.Windows.Forms.Button();
            this.buttonNewColumn = new System.Windows.Forms.Button();
            this.buttonReduLungimea = new System.Windows.Forms.Button();
            this.buttonCresteLungimea = new System.Windows.Forms.Button();
            this.buttonReduInaltimea = new System.Windows.Forms.Button();
            this.buttonCresteInaltime = new System.Windows.Forms.Button();
            this.buttonText = new System.Windows.Forms.Button();
            this.buttonPoza = new System.Windows.Forms.Button();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // textBoxRegiune
            // 
            this.textBoxRegiune.Location = new System.Drawing.Point(32, 169);
            this.textBoxRegiune.Name = "textBoxRegiune";
            this.textBoxRegiune.Size = new System.Drawing.Size(378, 31);
            this.textBoxRegiune.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Regiune: ";
            // 
            // textBoxTitlu
            // 
            this.textBoxTitlu.Location = new System.Drawing.Point(32, 72);
            this.textBoxTitlu.Name = "textBoxTitlu";
            this.textBoxTitlu.Size = new System.Drawing.Size(378, 31);
            this.textBoxTitlu.TabIndex = 10;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(27, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(122, 25);
            this.label.TabIndex = 9;
            this.label.Text = "Titlu lectie: ";
            // 
            // buttonNewRow
            // 
            this.buttonNewRow.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonNewRow.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewRow.Location = new System.Drawing.Point(23, 231);
            this.buttonNewRow.Name = "buttonNewRow";
            this.buttonNewRow.Size = new System.Drawing.Size(211, 71);
            this.buttonNewRow.TabIndex = 13;
            this.buttonNewRow.Text = "Rand nou";
            this.buttonNewRow.UseVisualStyleBackColor = false;
            this.buttonNewRow.Click += new System.EventHandler(this.buttonNewRow_Click);
            // 
            // buttonDeleteRow
            // 
            this.buttonDeleteRow.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonDeleteRow.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteRow.Location = new System.Drawing.Point(282, 231);
            this.buttonDeleteRow.Name = "buttonDeleteRow";
            this.buttonDeleteRow.Size = new System.Drawing.Size(211, 71);
            this.buttonDeleteRow.TabIndex = 14;
            this.buttonDeleteRow.Text = "Sterge rand";
            this.buttonDeleteRow.UseVisualStyleBackColor = false;
            this.buttonDeleteRow.Click += new System.EventHandler(this.buttonDeleteRow_Click);
            // 
            // buttonDeleteColumn
            // 
            this.buttonDeleteColumn.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonDeleteColumn.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteColumn.Location = new System.Drawing.Point(282, 323);
            this.buttonDeleteColumn.Name = "buttonDeleteColumn";
            this.buttonDeleteColumn.Size = new System.Drawing.Size(211, 71);
            this.buttonDeleteColumn.TabIndex = 16;
            this.buttonDeleteColumn.Text = "Sterge coloana";
            this.buttonDeleteColumn.UseVisualStyleBackColor = false;
            this.buttonDeleteColumn.Click += new System.EventHandler(this.buttonDeleteColumn_Click);
            // 
            // buttonNewColumn
            // 
            this.buttonNewColumn.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonNewColumn.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewColumn.Location = new System.Drawing.Point(23, 323);
            this.buttonNewColumn.Name = "buttonNewColumn";
            this.buttonNewColumn.Size = new System.Drawing.Size(211, 71);
            this.buttonNewColumn.TabIndex = 15;
            this.buttonNewColumn.Text = "Coloana noua";
            this.buttonNewColumn.UseVisualStyleBackColor = false;
            this.buttonNewColumn.Click += new System.EventHandler(this.buttonNewColumn_Click);
            // 
            // buttonReduLungimea
            // 
            this.buttonReduLungimea.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonReduLungimea.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReduLungimea.Location = new System.Drawing.Point(282, 502);
            this.buttonReduLungimea.Name = "buttonReduLungimea";
            this.buttonReduLungimea.Size = new System.Drawing.Size(211, 71);
            this.buttonReduLungimea.TabIndex = 20;
            this.buttonReduLungimea.Text = "Redu lungimea";
            this.buttonReduLungimea.UseVisualStyleBackColor = false;
            this.buttonReduLungimea.Click += new System.EventHandler(this.buttonReduLungimea_Click);
            // 
            // buttonCresteLungimea
            // 
            this.buttonCresteLungimea.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonCresteLungimea.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCresteLungimea.Location = new System.Drawing.Point(23, 502);
            this.buttonCresteLungimea.Name = "buttonCresteLungimea";
            this.buttonCresteLungimea.Size = new System.Drawing.Size(211, 71);
            this.buttonCresteLungimea.TabIndex = 19;
            this.buttonCresteLungimea.Text = "Creste lungimea";
            this.buttonCresteLungimea.UseVisualStyleBackColor = false;
            this.buttonCresteLungimea.Click += new System.EventHandler(this.buttonCresteLungimea_Click);
            // 
            // buttonReduInaltimea
            // 
            this.buttonReduInaltimea.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonReduInaltimea.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReduInaltimea.Location = new System.Drawing.Point(282, 410);
            this.buttonReduInaltimea.Name = "buttonReduInaltimea";
            this.buttonReduInaltimea.Size = new System.Drawing.Size(211, 71);
            this.buttonReduInaltimea.TabIndex = 18;
            this.buttonReduInaltimea.Text = "Redu inaltimea";
            this.buttonReduInaltimea.UseVisualStyleBackColor = false;
            this.buttonReduInaltimea.Click += new System.EventHandler(this.buttonReduInaltimea_Click);
            // 
            // buttonCresteInaltime
            // 
            this.buttonCresteInaltime.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonCresteInaltime.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCresteInaltime.Location = new System.Drawing.Point(23, 410);
            this.buttonCresteInaltime.Name = "buttonCresteInaltime";
            this.buttonCresteInaltime.Size = new System.Drawing.Size(211, 71);
            this.buttonCresteInaltime.TabIndex = 17;
            this.buttonCresteInaltime.Text = "Creste inaltimea";
            this.buttonCresteInaltime.UseVisualStyleBackColor = false;
            this.buttonCresteInaltime.Click += new System.EventHandler(this.buttonCresteInaltime_Click);
            // 
            // buttonText
            // 
            this.buttonText.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonText.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonText.Location = new System.Drawing.Point(23, 579);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(211, 71);
            this.buttonText.TabIndex = 21;
            this.buttonText.Text = "Text";
            this.buttonText.UseVisualStyleBackColor = false;
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonPoza
            // 
            this.buttonPoza.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonPoza.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoza.Location = new System.Drawing.Point(282, 579);
            this.buttonPoza.Name = "buttonPoza";
            this.buttonPoza.Size = new System.Drawing.Size(211, 71);
            this.buttonPoza.TabIndex = 22;
            this.buttonPoza.Text = "Poza";
            this.buttonPoza.UseVisualStyleBackColor = false;
            this.buttonPoza.Click += new System.EventHandler(this.buttonPoza_Click);
            // 
            // buttonSterge
            // 
            this.buttonSterge.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonSterge.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSterge.Location = new System.Drawing.Point(157, 666);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(211, 50);
            this.buttonSterge.TabIndex = 23;
            this.buttonSterge.Text = "Sterge control";
            this.buttonSterge.UseVisualStyleBackColor = false;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonSave.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(157, 722);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(211, 50);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Salveaza lectia";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(595, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(895, 756);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CreareLectie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1516, 802);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonPoza);
            this.Controls.Add(this.buttonText);
            this.Controls.Add(this.buttonReduLungimea);
            this.Controls.Add(this.buttonCresteLungimea);
            this.Controls.Add(this.buttonReduInaltimea);
            this.Controls.Add(this.buttonCresteInaltime);
            this.Controls.Add(this.buttonDeleteColumn);
            this.Controls.Add(this.buttonNewColumn);
            this.Controls.Add(this.buttonDeleteRow);
            this.Controls.Add(this.buttonNewRow);
            this.Controls.Add(this.textBoxRegiune);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitlu);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreareLectie";
            this.Text = "CreareLectie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxRegiune;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitlu;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonNewRow;
        private System.Windows.Forms.Button buttonDeleteRow;
        private System.Windows.Forms.Button buttonDeleteColumn;
        private System.Windows.Forms.Button buttonNewColumn;
        private System.Windows.Forms.Button buttonReduLungimea;
        private System.Windows.Forms.Button buttonCresteLungimea;
        private System.Windows.Forms.Button buttonReduInaltimea;
        private System.Windows.Forms.Button buttonCresteInaltime;
        private System.Windows.Forms.Button buttonText;
        private System.Windows.Forms.Button buttonPoza;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}