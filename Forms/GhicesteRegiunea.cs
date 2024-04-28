using CentenarMareaUnire.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentenarMareaUnire.Forms
{
    public partial class GhicesteRegiunea : Form
    {
        public UserModel user;
        PointF[] polygon;
        Dictionary<string, List<PointF>> regiuni = new Dictionary<string, List<PointF>>();
        TextBox textBoxRaspuns = new TextBox();
        string currentAnswer=null;
        int raspuns = 0;
        int indexer = 0;
        int scor = 0;
        public GhicesteRegiunea()
        {
            InitializeComponent();
        }

        private void GhicesteRegiunea_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            Bitmap  bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader("C:\\Users\\Miriam\\Documents\\Aplicatii C\\CSHARP Nationala\\CentenarMareaUnire\\Resurse\\Harti\\RomaniaMare.txt"))
            {

                while (reader.Peek() >= 0)
                {
                    lines.Add(reader.ReadLine());
                }
            }
            polygon = new PointF[lines.Count];
            for (int i = 0; i < lines.Count; i++)
            {

                string[] split1 = lines[i].Split('*');
                Point p1 = new Point(Convert.ToInt32(split1[0]), Convert.ToInt32(split1[1]));
                string[] split2 = new string[2];
                if (i + 1 < lines.Count) { split2 = lines[i + 1].Split('*'); }
                else { split2 = lines[0].Split('*'); }
                Point p2 = new Point(Convert.ToInt32(split2[0]), Convert.ToInt32(split2[1]));

                System.Drawing.Pen pen = new Pen(Color.Green);
                g.DrawLine(pen, p1, p2);

                polygon[i] = new PointF(Convert.ToInt32(split1[0]), Convert.ToInt32(split1[1]));
            }
            PathGradientBrush brush = new PathGradientBrush(polygon);
            brush.CenterPoint = new PointF(bmp.Width / 2, bmp.Height / 2);
            brush.CenterColor = Color.Blue;
            Color[] color = { Color.Red };
            brush.SurroundColors = color;
            g.FillPolygon(brush, polygon);

            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            var regiuniFiles = Directory.GetFiles(projectDirectory + @"\Resurse\Harti");
            foreach (var file in regiuniFiles)
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    int i = 0;
                    string nume = "";
                    string[] splitFile = file.Split(new string[] { @"\" }, StringSplitOptions.None);
                    nume = splitFile[splitFile.Length - 1].Split('.')[0];
                    List<PointF> puncte = new List<PointF>();
                    while (reader.Peek() >= 0)
                    {
                        string line = reader.ReadLine();
                        string[] split = line.Split('*');
                        
                        puncte.Add(new PointF(Convert.ToInt32(split[0]), Convert.ToInt32(split[1])));
                        i++;
                    }
                    if (nume != "") { regiuni.Add(nume, puncte); }
                }
            }
            Pen pen2 = new Pen(Color.White);

            foreach (var regiune in regiuni)
            {
                List<PointF> regiuneDesenat = new List<PointF>();
                PointF[] regiuneValues = new PointF[100];
                regiune.Value.CopyTo(regiuneValues);
                regiuneDesenat = regiuneValues.Take(regiune.Value.Count - 1).ToList();
                regiuneDesenat.RemoveAt(0);
                var regiuneArray = regiuneDesenat.ToArray();
                g.DrawPolygon(pen2, regiuneArray);
              
            }


            pictureBox1.Image = bmp; 
            
         
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonRaspuns.Enabled = true;
            
            Random rnd = new Random();
            regiuni.OrderBy(x => rnd.Next());
            KeyValuePair<string, List<PointF>> regiune1 = regiuni.First();
            float sumx = 0, sumy = 0;
            foreach(PointF point in regiune1.Value)
            {
                sumx += point.X;
                sumy+= point.Y;

            }
            PointF newPoint = new PointF((float)sumx / regiune1.Value.Count(), (float)sumy / regiune1.Value.Count());
            currentAnswer=regiune1.Key;
            regiuni.Remove(regiune1.Key);

            textBoxRaspuns = new TextBox();
            textBoxRaspuns.Width = 50;
            textBoxRaspuns.Location = new Point((int)newPoint.X + pictureBox1.Location.X-10, (int)newPoint.Y-10 + pictureBox1.Location.Y);
            Controls.Add(textBoxRaspuns);  
            textBoxRaspuns.BringToFront();
           
        }

        private void buttonRaspuns_Click(object sender, EventArgs e)
        {
            
                indexer++;
                if (textBoxRaspuns.Text == currentAnswer)
                {
                    raspuns++;
                    textBox1.Text = raspuns.ToString();
                 
                }
                else
                {

                    textBoxRaspuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    TextBox textBoxCorect = new TextBox();
                   textBoxCorect.Width = 60;
                    textBoxCorect.Location = new Point(textBoxRaspuns.Location.X, textBoxRaspuns.Location.Y + textBoxRaspuns.Height);
                    textBoxCorect.ReadOnly = true;
                    Controls.Add(textBoxCorect);
                    textBoxCorect.Text = currentAnswer;
                    textBoxCorect.BringToFront();
                }textBoxRaspuns.ReadOnly = true;
               if (indexer < 10)
             {  
                Random rnd = new Random();
                regiuni.OrderBy(x => rnd.Next());
                KeyValuePair<string, List<PointF>> regiune1 = regiuni.First();
                float sumx = 0, sumy = 0;
                foreach (PointF point in regiune1.Value)
                {
                    sumx += point.X;
                    sumy += point.Y;

                }
                PointF newPoint = new PointF((float)sumx / regiune1.Value.Count(), (float)sumy / regiune1.Value.Count());
                currentAnswer = regiune1.Key;
                regiuni.Remove(regiune1.Key);

                textBoxRaspuns = new TextBox();
                textBoxRaspuns.Width = 50;
                textBoxRaspuns.Location = new Point((int)newPoint.X + pictureBox1.Location.X - 10, (int)newPoint.Y - 10 + pictureBox1.Location.Y);
                Controls.Add(textBoxRaspuns);
                textBoxRaspuns.BringToFront();
            }
           else {
                buttonRaspuns.Enabled= false;
                buttonDiploma.Enabled = true;
              
            }
        }

        private void buttonDiploma_Click(object sender, EventArgs e)
        {
               Diploma diploma = new Diploma();
                diploma.scor = raspuns;
                diploma.user= user;
                this.Hide();
                diploma.ShowDialog();
                this.Close();
        }
    } 


}
