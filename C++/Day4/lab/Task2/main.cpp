//2- pointer to array  read and write   3 ways

#include <iostream>

using namespace std;

int main()
{


    char name[10] = "ahmed";


    char* ptr = name;
    //////////////////////////  1st method  //////////////////////////
    cout<< *ptr;
    ptr++;
    cout<< *ptr;
    ptr++;
    cout<< *ptr;
    ptr++;
    cout<< *ptr;
    ptr++;
    cout<< *ptr;
    ptr = name;

    *ptr = 'A';
    ptr++;
    *ptr = 'l';
    ptr++;
    *ptr = 'i';
    ptr++;
    *ptr='\0';
    ptr = name; //return to start point


    //////////////////////////  2nd method  //////////////////////////
    *(ptr+0) = 'A';
    *(ptr+1) = 'l';
    *(ptr+2) = 'i';
    *(ptr+3) = '\0';

    cout<<*(ptr+0);
    cout<<*(ptr+1);
    cout<<*(ptr+2);
    //////////////////////////  3rd method  //////////////////////////
    ptr[0] = 'H';
    ptr[1] = 'a';
    ptr[2] = 'n';
    ptr[3] = 'y';
    ptr[4] = '\0';


    cout<<ptr[0];
    cout<<ptr[1];
    cout<<ptr[2];
    cout<<ptr[3];
    cout<<ptr; //works the same as above









    return 0;
}
