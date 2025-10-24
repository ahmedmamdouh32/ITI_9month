//4- pass by value/address    swap

#include <iostream>
using namespace std;

void swapByValue(int num1, int num2){
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

void swapByAddress(int *num1Ptr, int *num2Ptr){
    int temp = *num1Ptr;
    *num1Ptr = *num2Ptr;
    *num2Ptr = temp;
}

int main()
{
    int x = 10;
    int y = 20;

    swapByValue(x,y);
    cout<<"x="<<x<<", y="<<y<<endl;

    swapByAddress(&x,&y);
    cout<<"x="<<x<<", y="<<y;

    return 0;
}
