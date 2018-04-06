using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public struct Person
        {
            public Label l1;
            public Label l2;
            public Label l3;
            public Button b1;
            public Button b2;

            public int nomer;
            public String coord;
        };

        Person[] persons = new Person[200];

        int yPersa = 300;
        int nomerPersa = 0;

        PictureBox[] pic1 = new PictureBox[1000];

        public MainForm()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Kartinki|*.bmp";
            saveFileDialog1.Filter = "cpp files|*.cpp";
        }

        private void buttonAddCharClick(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private string PersonName(int nomer)
        {
            return "per" + nomer.ToString();
        }

        private void delete_pics2(string filename, int nomer)
        {
            File.AppendAllText(filename, Environment.NewLine);
            
            for (int n1 = 0; n1 <= 5; n1++)
            {
                File.AppendAllText(filename, "    txDeleteDC(" + PersonName(n1) + ".texture);" + Environment.NewLine);
            }
        }
        
        private void open_main(string filename)
        {
            File.AppendAllText(filename, "int main()" +                    Environment.NewLine);
            File.AppendAllText(filename, "{" +                             Environment.NewLine);
            File.AppendAllText(filename, "    txCreateWindow(" + 
                PictureBoxBackground.Image.Width.ToString() + ", " +
                PictureBoxBackground.Image.Height.ToString() + ");" +      Environment.NewLine);
        }
        
        private void open_while(string filename)
        {
            File.AppendAllText(filename,                                                                Environment.NewLine);
            File.AppendAllText(filename, "    while (!GetAsyncKeyState(VK_ESCAPE));" +                  Environment.NewLine);
            File.AppendAllText(filename, "    {" +                                                      Environment.NewLine);
            File.AppendAllText(filename, "        txSetColor(TX_RED);" +                                Environment.NewLine);
            File.AppendAllText(filename, "        txSetFillColor(TX_RED);" +                            Environment.NewLine);
            File.AppendAllText(filename, "        txRectangle(0, 0, txGetExtentX(), txGetExtentY());" + Environment.NewLine);
        }
        
        private void close_while(string filename)
        {
            File.AppendAllText(filename,                                                                Environment.NewLine);
            File.AppendAllText(filename, "        txSleep(10);" +                                       Environment.NewLine);
            File.AppendAllText(filename, "    }" +                                                      Environment.NewLine);
        }
        
        private void delete_pics(string filename)
        {
            File.AppendAllText(filename,                                                                Environment.NewLine);
            File.AppendAllText(filename, "    txDeleteDC(per.texture);" +                               Environment.NewLine);
        }

        private void SaveCharButtonClick(object sender, EventArgs e)
        {
            persons[nomerPersa].l1 = new Label();
            persons[nomerPersa].l1.Top = yPersa;
            persons[nomerPersa].l1.Left = 30;
            persons[nomerPersa].l1.Width = 20;
            persons[nomerPersa].l1.Visible = true;
            persons[nomerPersa].l1.Text = "1";
            this.panel1.Controls.Add(persons[nomerPersa].l1);

            persons[nomerPersa].l2 = new Label();
            persons[nomerPersa].l2.Top = yPersa;
            persons[nomerPersa].l2.Left = 60;
            persons[nomerPersa].l2.Width = 60;
            persons[nomerPersa].l2.Visible = true;
            persons[nomerPersa].l2.Text = "Перс1";
            this.panel1.Controls.Add(persons[nomerPersa].l2);

            persons[nomerPersa].l3 = new Label();
            persons[nomerPersa].l3.Top = yPersa;
            persons[nomerPersa].l3.Left = 120;
            persons[nomerPersa].l3.Width = 40;
            persons[nomerPersa].l3.Visible = true;
            persons[nomerPersa].l3.Text = "ocphcghfgh";
            this.panel1.Controls.Add(persons[nomerPersa].l3);

            persons[nomerPersa].b1 = new Button();
            persons[nomerPersa].b1.Top = yPersa;
            persons[nomerPersa].b1.Left = 170;
            persons[nomerPersa].b1.Width = 50;
            persons[nomerPersa].b1.Visible = true;
            persons[nomerPersa].b1.Text = "R" + nomerPersa.ToString();
            persons[nomerPersa].b1.MouseClick +=
                new MouseEventHandler(this.button1_Click_2);
            this.panel1.Controls.Add(persons[nomerPersa].b1);

            persons[nomerPersa].b2 = new Button();
            persons[nomerPersa].b2.Top = yPersa;
            persons[nomerPersa].b2.Left = 230;
            persons[nomerPersa].b2.Width = 50;
            persons[nomerPersa].b2.Visible = true;
            persons[nomerPersa].b2.Text = "X";
            this.panel1.Controls.Add(persons[nomerPersa].b2);

            persons[nomerPersa].coord = TextBoxWall1.Text;
            persons[nomerPersa].nomer = nomerPersa;

            nomerPersa++;
            yPersa = yPersa + 30;
        }

        private void circle_create_person(string filename, string name)
        { 
           File.AppendAllText(filename, "   HDC texture = txLoadImage(\"Pictures\\Personaj.bmp);" +    Environment.NewLine);
           File.AppendAllText(filename,                                                                Environment.NewLine);
           File.AppendAllText(filename, "    double textureX = 50;"+                                   Environment.NewLine);
           File.AppendAllText(filename, "    double textureY = 50;"+                                   Environment.NewLine);
           File.AppendAllText(filename, "    double angle = 0;"+                                       Environment.NewLine);
           File.AppendAllText(filename, "    double nomer_kadra = 0;"+                                 Environment.NewLine);
           File.AppendAllText(filename,                                                                Environment.NewLine);
        }

        private void old_place(string filename, string name)
        {
            File.AppendAllText(filename, "  " + name + ".x = 10; " + Environment.NewLine);
            File.AppendAllText(filename, "   " + name + ".y = 10; " + Environment.NewLine);
            File.AppendAllText(filename, "   " + name + ".nomer_kadra = 0; " + Environment.NewLine);
            File.AppendAllText(filename, " " + name + ".gr_dvigx = 1000; " + Environment.NewLine);
        }

        private void go_pryamo(string filename, string name)
        {
            File.AppendAllText(filename, "        txTransparentBlt(txDC(), " + name + ".x, " + name + ".y, 55, 86, " + name + ".texture, 55 * " + name + ".nomer_kadra, 0, RGB(0, 255, 255)); " + Environment.NewLine);
            File.AppendAllText(filename, "        " + name + ".x++; " + Environment.NewLine);
            File.AppendAllText(filename, "        " + name + ".nomer_kadra++;" + Environment.NewLine);
            File.AppendAllText(filename, "        if (" + name + ".nomer_kadra > 2) " + Environment.NewLine);
            File.AppendAllText(filename, "        {  " + Environment.NewLine);
            File.AppendAllText(filename, "            " + name + ".nomer_kadra = 0;" + Environment.NewLine);
            File.AppendAllText(filename, "        }" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "    }" + Environment.NewLine);
        }

        private void circle(string filename, string name)
        {
           File.AppendAllText(filename, "        angle++;"+                                            Environment.NewLine);
           File.AppendAllText(filename, "        textureX = 500 + 200 * cos (angle / 10);"+            Environment.NewLine);
           File.AppendAllText(filename, "        textureY = 300 + 200 * sin (angle / 10);"+            Environment.NewLine);
           File.AppendAllText(filename, "        txTransparentBlt(txDC(), textureX, textureY, 55, 86, texture, 55 * nomer_kadra, 0, RGB(0, 255, 255));"+ Environment.NewLine);
           File.AppendAllText(filename,                                                                Environment.NewLine);
           File.AppendAllText(filename, "        nomer_kadra++;"+                                      Environment.NewLine);
           File.AppendAllText(filename,                                                                Environment.NewLine);
           File.AppendAllText(filename, "        if (nomer_kadra > 2)"+                                Environment.NewLine);
           File.AppendAllText(filename, "          {"+                                                 Environment.NewLine);
           File.AppendAllText(filename, "           nomer_kadra = 0;"+                                 Environment.NewLine);
           File.AppendAllText(filename, "          }"+                                                 Environment.NewLine);
           File.AppendAllText(filename,                                                                Environment.NewLine); 
           File.AppendAllText(filename, "        txSleep(10);"+                                        Environment.NewLine);
           File.AppendAllText(filename, "     }"+                                                      Environment.NewLine);
           File.AppendAllText(filename,                                                                Environment.NewLine);
           File.AppendAllText(filename, "txDeleteDC(texture);"+                                        Environment.NewLine);
           File.AppendAllText(filename,                                                                Environment.NewLine);
           File.AppendAllText(filename, "return 0;"+                                                   Environment.NewLine);
           File.AppendAllText(filename, "}"+                                                           Environment.NewLine);
        }

        private void OpenAddCharClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText =File.ReadAllText(filename);
            nazvanieTextBox.Text = fileText;
        }

        private void AddBackArtClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            PictureBoxBackground.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void SaveMultButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK &&
                PictureBoxBackground.Image != null)
            {
                string filename = saveFileDialog1.FileName;

                Files.CreateStruct(filename);
                open_main(filename);

                if (ComboBoxMove.Text == "Прямо")
                {
                    Sinus.CreatePerson(filename, "per", TextBoxWall1.Text);
                    old_place(filename, "per");
                    Files.OpenWhile(filename);
                    go_pryamo(filename, "per");
                    close_while(filename);
                    delete_pics(filename);
                }
                else if (ComboBoxMove.Text == "Волнами")
                {
                    Sinus.CreatePerson(filename, "per", TextBoxWall1.Text);
                    Files.OpenWhile(filename);
                    Sinus.MovePerson(filename, "per");
                    close_while(filename);
                    delete_pics(filename);
                }
                else if (ComboBoxMove.Text == "Кругами")
                {
                    circle_create_person(filename, "per");
                    Files.OpenWhile(filename);
                    circle(filename, "per");
                    close_while(filename);
                    delete_pics(filename);
                }
                else if (ComboBoxMove.Text == "Диагонально")
                {
                    Sinus.CreatePerson(filename, "per", TextBoxWall1.Text);
                    old_place(filename, "per");
                    Files.OpenWhile(filename);
                    go_pryamo(filename, "per");
                    close_while(filename);
                    delete_pics(filename);
                }

                Files.Ending(filename);

                //Add TXLib and pics
                File.Copy(Path.Combine(Application.StartupPath, "TXLib.h"), filename.Replace(Path.GetFileName(filename), "TXLib.h"), true);
                string adres_papki = filename.Replace(Path.GetFileName(filename), "Pictures");
                if (!Directory.Exists(adres_papki))
                {
                    Directory.CreateDirectory(adres_papki);
                }
                File.Copy(Path.Combine(Application.StartupPath, "kartinka.bmp"), adres_papki + "\\Personaj.bmp", true);

                MessageBox.Show("Successfully");
            }
        }

        private void button1_Click_2(object sender, MouseEventArgs e)
        {
            for (int nomer = 0; nomer < nomerPersa; nomer++)
            {
                if (sender.Equals(persons[nomer].b1))
                {
                    TextBoxWall1.Text = persons[nomer].coord;
                }
            }
        }

        private void nazvanieTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
