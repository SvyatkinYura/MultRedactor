
#include "TXLib.h"

int main()
{
    txCreateWindow(800, 600);

    HDC texture = txLoadImage("Personaj.bmp");

    double textureX = 50;
    double textureY = 50;
    double angle = 0;
    double BeginTime = 3;
    double EndTime = 10;
    double Time = 0;

    while (!GetAsyncKeyState(VK_ESCAPE))
    {
        txBegin();
        txSetColor(TX_WHITE);
        txSetFillColor(TX_RED);
        txRectangle(0, 0, txGetExtentX(), txGetExtentY());

        if ((Time >= BeginTime) && (Time <= EndTime))
        {
            angle++;
            textureX = 500 + 200 * cos (angle / 10);
            textureY = 300 + 200 * sin (angle / 10);

            txTransparentBlt(txDC(), textureX, textureY, 55, 86, texture, 0, 0, RGB(0, 255, 255));
        }

        txSleep(100);
        Time = Time + 0.1;

        char str[100];
        sprintf(str, "%f", Time);
        txTextOut(100, 100, str);
        txEnd();
    }

    txDeleteDC(texture);

    return 0;
}
