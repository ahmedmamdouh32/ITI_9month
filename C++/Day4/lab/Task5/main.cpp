//5- pass array as input param []   ,pass pointer

#include <iostream>

using namespace std;

void print_name(char *ptr)
{
    cout<<ptr;

}


void print_name_param(char name[])
{
    cout<<name;

}

int main()
{

    char name[] = "Ahmed Mamdouh";
    print_name_param(name);
    cout<<endl;
    print_name(name);


    return 0;
}
