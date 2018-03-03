#include "TXLib.h"

struct Person
{
    double x;
    double y;
    double angle;
    double nomer_kadra;
    HDC texture;
    int MID_x;
    int MID_y;
    int rad;
    int skorost;
    int gr_dvigx;
    int gr_dvigy;
    int nach_dv;
    int ampl_y;
    int ampl_x;
    double BeginTime;
    double EndTime;
    double Time;
};

Person per;



int main()
{
    txCreateWindow(800, 600);

    per.texture = txLoadImage("Pictures\\Personaj.bmp");

    per.x = 10;
    per.y = 10;
    per.nomer_kadra = 0;
    per.gr_dvigx = 1000;

    while (per.x < per.gr_dvigx)
    {
        txSetColor(TX_RED);
        txSetFillColor(TX_RED);
        txRectangle(0, 0, txGetExtentX(), txGetExtentY());

        txTransparentBlt(txDC(), per.x, per.y, 55, 86, per.texture, 55 * per.nomer_kadra, 0, RGB(0, 255, 255));
        per.x++;
        per.nomer_kadra++;

        if (per.nomer_kadra > 2)
        {
            per.nomer_kadra = 0;
        }

        txSleep(10);
    }

    txDeleteDC(per.texture);

    return 0;
}

