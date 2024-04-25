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
    public partial class VizualizareLectii : Form
    {
        List<LectieModel> lectii;
        public VizualizareLectii()
        {
            InitializeComponent();
        }

        private void VizualizareLectii_Load(object sender, EventArgs e)
        {
            lectii = DatabaseHelper.GetLectii(); 
            foreach(var lectie in lectii)
            {
                comboBoxLectii.Items.Add(lectie.Titlu);
            }
        }

        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            if(comboBoxLectii.SelectedItem != null)
            {
                LectieModel lectie = lectii.Find(i => i.Titlu == comboBoxLectii.SelectedItem.ToString());
                pictureBoxLectie.Image = Image.FromFile("C:\\Users\\Miriam\\Documents\\Aplicatii C\\CSHARP Nationala\\CentenarMareaUnire\\Resurse\\ContinutLectii\\" + lectie.File + ".bmp");
                UserModel user = DatabaseHelper.FindUserById(lectie.IdUtilizator);
                textBoxDetalii.Multiline = true;
                textBoxDetalii.Text = user.Nume + "\r\n" + user.Email+ "\r\n" + lectie.Regiune+ "\r\n" + lectie.Data.ToString();
            }
        }
    }
}
