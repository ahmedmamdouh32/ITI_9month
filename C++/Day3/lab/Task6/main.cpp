//6-multiply 2 matrix
//3*2    *  2*1  =  3*1
#include <iostream>
using namespace std;

int main() {
    int rowsA = 3, colsA = 2;
    int rowsB = 2, colsB = 1;

    int A[rowsA][colsA] = {{1, 2},
                           {3, 4},
                           {5, 6}
                          };

    int B[rowsB][colsB] = {{1},
                           {2}
                          };


    int result[3][1] = {0}; //initialize the result matrix

    for (int i = 0; i < rowsA; ++i)
        for (int j = 0; j < colsB; ++j)
            for (int k = 0; k < colsA; ++k)
                result[i][j] += A[i][k] * B[k][j];

    cout << "Result:" << endl;
    for (int i = 0; i < rowsA; ++i) {
        for (int j = 0; j < colsB; ++j)
            cout << result[i][j] << " ";
        cout << endl;
    }

    return 0;
}
