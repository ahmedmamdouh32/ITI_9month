/*2- try dynamic allocation for Array
 * of pointers to integers read and write
 * int *arr[3] -> int arr[3][4]
*/
#include <iostream>

using namespace std;

int main()
{

int *ptrs[3];

    ptrs[0] = new int[5];
    ptrs[1] = new int[5];
    ptrs[2] = new int[5];


    //writing:
    int counter = 0;
    for(int i=0 ; i<3; i++){
        for(int j=0; j<5; j++){
            ptrs[i][j] = counter;
            counter++;
        }
    }

    //reading:
     for(int i=0 ; i<3; i++){
        for(int j=0; j<5; j++){
            cout<<ptrs[i][j]<<" ";
        }
        cout<<endl;
    }




    return 0;
}
