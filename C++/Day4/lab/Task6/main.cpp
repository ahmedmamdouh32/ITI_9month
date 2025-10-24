//6- return [] as return type[not supported][compiler error]
    //and return pointer as a return type

#include <iostream>

using namespace std;


int* sort_array(int* array_ptr){
    for(int i=0 ; i<10;i++){
        for(int j=i;j<10;j++){
            if(array_ptr[i]<array_ptr[j]) swap(array_ptr[i],array_ptr[j]);
        }
    }
    return array_ptr;
}

void print_array(int* arrayptr){

 for(int i=0 ; i<10;i++)
    {
        cout<<arrayptr[i]<<" ";
    }
}

int main()
{
    int arr[10]={7,3,5,6,8,-1,-11,33,99};

    print_array(sort_array(arr));

    return 0;
}
