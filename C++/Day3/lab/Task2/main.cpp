#include <iostream>

using namespace std;

int main()
{
    int arr[10]={7,3,5,6,8,-1,-11,33,99};

    for(int i=0 ; i<10;i++){
        for(int j=i;j<10;j++){
            if(arr[i]<arr[j]) swap(arr[i],arr[j]);
        }
    }

    for(int i=0 ; i<10;i++){
        cout<<arr[i]<<" ";
    }

    return 0;
}
