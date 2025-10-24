#include <iostream>
#include<string.h>
using namespace std;

int main()
{
    char statement[20];

    gets(statement);
    for(int i=0;i<20;i++){
            if(statement[i]=='\0'){
                for(int j = i-1 ; j>=0 ; j--){
                    cout<<statement[j];
                }
                break;
            }
        }

    return 0;
}


