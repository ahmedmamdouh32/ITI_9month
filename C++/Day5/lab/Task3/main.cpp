//3- int **ptrArr;

#include <iostream>

using namespace std;

int main()
{

    int ** ptrArr;

    ptrArr = new int *[5];

    ptrArr[0] = new int[5];
    ptrArr[1] = new int[5];
    ptrArr[2] = new int[5];
    ptrArr[3] = new int[5];
    ptrArr[4] = new int[5];


    //writing:
    int counter = 0;
    for(int i=0 ; i<5; i++){
        for(int j=0; j<5; j++){
            ptrArr[i][j] = counter;
            counter++;
        }
    }

    //reading:
     for(int i=0 ; i<5; i++){
        for(int j=0; j<5; j++){
            cout<<ptrArr[i][j]<<" ";
        }
        cout<<endl;
    }


    return 0;
}
