#include <iostream>

using namespace std;

int Add(int a,int b){
    return a+b;
}
int Sub(int a,int b){
    return a-b;
}
int Mul(int a,int b){
    return a*b;
}
int Div(int a,int b){
    return a/b;
}

int main()
{
    int n1,n2,result;
    char operation, user_choise = 'y';
    bool calculation_error = false;
    do{

    cout << "Enter First Number :" << endl;
    cin>>n1;
    cout << "Enter Second Number :" << endl;
    cin>>n2;

    do
    {
        cout<<"Enter operation : ";
        cin>>operation;
    }
    while(operation != '*' && operation != '+' && operation != '-' && operation != '/');

    switch(operation){
        case '+':
            result = Add(n1,n2);
            break;
        case '-':
            result = Sub(n1,n2);
            break;
        case '*':
            result = Mul(n1,n2);
            break;
        case '/':
            if(n2 == 0){
                cout<<"divide by zero Error!!!"<<endl;
                calculation_error = true;
            }
            else{
                result = Div(n1,n2);
            }
    }
    if(!calculation_error) {
        cout<<n1<<operation<<n2<<"="<<result<<endl;
        calculation_error = false; //clearing the flag
    }

    cout<<"Continue ??? y or n ";
    cin>>user_choise;
    }while(user_choise == 'y');
    return 0;
}
