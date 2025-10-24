//3- pointer to pointer of integer Write ONLY

#include <iostream>

using namespace std;

int main()
{

    int number = 10;

    int * ptr = &number;

    int* *ptr2ptr = &ptr;

    **ptr2ptr = 12; //write on the original integer value

    cout<<number;

    return 0;
}
