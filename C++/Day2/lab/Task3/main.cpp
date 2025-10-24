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
    int box_size;
    do
    {
        cout<<"Enter the size of the Box : ";
        cin>>box_size;

    }while(box_size <= 1 || box_size %2 ==0);

    system("CLS"); //to clear the screen

    int row;
    int col;
    row=1;
    col=box_size/2 +1;

    for(int i=1;i<=box_size * box_size;i++)
    {
        gotoxy(col*3,row*3);
        cout<<i;

        if(i%box_size!=0)
        {
            row--;
            col--;
            if(col<1)col = box_size;
            if(row<1)row = box_size;
        }
        else row++;
    }

    return 0;
}
