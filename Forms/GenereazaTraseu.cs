using CentenarMareaUnire.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using FontFamily = System.Drawing.FontFamily;
using Pen = System.Drawing.Pen;

namespace CentenarMareaUnire.Forms
{
    public partial class GenereazaTraseu : Form
    {
        PointF[] polygon;
        int ind = 0;
        Dictionary<string, List<PointF>> regiuni = new Dictionary<string, List<PointF>>();
        Bitmap bmp;
        Graphics g;
        List<Bitmap> imagini = new List<Bitmap>();
        public GenereazaTraseu()
        {
            InitializeComponent();
           
        }

        private void GenereazaTraseu_Load(object sender, EventArgs e)
        { bmp = new Bitmap(pictureBoxTraseu.Width, pictureBoxTraseu.Height);
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
                    List<PointF> puncte = new List<PointF>();
                    while (reader.Peek() >= 0)
                    {
                        string line = reader.ReadLine();
                        string[] split = line.Split('*');
                        if (split.Length == 3) { nume = split[2]; }
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
                g.DrawEllipse(pen2, regiune.Value[0].X - 5, regiune.Value[0].Y - 5, 10, 10);
                FontFamily fontfam = FontFamily.GenericSansSerif;
                Font font = new Font(fontfam, 8);
                Brush brush2 = new SolidBrush(Color.White);
                g.DrawString(regiune.Key, font, brush2, regiune.Value[0].X + 5, regiune.Value[0].Y + 5);
            }


            pictureBoxTraseu.Image = bmp;
        }

        private void buttonGenerare_Click(object sender, EventArgs e)
        {
           
            Graphics g = Graphics.FromImage(bmp);
            List<CapitalaModel> capitale = new List<CapitalaModel>();
            foreach(var regiune in regiuni)
            {
                CapitalaModel capitala = new CapitalaModel();
                capitala.Nume = regiune.Key;
                capitala.Locatie = new PointF(regiune.Value[0].X, regiune.Value[0].Y);
                capitale.Add(capitala);
            }
            CapitalaModel capitalaBucuresti = capitale.Find(i => i.Nume == "Bucuresti");
            CapitalaModel capitalaCurrent = capitalaBucuresti;
            Pen pen = new Pen(Color.Green);
            while(capitale.Count > 1) {
                CapitalaModel capitalaGasit= new CapitalaModel();
                double distance = 100000;
                foreach(var capitala in capitale)
                {
                    if (capitala.Nume != capitalaCurrent.Nume)
                    {
                        float dx= capitala.Locatie.X- capitalaCurrent.Locatie.X;
                        float dy = capitala.Locatie.Y - capitalaCurrent.Locatie.Y;
                        if(Math.Sqrt(dx*dx + dy*dy) < distance)
                        {
                            distance= Math.Sqrt(dx*dx + dy* dy);
                            capitalaGasit = capitala;
                        }
                    }
                }
                
                g.DrawLine(pen,capitalaGasit.Locatie, capitalaCurrent.Locatie);
                capitalaCurrent= capitalaGasit;
                Bitmap cap = (Bitmap)bmp.Clone();
                imagini.Add(cap);
                capitale.Remove(capitalaCurrent);
               
            }
            g.DrawLine(pen, capitalaCurrent.Locatie, capitalaBucuresti.Locatie);
           Bitmap cap2 = (Bitmap)bmp.Clone();
            imagini.Add(cap2);
            timer.Start();



        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (ind != imagini.Count-1)
            {
                pictureBoxTraseu.Image = imagini[ind];
                ind++;
            }else
            {
                timer.Stop();
            }
        }
    }
}
