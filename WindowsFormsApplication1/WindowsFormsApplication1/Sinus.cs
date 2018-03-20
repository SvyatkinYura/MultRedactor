using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Sinus
    {
        public static void CreatePerson(string filename)
        {
            File.AppendAllText(filename, "    Person per;" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "    per.texture = txLoadImage(\"Pictures\\Personaj.bmp\");" + Environment.NewLine);
            File.AppendAllText(filename, "    per.x = 50;" + Environment.NewLine);
            File.AppendAllText(filename, "    per.y = 50;" + Environment.NewLine);
            File.AppendAllText(filename, "    per.nomer_kadra = 0;" + Environment.NewLine);
            File.AppendAllText(filename, "    per.nach_dv = 300;" + Environment.NewLine);
            File.AppendAllText(filename, "    per.ampl_y = 150;" + Environment.NewLine);
            File.AppendAllText(filename, "    per.ampl_x = 10;" + Environment.NewLine);
        }

        public static void sinus3(string filename)
        {
            File.AppendAllText(filename, "        per.x++;" + Environment.NewLine);
            File.AppendAllText(filename, "        per.y = per.nach_dv + per.ampl_y * sin(per.x / per.ampl_x);" + Environment.NewLine);
            File.AppendAllText(filename, "        txTransparentBlt(txDC(), per.x, per.y, 55, 86, per.texture, 55 * per.nomer_kadra, 0, RGB(0, 255, 255));" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "        per.nomer_kadra++;" + Environment.NewLine);
            File.AppendAllText(filename, "        if (per.nomer_kadra > 2)" + Environment.NewLine);
            File.AppendAllText(filename, "        {" + Environment.NewLine);
            File.AppendAllText(filename, "            per.nomer_kadra = 0;" + Environment.NewLine);
            File.AppendAllText(filename, "        }" + Environment.NewLine);
        }

        public static void sinus4(string filename)
        {
            File.AppendAllText(filename, "        txSleep(10);" + Environment.NewLine);
            File.AppendAllText(filename, "    }" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "txDeleteDC(per.texture);" + Environment.NewLine);
        }
    }

}
