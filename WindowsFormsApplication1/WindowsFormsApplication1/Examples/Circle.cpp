#include "TXLib.h"

int main()
{
    txCreateWindow(800, 600);

    HDC texture = txLoadImage("Pictures\\Personaj.bmp");

    double textureX = 50;
    double textureY = 50;
    double angle = 0;
    double nomer_kadra = 0;

    while (!GetAsyncKeyState(VK_ESCAPE))
    {
        txSetColor(TX_RED);
        txSetFillColor(TX_RED);
        txRectangle(0, 0, txGetExtentX(), txGetExtentY());

        angle++;
        textureX = 500 + 200 * cos (angle / 10);
        textureY = 300 + 200 * sin (angle / 10);

        txTransparentBlt(txDC(), textureX, textureY, 55, 86, texture, 55 * nomer_kadra, 0, RGB(0, 255, 255));

        nomer_kadra++;

        if (nomer_kadra > 2)
        {
            nomer_kadra = 0;
        }

        txSleep(10);
    }

    txDeleteDC(texture);

    return 0;
}

