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
    public partial class Centenar_Start : Form
    {
        bool logat = false;
        UserModel user;
        public Centenar_Start()
        {
            InitializeComponent();
        }

        private void Centenar_Start_Load(object sender, EventArgs e)
        {
            DatabaseHelper.Initialisation();
        }

        private void buttonLogare_Click(object sender, EventArgs e)
        {
            CentenarLogare centenarLogare = new CentenarLogare();
            this.Hide();
            centenarLogare.ShowDialog();
            this.Show();
            logat = centenarLogare.logat;
            if(logat) { buttonCreate.Visible = buttonGhiceste.Visible = buttonTraseu.Visible = true; user = centenarLogare.user; }
        }

        private void buttonVizualizare_Click(object sender, EventArgs e)
        {
            VizualizareLectii vizualizare= new VizualizareLectii();
            this.Hide();
            vizualizare.ShowDialog();
            this.Show();

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreareLectie creare = new CreareLectie();
            this.Hide();
            creare.user = user;
            creare.ShowDialog();
            this.Show();
        }

        private void buttonGhiceste_Click(object sender, EventArgs e)
        {
            GhicesteRegiunea ghicesteRegiunea = new GhicesteRegiunea();
            this.Hide();
            ghicesteRegiunea.user = user;
            ghicesteRegiunea.ShowDialog();
            this.Show();
        }

        private void buttonTraseu_Click(object sender, EventArgs e)
        {
            GenereazaTraseu genereazaTraseu = new GenereazaTraseu();
            this.Hide();
            genereazaTraseu.ShowDialog();
            this.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
