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

    per.x = 50;
    per.y = 50;
    per.angle = 0;
    per.nomer_kadra = 0;
    per.texture = txLoadImage("Pictures\\Personaj.bmp");
    per.MID_x = 500;
    per.MID_y = 300;
    per.rad = 200;
    per.skorost = 10;



    while (!GetAsyncKeyState(VK_ESCAPE))
    {
        txSetColor(TX_RED);
        txSetFillColor(TX_RED);
        txRectangle(0, 0, txGetExtentX(), txGetExtentY());

        per.angle++;
        per.x = per.MID_x + per.rad * cos (per.angle / per.skorost);
        per.y = per.MID_y + per.rad * sin (per.angle / per.skorost);

        txTransparentBlt(txDC(), per.x, per.y, 55, 86, per.texture, 0, 0, RGB(0, 255, 255));


        txSleep(10);
    }

    txDeleteDC(per.texture);

    return 0;
}

