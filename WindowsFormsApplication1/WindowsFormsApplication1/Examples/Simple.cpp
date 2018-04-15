#include "TXLib.h"

int main()
{
    txCreateWindow(800, 600);

    txSetColor(TX_WHITE);
    txSetFillColor(TX_WHITE);

    txRectangle(0, 0, 800, 600);
    HDC texture = txLoadImage("Pictures\\Personaj.bmp");

    return 0;
}

