#include "TXLib.h"

int main()
{
    txCreateWindow(800, 600);

    HDC tex_1 = txLoadImage("Pictures\\Personaj.bmp");
    HDC tex_2 = txLoadImage("Pictures\\asa.bmp");

    int tex_1X = 10;
    int tex_1Y = 10;

    int tex_2X = 10;
    int tex_2Y = 500;

    //Персноаж 1 движется с 1 по 3 секунды, персонаж 2 - со 2 по 4

    double angle = 0;
    double Time = 0;


    while (tex_1X < 1000)
    {
        txSetColor(TX_RED);
        txSetFillColor(TX_RED);
        txRectangle(0, 0, txGetExtentX(), txGetExtentY());

        if ((Time >= 1) && (Time <= 3))
        {
            txTransparentBlt(txDC(), tex_1X, tex_1Y, 55, 86, tex_1, 0, 0, RGB(0, 255, 255));
            tex_1Y++ ;
        }

        if ((Time >= 2) && (Time <= 4))
        {
            txTransparentBlt(txDC(), tex_2X, tex_2Y, 55, 86, tex_2, 0, 0, RGB(0, 255, 255));
            tex_2Y--;
        }

        txSleep(100);
        Time = Time + 0.1;

        txSleep(10);
    }

    txDeleteDC(tex_1);
    txDeleteDC(tex_2);

    return 0;
}
