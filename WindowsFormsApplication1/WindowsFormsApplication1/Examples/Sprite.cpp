#include "TXLib.h"

int main()
{
    txCreateWindow(800, 600);

    HDC texture = txLoadImage("Pictures\\Personaj.bmp");

    int textureX = 10;
    int textureY = 10;
    int nomer_kadra = 0;

    while (textureX < 1000)
    {
        txSetColor(TX_RED);
        txSetFillColor(TX_RED);
        txRectangle(0, 0, txGetExtentX(), txGetExtentY());

        txTransparentBlt(txDC(), textureX, textureY, 55, 86, texture, 55 * nomer_kadra, 0, RGB(0, 255, 255));
        textureX++;
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

