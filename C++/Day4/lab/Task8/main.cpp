#include <iostream>
#include <string.h>
using namespace std;

int main()
{

    char fName[15] = "Ahmed";
    char Lname[15] = "Mamdouh";

    char fullName[30];

    strcpy(fullName,fName);
    strcat(fullName," ");
    strcat(fullName,Lname);
    cout<<fullName;

    return 0;
}
