using CentenarMareaUnire.DataAccess;
using CentenarMareaUnire.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentenarMareaUnire.Forms
{
    public partial class CentenarLogare : Form
    {
        public bool logat = false;
        List<string> selectedImages = new List<string>();
        List<string> oameniCaptcha = new List<string>();
        UserModel userEmail;
        public CentenarLogare()
        {
            InitializeComponent();
        }

        private void buttonLogare_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.Email= textBoxEmail.Text;
            user.Parola= textBoxParola.Text;
            user = DatabaseHelper.FindUser(user);
            if (user.Nume != null)
            {
                logat = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Eroare de autentificare!");
                textBoxEmail.Text = textBoxParola.Text = "";
            }
        }

        private void buttonVizualizare_Click(object sender, EventArgs e)
        {
            selectedImages = new List<string>();
            oameniCaptcha = new List<string>();
            userEmail = DatabaseHelper.FindUserByEmail(textBoxEmail.Text);
            if (userEmail.Nume != null) {
                panelCaptcha.Visible = true;
                label2.Text = "Am uitat parola pentru: " + userEmail.Email.Trim();
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                var captchaFiles = Directory.GetFiles(projectDirectory + @"\Resurse\Captcha");
                Random random = new Random();
                List<string> files = captchaFiles.OrderBy(i => random.Next()).Take(6).ToList();
                pictureBox1.Image= Image.FromFile(files[0]);
                pictureBox1.Tag = files[0];
               
                pictureBox2.Image = Image.FromFile(files[1]);
                pictureBox2.Tag = files[1];
                pictureBox3.Image = Image.FromFile(files[2]);
                pictureBox3.Tag = files[2];
                pictureBox4.Image = Image.FromFile(files[3]);
                pictureBox4.Tag = files[3];
                pictureBox5.Image = Image.FromFile(files[4]);
                pictureBox5.Tag = files[4];
                pictureBox6.Image = Image.FromFile(files[5]);
                pictureBox6.Tag = files[5];

                List<string> oameni = new List<string>();
                using(StreamReader reader = new StreamReader("C:\\Users\\Miriam\\Documents\\Aplicatii C\\CSHARP Nationala\\CentenarMareaUnire\\Resurse\\oameni.txt"))
                {
                    while (reader.Peek() >= 0)
                    {
                        oameni.Add(reader.ReadLine());
                    }
                }
                foreach(var file in files)
                {
                    if (oameni.Find(i=>file.Contains(i)) != null)
                    {
                        oameniCaptcha.Add(file);
                    }
                }


            }
            else { MessageBox.Show("Eroare de autentificare!"); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            selectedImages.Add(pictureBox.Tag.ToString());
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            int gasit = 0;
            foreach(var file in selectedImages)
            {
                if (oameniCaptcha.Find(i => i == file) != null)
                {
                    gasit++;
                }
            }
            if(gasit == oameniCaptcha.Count&&selectedImages.Count==oameniCaptcha.Count)
            {
                panelNewParola.Visible = true;


            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(textBoxConfirm.Text==textBoxParolaNoua.Text)
            {
                userEmail.Parola= textBoxParolaNoua.Text;
                DatabaseHelper.UpdateParola(userEmail);
                panelCaptcha.Visible = panelNewParola.Visible = false;
                panelCaptcha.Text = panelNewParola.Text= "";
            }
        }

        private void buttonAnulare_Click(object sender, EventArgs e)
        {
            panelCaptcha.Visible = panelNewParola.Visible = false;
            panelCaptcha.Text = panelNewParola.Text = "";

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
