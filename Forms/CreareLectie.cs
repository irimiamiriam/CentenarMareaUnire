using CentenarMareaUnire.DataAccess;
using CentenarMareaUnire.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentenarMareaUnire.Forms
{
    public partial class CreareLectie : Form
    {
        int height = 100;
        int width = 100;
        int controls = 0;
        public UserModel user;
        public CreareLectie()
        {
            InitializeComponent();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, height));
            tableLayoutPanel1.RowCount++;

            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, width));
            tableLayoutPanel1.ColumnCount++;
        }

        private void buttonNewRow_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, height));
            tableLayoutPanel1.RowCount++;
        }

        private void buttonNewColumn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, width));
            tableLayoutPanel1.ColumnCount++;
        }

        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.RowCount > 0) tableLayoutPanel1.RowCount--; 
        }

        private void buttonDeleteColumn_Click(object sender, EventArgs e)
        {
         if(tableLayoutPanel1.ColumnCount>0)   tableLayoutPanel1.ColumnCount--;

        }

        private void buttonCresteInaltime_Click(object sender, EventArgs e)
        {
            height += 10;
        }

        private void buttonReduInaltimea_Click(object sender, EventArgs e)
        {
            height -= 10;
        }

        private void buttonCresteLungimea_Click(object sender, EventArgs e)
        {
            width += 10;
        }

        private void buttonReduLungimea_Click(object sender, EventArgs e)
        {
            width-= 10;
        }

        private void buttonText_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Add(new TextBox() { Multiline = true, Width=width }); 

        }

        private void buttonPoza_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Users\\Miriam\\Documents\\Aplicatii C\\CSHARP Nationala\\CentenarMareaUnire\\Resurse\\";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image poza = Image.FromFile(openFileDialog.FileName);
                tableLayoutPanel1.Controls.Add(new PictureBox() { Image = poza, SizeMode= PictureBoxSizeMode.StretchImage, Size = new Size(width,height) }); 
            }

        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Controls.Count - 1 >= 0)
            {
                var control = tableLayoutPanel1.Controls[tableLayoutPanel1.Controls.Count - 1];
                tableLayoutPanel1.Controls.Remove(control);
            }
           
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(tableLayoutPanel1.Width, tableLayoutPanel1.Height);
            Rectangle rectangle = new Rectangle(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height);
            tableLayoutPanel1.DrawToBitmap(image, rectangle);
            image.Save("C:\\Users\\Miriam\\Documents\\Aplicatii C\\CSHARP Nationala\\CentenarMareaUnire\\Resurse\\ContinutLectii\\"+ textBoxTitlu.Text.Trim()+".bmp");
            LectieModel lectie = new LectieModel();
            lectie.Titlu = textBoxTitlu.Text;
            lectie.Regiune= textBoxTitlu.Text;
            lectie.IdUtilizator = user.Id;
            lectie.File = textBoxTitlu.Text.Trim();
            DatabaseHelper.AddLectie(lectie);
        }
    }
    
}
