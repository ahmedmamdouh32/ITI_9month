//7-  3*3     *    3*2   =  3*2

#include <iostream>
using namespace std;

int main() {
    int rowsA = 3, colsA = 3;
    int rowsB = 3, colsB = 2;

    int A[3][3] = {
                    {1, 2, 3},
                    {4, 5, 6},
                    {7, 8, 9}
                  };

    int B[3][2] = {
                    {1, 2},
                    {3, 4},
                    {5, 6}
                  };

    int result[3][2] = {0};

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
