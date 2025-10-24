#include <iostream>

using namespace std;

int main()
{

    void *ptr; //GP pointer

    int x = 12;

    ptr = &x;

    cout<<*(int*)ptr;

    return 0;
}
