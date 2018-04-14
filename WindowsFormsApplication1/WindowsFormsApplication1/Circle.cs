using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Circle
    {

        public static void CreatePerson(string filename, string name)
        {
            File.AppendAllText(filename, "    Person " + name + ";" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".texture = txLoadImage(\"Pictures\\\\Personaj.bmp\");" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".x = 50;" + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".y = 50;" + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".angle = 0;" + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".nomer_kadra = 0;" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
        }

        public static void circle(string filename, string name)
        {
            File.AppendAllText(filename, "        angle++;" + Environment.NewLine);
            File.AppendAllText(filename, "        textureX = 500 + 200 * cos (angle / 10);" + Environment.NewLine);
            File.AppendAllText(filename, "        textureY = 300 + 200 * sin (angle / 10);" + Environment.NewLine);
            File.AppendAllText(filename, "        txTransparentBlt(txDC(), textureX, textureY, 55, 86, texture, 55 * nomer_kadra, 0, RGB(0, 255, 255));" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "        nomer_kadra++;" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "        if (nomer_kadra > 2)" + Environment.NewLine);
            File.AppendAllText(filename, "        {" + Environment.NewLine);
            File.AppendAllText(filename, "           nomer_kadra = 0;" + Environment.NewLine);
            File.AppendAllText(filename, "        }" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "        txSleep(10);" + Environment.NewLine);
            File.AppendAllText(filename, "     }" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "txDeleteDC(texture);" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "return 0;" + Environment.NewLine);
            File.AppendAllText(filename, "}" + Environment.NewLine);
        }
    }
}
