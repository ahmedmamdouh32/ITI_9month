#include <iostream>
#include <string.h>
using namespace std;
struct Employee{
    int age;
    int id;
    char name[50];
    float salary;
};

int main()
{
    Employee emp1;

    Employee *ptrEmp = &emp1;
    ptrEmp->age = 30;
    ptrEmp->id = 123;
    ptrEmp->salary = 1200;
    strcpy(ptrEmp->name,"Ahmed Mamdouh");
    cout<<"Name : ";
    puts(ptrEmp->name);
    cout<<"Id : "<<ptrEmp->id<<", Age : "<<ptrEmp->age<<" Salary = "<<ptrEmp->salary<<endl;



    return 0;
}
