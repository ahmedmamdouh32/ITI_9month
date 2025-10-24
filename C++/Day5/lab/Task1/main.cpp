//1- try dynamic allocation for pointer to integer read and write 2 ways


#include <iostream>

using namespace std;

int main()
{
 int *ptr = new int [5];

 ////////////First Way////////////
 *(ptr+0) = 1;
 *(ptr+1) = 2;
 *(ptr+2) = 3;
 *(ptr+3) = 4;
 *(ptr+4) = 5;


 for(int i=0;i<5;i++){
    cout<<*(ptr+i)<<endl;
 }

  ////////////Second Way////////////

 ptr[0] = 1;
 ptr[1] = 2;
 ptr[2] = 3;
 ptr[3] = 4;
 ptr[4] = 5;
 for(int i=0;i<5;i++){
    cout<<ptr[i]<<endl;
 }


    return 0;
}
