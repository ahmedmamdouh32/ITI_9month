//which number you want to search
//4
//done at index 3
#include <iostream>

using namespace std;

int main()
{

    int arr[] = {1,2,3,4,1,5,6,2,1,9,10};
    int number;
    cout<<"Enter number : ";
    cin>>number;

    for(int i=0; i<sizeof(arr)/sizeof(arr[0]); i++)
    {
        if(number == arr[i])
        {
            cout<<"done at index "<<i;
            return 0; //end of program
        }
    }

    cout<<"Not found";

    return 0;
}
