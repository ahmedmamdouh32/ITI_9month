#include <stdlib.h>
#include <windows.h>
#include<iostream>
using namespace std;

void gotoxy( int column, int row )
{
    COORD coord;
    coord.X = column;
    coord.Y = row;
    SetConsoleCursorPosition(GetStdHandle( STD_OUTPUT_HANDLE ),coord);
}


   int main()
{
    int row;
    int col;
    row=1;
    col=3/2 +1;

    for(int i=1;i<=9;i++)
    {
        gotoxy(col*3,row*3);
        cout<<i;

        if(i%3!=0)
        {
            row--;
            col--;
            if(col<1)col=3;
            if(row<1)row=3;
        }
        else row++;


    }

    return 0;
}
