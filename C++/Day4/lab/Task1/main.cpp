//1- pointer to integer  read & write

#include <iostream>
using namespace std;

int main()
{
int number = 12;

int *ptr = &number;

*ptr+=1 ; //pointer write

cout<<*ptr; //pointer read

    return 0;
}


