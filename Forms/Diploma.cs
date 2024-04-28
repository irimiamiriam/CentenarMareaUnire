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
    public partial class Diploma : Form
    {
        public int scor;
        public UserModel user = new UserModel();
        public Diploma()
        {
            InitializeComponent();
        }

        private void Diploma_Load(object sender, EventArgs e)
        {
            labelPremiu.Text = "Se acorda elevului "+user.Nume.Trim();
            if(scor == 10)
            {
                labelPremiu.Text += " premiul intai!";
            }
            if(scor == 9)
            {
                labelPremiu.Text += " premiul al doilea";
            }
            if(scor== 8)
            {
                labelPremiu.Text += " premiul al treilea!";
            }
            if (scor >= 5 && scor <= 7)
            {
                labelPremiu.Text += " mentiune!";
            }
            if (scor < 5)
            {
                labelPremiu.Text += " diploma de participare!";
            }

        }
    }
}
