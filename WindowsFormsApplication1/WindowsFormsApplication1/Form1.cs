﻿using System;
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

    public partial class Form1 : Form
    {
        
        PictureBox[] pic1 = new PictureBox[1000];

        public Form1()
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
            
            pictureBox1.Image = Image.FromFile("kartinka.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, nazvanieTextBox.Text);
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

        
    }
}
