#include <iostream>

using namespace std;

int main()
{

    int arr[10]={7,3,5,6,8,-1,-11,33,99};
    int Min = arr[0];
    int Max = arr[0];

    for(int i=1 ; i<10;i++){
        if(arr[i] < Min) Min=arr[i];
        if(arr[i] > Max) Max = arr[i];
    }


    cout<<"max : "<<Max<<", min : "<<Min;
    return 0;
}
