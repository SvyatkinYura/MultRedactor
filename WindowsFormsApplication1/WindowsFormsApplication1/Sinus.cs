﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Sinus
    {
        public static void CreatePerson(string filename, string name, string xBeg)
        {
            File.AppendAllText(filename, "    Person " + name + ";" + Environment.NewLine);
            File.AppendAllText(filename,                              Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".texture = txLoadImage(\"Pictures\\\\Personaj.bmp\");" + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".x = " + xBeg + ";" + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".y = " + xBeg + ";" + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".nomer_kadra = 0;" + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".nach_dv = " + name + ".y;" + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".ampl_y = 150;" +    Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".ampl_x = 10;" +     Environment.NewLine); 
        }

        public static void MovePerson(string filename, string name)
        {
            File.AppendAllText(filename, "        " + name + ".x++;" + Environment.NewLine);
            File.AppendAllText(filename, "        " + name + ".y = " + name + ".nach_dv + " + name + ".ampl_y * sin(" + name + ".x / " + name + ".ampl_x);" + Environment.NewLine);
            File.AppendAllText(filename, "        txTransparentBlt(txDC(), " + name + ".x, " + name + ".y, 55, 86, " + name + ".texture, 55 * " + name + ".nomer_kadra, 0, RGB(0, 255, 255));" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "        " + name + ".nomer_kadra++;" + Environment.NewLine);
            File.AppendAllText(filename, "        if (" + name + ".nomer_kadra > 2)" + Environment.NewLine);
            File.AppendAllText(filename, "        {" + Environment.NewLine);
            File.AppendAllText(filename, "            " + name + ".nomer_kadra = 0;" + Environment.NewLine);
            File.AppendAllText(filename, "        }" + Environment.NewLine);
        }
    }
}
