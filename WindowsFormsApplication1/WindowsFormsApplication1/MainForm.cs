using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public TextBox[] b1 = new TextBox[100];

        PictureBox[] pic1 = new PictureBox[1000];

        public MainForm()
        {
            InitializeComponent();
            
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
            //Ñïèñîê âñåõ ôàéëîâ ïàïêè
            //Ñîçäàåøü èç íèõ ìàññèâ (èëè ñïèñîê)
            //Âûáèðàåøü ðàíäîìíûé íîìåð

            //pictureBox1.Image = Image.FromFile("kartinka.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void file_beginning(string filename)
        {
            File.WriteAllText(filename, "");
            File.AppendAllText(filename, "#include \"TXLib.h\"" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "struct Person" + Environment.NewLine);
            File.AppendAllText(filename, "{" + Environment.NewLine);
            File.AppendAllText(filename,"double x;" + Environment.NewLine);
            File.AppendAllText(filename, "double y;" + Environment.NewLine);
            File.AppendAllText(filename, "double angle;" + Environment.NewLine);
            File.AppendAllText(filename, "  double nomer_kadra;" + Environment.NewLine);
            File.AppendAllText(filename, "HDC texture;" + Environment.NewLine);
            File.AppendAllText(filename, " int MID_x;" + Environment.NewLine);
            File.AppendAllText(filename, " int MID_y;" + Environment.NewLine);
            File.AppendAllText(filename, " int rad;" + Environment.NewLine);
            File.AppendAllText(filename, "  int skorost;" + Environment.NewLine);
            File.AppendAllText(filename, "  int gr_dvigx;" + Environment.NewLine);
            File.AppendAllText(filename, "int gr_dvigy;" + Environment.NewLine);
            File.AppendAllText(filename, "int nach_dv;" + Environment.NewLine);
            File.AppendAllText(filename, "int ampl_y;" + Environment.NewLine);
            File.AppendAllText(filename, " int ampl_x;" + Environment.NewLine);
            File.AppendAllText(filename, "double BeginTime;" + Environment.NewLine);
            File.AppendAllText(filename, "double EndTime;" + Environment.NewLine);
            File.AppendAllText(filename, "double Time;" + Environment.NewLine);
            File.AppendAllText(filename, "};" + Environment.NewLine);

            File.AppendAllText(filename, "int main()" + Environment.NewLine);
            File.AppendAllText(filename, "{" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "txCreateWindow(800, 600);" + Environment.NewLine);

        }

        private void file_forser(string filename)
        {
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "txSetColor(TX_WHITE);" + Environment.NewLine);
            File.AppendAllText(filename, "txSetFillColor(TX_WHITE);" + Environment.NewLine);
            File.AppendAllText(filename, "txRectangle(0, 0, 800, 600);" + Environment.NewLine);
            File.AppendAllText(filename, "HDC texture = txLoadImage(\"Pictures\\Personaj.bmp\");" + Environment.NewLine);
        }

        private void file_ending(string filename)
        {
            File.AppendAllText(filename, "return " + SpriteNumberTextBox.Text + "0;" + Environment.NewLine);

            File.AppendAllText(filename, "}" + Environment.NewLine);
        }

        private void SaveCharButtonClick(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;

                //filename.Replace("Âàñÿ ÍÅ", "Ëîõ")
                file_beginning(filename);
                sinus_create_person(filename);
                open_while(filename);
                sinus3(filename);
                sinus4(filename);
                //sinus(filename);
                file_ending(filename);

                File.Copy("TXLib.h", filename.Replace(Path.GetFileName(filename), "TXLib.h"), true);
                string adres_papki = filename.Replace(Path.GetFileName(filename), "Pictures");
                if (!Directory.Exists(adres_papki))
                {
                    Directory.CreateDirectory(adres_papki);
                }
                File.Copy("kartinka.jpg", adres_papki + "\\Personaj.bmp", true);

                MessageBox.Show("Ôàéë ñîõðàíåí");
            }
        }

        private void sinus_create_person(string filename)
        {
            File.AppendAllText(filename, "    Person per;" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "    per.texture = txLoadImage(\"Pictures\\Personaj.bmp\");" + Environment.NewLine);
            File.AppendAllText(filename, "    per.x = 50;" + Environment.NewLine);
            File.AppendAllText(filename, "    per.y = 50;"+ Environment.NewLine);
            File.AppendAllText(filename, "    per.nomer_kadra = 0;" + Environment.NewLine);
            File.AppendAllText(filename, "    per.nach_dv = 300;" + Environment.NewLine);
            File.AppendAllText(filename, "    per.ampl_y = 150;" + Environment.NewLine);
            File.AppendAllText(filename, "    per.ampl_x = 10;" + Environment.NewLine); 
        }
        private void open_while(string filename)
        {
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "    while (!GetAsyncKeyState(VK_ESCAPE));" + Environment.NewLine);
            File.AppendAllText(filename, "    {" + Environment.NewLine);
            File.AppendAllText(filename, "        txSetColor(TX_RED);" + Environment.NewLine);
            File.AppendAllText(filename, "        txSetFillColor(TX_RED);" + Environment.NewLine);
            File.AppendAllText(filename, "        txRectangle(0, 0, txGetExtentX(), txGetExtentY());" + Environment.NewLine);
        }

        private void sinus3(string filename)
        {
            File.AppendAllText(filename, "        per.x++;" + Environment.NewLine);
            File.AppendAllText(filename, "        per.y = per.nach_dv + per.ampl_y * sin(per.x / per.ampl_x);" + Environment.NewLine);
            File.AppendAllText(filename, "        txTransparentBlt(txDC(), per.x, per.y, 55, 86, per.texture, 55 * per.nomer_kadra, 0, RGB(0, 255, 255));" + Environment.NewLine);
            File.AppendAllText(filename,                                                                Environment.NewLine); 
            File.AppendAllText(filename, "        per.nomer_kadra++;" + Environment.NewLine);
            File.AppendAllText(filename, "        if (per.nomer_kadra > 2)" + Environment.NewLine);
            File.AppendAllText(filename, "        {" + Environment.NewLine);
            File.AppendAllText(filename, "            per.nomer_kadra = 0;" + Environment.NewLine);
            File.AppendAllText(filename, "        }" + Environment.NewLine);           
        }
        
        private void sinus4(string filename)
        {
            File.AppendAllText(filename, "        txSleep(10);" + Environment.NewLine);
            File.AppendAllText(filename, "    }" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "txDeleteDC(per.texture);" + Environment.NewLine);
        }

        private void circle(string filename)
        {
           File.AppendAllText(filename,                                                                Environment.NewLine);
           File.AppendAllText(filename, "txCreateWindow(800, 600);"+                                   Environment.NewLine);
           File.AppendAllText(filename,                                                                Environment.NewLine);
           File.AppendAllText(filename, "   HDC texture = txLoadImage(\"Pictures\\Personaj.bmp);" +    Environment.NewLine);
           File.AppendAllText(filename,                                                                Environment.NewLine);
           File.AppendAllText(filename, "    double textureX = 50;"+                                   Environment.NewLine);
           File.AppendAllText(filename, "    double textureY = 50;"+                                   Environment.NewLine);
           File.AppendAllText(filename, "    double angle = 0;"+                                       Environment.NewLine);
           File.AppendAllText(filename, "    double nomer_kadra = 0;"+                                 Environment.NewLine);
           File.AppendAllText(filename,                                                                Environment.NewLine);
           File.AppendAllText(filename, "    while (!GetAsyncKeyState(VK_ESCAPE))"+                    Environment.NewLine);
           File.AppendAllText(filename, "    {"+                                                       Environment.NewLine);
           File.AppendAllText(filename, "        txSetColor(TX_RED);"+                                 Environment.NewLine);
           File.AppendAllText(filename, "        txSetFillColor(TX_RED);"+                             Environment.NewLine);
           File.AppendAllText(filename, "        txRectangle(0, 0, txGetExtentX(), txGetExtentY());"+  Environment.NewLine);
           File.AppendAllText(filename,                                                                Environment.NewLine);
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


        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText =File.ReadAllText(filename);
            nazvanieTextBox.Text = fileText;
            MessageBox.Show("Ôàéë îòêðûò");
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
            string fileText =File.ReadAllText(filename);
            nazvanieTextBox.Text = fileText;
            //MessageBox.Show("Ôàéë îòêðûò");
            PictureBoxBackground.Image = Image.FromFile("kartinka.jpg");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxWall2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            b1[0] = new TextBox();
            b1[0].Top = 10;
            b1[0].Left = 30;
            b1[0].Width = 200;
            b1[0].Visible = true;
            this.Controls.Add(b1[0]);

        }
    }
}