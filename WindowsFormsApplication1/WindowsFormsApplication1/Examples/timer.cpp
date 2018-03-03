
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

    per.x = 50;
    per.y = 50;
    per.angle = 0;
    per.BeginTime = 3;
    per.EndTime = 10;
    per.Time = 0;
    per.MID_x = 500;
    per.MID_y = 300;
    per.rad = 200;
    per.skorost = 10;

    while (!GetAsyncKeyState(VK_ESCAPE))
    {
        txBegin();
        txSetColor(TX_WHITE);
        txSetFillColor(TX_RED);
        txRectangle(0, 0, txGetExtentX(), txGetExtentY());

        if ((per.Time >= per.BeginTime) && (per.Time <= per.EndTime))
        {
            per.angle++;
            per.x = per.MID_x + per.rad * cos (per.angle / per.skorost);
            per.y = per.MID_y + per.rad * sin (per.angle / per.skorost);

            txTransparentBlt(txDC(), per.x, per.y, 55, 86, per.texture, 0, 0, RGB(0, 255, 255));
        }

        txSleep(100);
        per.Time = per.Time + 0.1;

        char str[100];
        sprintf(str, "%f", per.Time);
        txTextOut(100, 100, str);
        txEnd();
    }

    txDeleteDC(per.texture);

    return 0;
}
