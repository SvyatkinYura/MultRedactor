using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public struct Personazh
    {
        public string ce_nibud;
        public string nazvanie_personazha;
    }

    public partial class MainForm : Form
    {

        PictureBox[] pic1 = new PictureBox[1000];

        public MainForm()
        {
            InitializeComponent();

            button1.Click += button1_Click;
            button3.Click += button3_Click;
            openFileDialog1.Filter = "Text files(*OpenFileDialog.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*SaveFileDialog.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*int i=0;

            for (; i < 10; i++)
                {
                   PictureBox pic2 = new PictureBox();
                   pic2.Location = new Point(pic2.Location.X + (i*100), pic2.Location.Y);
                   pic2.BorderStyle = BorderStyle.FixedSingle;
                   pic1[i] = pic2;
                   Controls.Add(pic1[i]);
                 }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Список всех файлов папки
            //Создаешь из них массив (или список)
            //Выбираешь рандомный номер

            //pictureBox1.Image = Image.FromFile("kartinka.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, "");
            System.IO.File.AppendAllText(filename, "#include \"TXLib.h\"" + Environment.NewLine);
            System.IO.File.AppendAllText(filename, Environment.NewLine);
            System.IO.File.AppendAllText(filename, "int main()" + Environment.NewLine);
            System.IO.File.AppendAllText(filename, "{" + Environment.NewLine);
            //txCreateWindow(800, 600);



            System.IO.File.AppendAllText(filename, Environment.NewLine);
            System.IO.File.AppendAllText(filename, "txSetColor(TX_WHITE);" + Environment.NewLine);
            System.IO.File.AppendAllText(filename, "txSetFillColor(TX_WHITE);" + Environment.NewLine);
            System.IO.File.AppendAllText(filename, "txRectangle(0, 0, 800, 600);" + Environment.NewLine);
            System.IO.File.AppendAllText(filename, "HDC texture = txLoadImage(\"Pictures\\Personaj.bmp\");" + Environment.NewLine);


            //тут будет мультфильм
            System.IO.File.AppendAllText(filename, "return " + spriteTextBox.Text + "0;" + Environment.NewLine);

            System.IO.File.AppendAllText(filename, "}" + Environment.NewLine);
            MessageBox.Show("Файл сохранен");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            nazvanieTextBox.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            nazvanieTextBox.Text = fileText;
            //MessageBox.Show("Файл открыт");
            pictureBox1.Image = Image.FromFile("kartinka.jpg");
        }

    }
}