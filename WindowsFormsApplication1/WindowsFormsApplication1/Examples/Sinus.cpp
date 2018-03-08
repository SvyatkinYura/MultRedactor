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
Person per1;


int main()
{
    txCreateWindow(800, 600);

    per.texture = txLoadImage("Pictures\\Personaj.bmp");

    per.x = 50;
    per.y = 50;
    per.nomer_kadra = 0;
    per.nach_dv = 300;
    per.ampl_y = 150;
    per.ampl_x = 10;


    per1.x = 50;
    per1.y = 50;
    per1.angle = 0;
    per1.nomer_kadra = 0;
    per1.texture = txLoadImage("Pictures\\Personaj.bmp");
    per1.MID_x = 500;
    per1.MID_y = 300;
    per1.rad = 200;
    per1.skorost = 10;


    while (!GetAsyncKeyState(VK_ESCAPE))
    {
        txSetColor(TX_RED);
        txSetFillColor(TX_RED);
        txRectangle(0, 0, txGetExtentX(), txGetExtentY());

        per.x++;
        per.y = per.nach_dv + per.ampl_y * sin(per.x / per.ampl_x);

        txTransparentBlt(txDC(), per.x, per.y, 55, 86, per.texture, 55 * per.nomer_kadra, 0, RGB(0, 255, 255));

        per.nomer_kadra++;

        if (per.nomer_kadra > 2)
        {
            per.nomer_kadra = 0;
        }


        per1.angle++;
        per1.x = per1.MID_x + per1.rad * cos (per1.angle / per1.skorost);
        per1.y = per1.MID_y + per1.rad * sin (per1.angle / per1.skorost);

        txTransparentBlt(txDC(), per1.x, per1.y, 55, 86, per1.texture, 0, 0, RGB(0, 255, 255));


        txSleep(10);
        txSleep(10);
    }

    txDeleteDC(per.texture);
    txDeleteDC(per1.texture);

    return 0;
}

