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
        Person[] persons = new Person[200];

        int yPersa = 300;
        int nomerPersa = 0;
        int pNomer = 0;
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
            pNomer = -120;
        }     

        private void DeletePics(string filename, int nomer)
        {
            File.AppendAllText(filename, Environment.NewLine);
            
            for (int n1 = 0; n1 < nomer; n1++)
            {
                File.AppendAllText(filename, "    txDeleteDC(" + Person.PersonName(n1) + ".texture);" + Environment.NewLine);
            }
        }      

        private void SaveCharButtonClick(object sender, EventArgs e)
        {
            if (pNomer == -120)
            {
                persons[nomerPersa].l1 = new Label();
                persons[nomerPersa].l1.Top = yPersa;
                persons[nomerPersa].l1.Left = 30;
                persons[nomerPersa].l1.Width = 20;
                persons[nomerPersa].l1.Visible = true;
                persons[nomerPersa].l1.Text = (nomerPersa + 1).ToString();
                this.panel1.Controls.Add(persons[nomerPersa].l1);

                persons[nomerPersa].l2 = new Label();
                persons[nomerPersa].l2.Top = yPersa;
                persons[nomerPersa].l2.Left = 60;
                persons[nomerPersa].l2.Width = 60;
                persons[nomerPersa].l2.Visible = true;
                persons[nomerPersa].l2.Text = "Перс" + (nomerPersa + 1).ToString();
                this.panel1.Controls.Add(persons[nomerPersa].l2);

                persons[nomerPersa].l3 = new Label();
                persons[nomerPersa].l3.Top = yPersa;
                persons[nomerPersa].l3.Left = 120;
                persons[nomerPersa].l3.Width = 40;
                persons[nomerPersa].l3.Visible = true;
                persons[nomerPersa].l3.Text = "saved";
                this.panel1.Controls.Add(persons[nomerPersa].l3);

                persons[nomerPersa].b1 = new Button();
                persons[nomerPersa].b1.Top = yPersa;
                persons[nomerPersa].b1.Left = 170;
                persons[nomerPersa].b1.Width = 50;
                persons[nomerPersa].b1.Visible = true;
                persons[nomerPersa].b1.Text = "Edit";
                persons[nomerPersa].b1.MouseClick +=
                    new MouseEventHandler(this.button1_Click_2);
                this.panel1.Controls.Add(persons[nomerPersa].b1);
                
                ToolTip tView = new ToolTip();
                tView.IsBalloon = true;
                tView.InitialDelay = 0;
                tView.ShowAlways = true;
                tView.AutoPopDelay = 2000;
                tView.SetToolTip(persons[nomerPersa].b1, "View/edit person");

                persons[nomerPersa].b2 = new Button();
                persons[nomerPersa].b2.Top = yPersa;
                persons[nomerPersa].b2.Left = 230;
                persons[nomerPersa].b2.Width = 50;
                persons[nomerPersa].b2.Visible = true;
                persons[nomerPersa].b2.Text = "Del";
                persons[nomerPersa].b2.Click +=
                    new System.EventHandler(this.label13_Click);
                this.panel1.Controls.Add(persons[nomerPersa].b2);

                ToolTip tDelete = new ToolTip();
                tDelete.IsBalloon = true;
                tDelete.InitialDelay = 0;
                tDelete.ShowAlways = true;
                tDelete.AutoPopDelay = 2000;
                tDelete.SetToolTip(persons[nomerPersa].b2, "Delete this person");

                persons[nomerPersa].coord = TextBoxWall1.Text;
                persons[nomerPersa].coord2 = TextBoxWall2.Text;
                persons[nomerPersa].time1 = TextBoxTime1.Text;
                persons[nomerPersa].time2 = TextBoxTime2.Text;
                persons[nomerPersa].sprite = SpriteNumberTextBox.Text;
                persons[nomerPersa].moveside = ComboBoxMove.Text;
                persons[nomerPersa].nomer = nomerPersa;
                persons[nomerPersa].charname = charNameBox.Text;
                persons[nomerPersa].l2.Text = charNameBox.Text;

                String[] coordinatyNachala = TextBoxWall1.Text.Split(new String[] { "," }, StringSplitOptions.None);
                if (coordinatyNachala.Length > 1)
                {
                    persons[nomerPersa].x1 = coordinatyNachala[0];
                    persons[nomerPersa].y1 = coordinatyNachala[1];
                }

                String[] coordinatyKonza = TextBoxWall2.Text.Split(new String[] { "," }, StringSplitOptions.None);
                if (coordinatyKonza.Length > 1)
                {
                    persons[nomerPersa].x2 = coordinatyKonza[0];
                    persons[nomerPersa].y2 = coordinatyKonza[1];
                }

                nomerPersa++;
                yPersa = yPersa + 30;
                openSpace.Image = null;
            }
            else
            {
                persons[pNomer].coord = TextBoxWall1.Text;
                persons[pNomer].coord2 = TextBoxWall2.Text;
                persons[pNomer].time1 = TextBoxTime1.Text;
                persons[pNomer].time2 = TextBoxTime2.Text;
                persons[pNomer].sprite = SpriteNumberTextBox.Text;
                persons[pNomer].moveside = ComboBoxMove.Text;
                persons[pNomer].nomer = pNomer;

                String[] coordinatyNachala = TextBoxWall1.Text.Split(new String[] { "," }, StringSplitOptions.None);
                if (coordinatyNachala.Length > 1)
                {
                    persons[pNomer].x1 = coordinatyNachala[0];
                    persons[pNomer].y1 = coordinatyNachala[1];
                }
                String[] coordinatyKonza = TextBoxWall2.Text.Split(new String[] { "," }, StringSplitOptions.None);
                if (coordinatyKonza.Length > 1)
                {
                    persons[pNomer].x2 = coordinatyKonza[0];
                    persons[pNomer].y2 = coordinatyKonza[1];
                }

                persons[pNomer].charname = charNameBox.Text;
                persons[pNomer].l2.Text = charNameBox.Text;
            }
        }

        private void old_place(string filename, string name, Person p)
        {
            //ctrl-c ctrl-v texture n_sprites x2 y2
            File.AppendAllText(filename, "    Person " + name + ";" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "   " + name + ".x = " + p.x1 + "; " + Environment.NewLine);
            File.AppendAllText(filename, "   " + name + ".y = " + p.y1 + "; " + Environment.NewLine);
            File.AppendAllText(filename, "   " + name + ".nomer_kadra = 0; " + Environment.NewLine);
            File.AppendAllText(filename, "   " + name + ".texture = txLoadImage(\"Pictures\\\\" + Path.GetFileName(p.adress) + "\"); " + Environment.NewLine);
            File.AppendAllText(filename, " " + name + ".gr_dvigx = 1000; " + Environment.NewLine);
        }

        private void go_pryamo(string filename, string name)
        {
            File.AppendAllText(filename, "        txTransparentBlt(txDC(), " + name + ".x, " + name + ".y, 55, 86, " + name + ".texture, 55 * " + name + ".nomer_kadra, 0, RGB(0, 255, 255)); " + Environment.NewLine);
            File.AppendAllText(filename, "        " + name + ".x++; " + Environment.NewLine);
            File.AppendAllText(filename, "        " + name + ".nomer_kadra++;" + Environment.NewLine);
            File.AppendAllText(filename, "        if (" + name + ".nomer_kadra > " + TextBoxWall1.Text + ") " + Environment.NewLine);
            File.AppendAllText(filename, "        {  " + Environment.NewLine);
            File.AppendAllText(filename, "            " + name + ".nomer_kadra = 0;" + Environment.NewLine);
            File.AppendAllText(filename, "        }" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
        }

        private void OpenAddCharClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            openSpace.Image = Image.FromFile(openFileDialog1.FileName);
            if (pNomer == -120)
            {
                persons[nomerPersa].adress = openFileDialog1.FileName;
            }
            else
            {
                persons[pNomer].adress = openFileDialog1.FileName;
            }
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

                //Add TXLib and pics
                File.Copy(Path.Combine(Application.StartupPath, "TXLib.h"), filename.Replace(Path.GetFileName(filename), "TXLib.h"), true);
                string adres_papki = filename.Replace(Path.GetFileName(filename), "Pictures");
                if (!Directory.Exists(adres_papki))
                {
                    Directory.CreateDirectory(adres_papki);
                }

                Files.CreateStruct(filename);
                Files.OpenMain(filename, PictureBoxBackground);

                for (int nomer = 0; nomer < nomerPersa; nomer++)
                {
                    File.Copy(persons[nomer].adress, adres_papki + "\\" + Path.GetFileName(persons[nomer].adress), true);

                    if (persons[nomer].moveside == "Прямо")
                    {
                        old_place(filename, Person.PersonName(nomer), persons[nomer]);
                    }
                    else if (persons[nomer].moveside == "Волнами")
                    {
                        Sinus.CreatePerson(filename, Person.PersonName(nomer), persons[nomer].coord);
                    }
                    else if (persons[nomer].moveside == "Кругами")
                    {
                        Circle.CreatePerson(filename, Person.PersonName(nomer), persons[nomer]);
                    }
                    else if (persons[nomer].moveside == "Диагонально")
                    {
                        old_place(filename, Person.PersonName(nomer), persons[nomer]);
                    }
                }

                Files.OpenWhile(filename);

                for (int nomer = 0; nomer < nomerPersa; nomer++)
                {
                    if (persons[nomer].moveside == "Прямо")
                    {
                        go_pryamo(filename, Person.PersonName(nomer));
                    }
                    else if (persons[nomer].moveside == "Волнами")
                    {
                        Sinus.MovePerson(filename, Person.PersonName(nomer));
                    }
                    else if (persons[nomer].moveside == "Кругами")
                    {
                        Circle.MovePerson(filename, Person.PersonName(nomer));
                    }
                    else if (persons[nomer].moveside == "Диагонально")
                    {
                        go_pryamo(filename, Person.PersonName(nomer));
                    }
                }

                Files.CloseWhile(filename);
                DeletePics(filename, nomerPersa);
                Files.Ending(filename);
                
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
                    TextBoxWall2.Text = persons[nomer].coord2;
                    TextBoxTime1.Text = persons[nomer].time1;
                    TextBoxTime2.Text = persons[nomer].time2;
                    SpriteNumberTextBox.Text = persons[nomer].sprite;
                    ComboBoxMove.Text = persons[nomer].moveside;
                    pNomer = persons[nomer].nomer;
                    charNameBox.Text = persons[nomer].charname;

                    if (!String.IsNullOrEmpty(persons[nomer].adress))
                    {
                        openSpace.Image = Image.FromFile(persons[nomer].adress);
                    }
                    else
                    {
                        openSpace.Image = null;
                    }
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Remove(persons[nomerPersa - 1].l1);
            this.panel1.Controls.Remove(persons[nomerPersa - 1].l2);
            this.panel1.Controls.Remove(persons[nomerPersa - 1].l3);
            this.panel1.Controls.Remove(persons[nomerPersa - 1].b1);
            this.panel1.Controls.Remove(persons[nomerPersa - 1].b2);
            nomerPersa--;
            yPersa = yPersa - 30;
        }

        private void TextBoxWall1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!(char.IsDigit(c) || c == '\b' || c == ','))
            {
                e.Handled = true;
            }
        }
    }
}