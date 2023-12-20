using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text;

namespace Sisteminis_sd2
{

    public partial class Form1 : Form
    {
        private List<string> studentuDuomenys;
        private int rezv;
        private int rezm;
        private string currentFilePath;
        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "Studentai.txt");
            textBox5.Text = File.ReadAllText(filePath);
            textBox5.ReadOnly = true;
            studentuDuomenys = File.ReadAllLines(filePath).ToList(); // ikelia studentu duomenis i sarasa
            textBox5.Text = string.Join(Environment.NewLine, studentuDuomenys);
            Naujas();

        }
        private List<int> Pazymiai(string eilute)
        {
            List<int> pazymiai = new List<int>();

            string[] zodziai = eilute.Split(' ');

            foreach (string zodis in zodziai)
            {
                if (int.TryParse(zodis, out int pazymys))
                {
                    pazymiai.Add(pazymys);
                }
            }

            return pazymiai;
        }
        private int EgzaminoPaz(string eilute)
        {
            string[] zodziai = eilute.Split(' ');

            if (zodziai.Length > 0)
            {
                string egzaminoZodis = zodziai[zodziai.Length - 1];

                if (int.TryParse(egzaminoZodis, out int egzaminoPazymys))
                {
                    return egzaminoPazymys;
                }
            }
            return 0;
        }
        private int vid(List<int> pazymiai, int egzaminas)
        {
            int pazymiuSuma = pazymiai.Sum();
            int vidurkis = (pazymiuSuma + egzaminas) / (pazymiai.Count + 1);

            return vidurkis;
        }

        private int med(List<int> pazymiai, int egzaminas)
        {
            List<int> visiPazymiai = new List<int>(pazymiai);
            visiPazymiai.Add(egzaminas);
            visiPazymiai.Sort();

            int n = visiPazymiai.Count;
            int vidurinisIndeksas = n / 2;

            if (n % 2 == 0)
            {
                int mediana1 = visiPazymiai[vidurinisIndeksas - 1];
                int mediana2 = visiPazymiai[vidurinisIndeksas];
                return (mediana1 + mediana2) / 2;
            }
            else
            {
                return visiPazymiai[vidurinisIndeksas];
            }
        }
        private void Naujas()
        {

            StringBuilder naujasTekstas = new StringBuilder();

            foreach (string eilute in studentuDuomenys)
            {
                List<int> pazymiai = Pazymiai(eilute);
                int egzaminoPazymys = EgzaminoPaz(eilute);

                if (radioButton1.Checked)
                {
                    int vidurkis = vid(pazymiai, egzaminoPazymys);
                    naujasTekstas.AppendLine($"{eilute}  vidurkis: {vidurkis}");
                }
                else if (radioButton2.Checked)
                {
                    int mediana = med(pazymiai, egzaminoPazymys);
                    naujasTekstas.AppendLine($"{eilute}  mediana: {mediana}");
                }
            }

            textBox5.Text = naujasTekstas.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog1.FileName;
                textBox1.Text = File.ReadAllText(currentFilePath);
            }

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {


        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Neveikia !
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = currentFilePath;
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string vp = Convert.ToString(textBox2.Text);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox5.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // textBox5.SelectedText += textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string vp = textBox2.Text + " ";
            string egzaminas = textBox4.Text + " ";

            // Pazymiu tikrinimas
            var naujasIrasas = $"{vp}{textBox3.Text} Egzamino pazymis: {egzaminas}";
            bool ieskotiIrAtnaujinti = false;

            for (int i = 0; i < studentuDuomenys.Count; i++)
            {
                if (studentuDuomenys[i].Contains(vp) && studentuDuomenys[i].Contains(egzaminas))
                {
                    // Studenta atnaujiname
                    studentuDuomenys[i] = naujasIrasas;
                    ieskotiIrAtnaujinti = true;
                    break;
                }
            }

            if (!ieskotiIrAtnaujinti)
            {
                studentuDuomenys.Add(naujasIrasas);
            }

            textBox5.Text = string.Join(Environment.NewLine, studentuDuomenys);

            // Atnaujiname rezultatus
            Naujas();
            textBox5.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string vp = textBox2.Text + " ";
            string egzaminas = textBox4.Text + " ";
            string naujasIrasas = $"{vp}{textBox3.Text} Egzamino pazymis: {egzaminas}";
            studentuDuomenys.Add(naujasIrasas);

            textBox5.Text = string.Join(Environment.NewLine, studentuDuomenys);
            Naujas();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            Naujas();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            Naujas();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveFileDialog1.FileName;
                File.WriteAllText(currentFilePath, textBox1.Text);
            }
        }
    }
}
