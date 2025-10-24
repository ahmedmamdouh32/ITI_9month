//5-2D Array
//array [3][4]
//calculate average of columns

#include <iostream>

using namespace std;

int main()
{
    int arr[3][4] = {{1,2,3,3},
                     {4,5,6,6},
                     {7,8,9,9}
                    };

    int average_column[4] = {0};


    for(int i=0;i<4;i++){
        for(int j=0;j<3;j++){
            average_column[i]+=arr[j][i];
        }
        average_column[i]/=3;
    }

    //displaying the results
    for(int i=0; i<4;i++){
        cout<<average_column[i]<<",";
    }
    return 0;
}
