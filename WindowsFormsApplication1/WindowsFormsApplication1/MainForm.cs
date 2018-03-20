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

        PictureBox[] pic1 = new PictureBox[1000];

        public MainForm()
        {
            InitializeComponent();
            
            openFileDialog1.Filter = "Text files(*OpenFileDialog.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*SaveFileDialog.txt)|*.txt|All files(*.*)|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void SaveCharButtonClick(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;

                //filename.Replace("Âàñÿ ÍÅ", "Ëîõ")
                Files.Beginning(filename);
                Sinus.CreatePerson(filename);
                open_while(filename);
                Sinus.sinus3(filename);
                Sinus.sinus4(filename);
                //sinus(filename);
                Files.Ending(filename);

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

        private void open_while(string filename)
        {
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "    while (!GetAsyncKeyState(VK_ESCAPE));" + Environment.NewLine);
            File.AppendAllText(filename, "    {" + Environment.NewLine);
            File.AppendAllText(filename, "        txSetColor(TX_RED);" + Environment.NewLine);
            File.AppendAllText(filename, "        txSetFillColor(TX_RED);" + Environment.NewLine);
            File.AppendAllText(filename, "        txRectangle(0, 0, txGetExtentX(), txGetExtentY());" + Environment.NewLine);
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
    }
}