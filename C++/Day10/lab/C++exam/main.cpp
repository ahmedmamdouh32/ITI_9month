#include <iostream>
#include<vector>
#include<algorithm>
using namespace std;

int arraySum(int* arr, int n){
    n--;
    if(n < 0)
        return 0;

    return arr[n] + arraySum(arr, n);
}



void printArray(int* ptr, int n){
    for(int i=0; i<n;i++){
        cout<<*ptr<<" ";
        ptr++;
    }
    cout<<endl;
}





void insertionSort(int *ptr, int n) {
	for (int i = 1; i < n;i++) {
		for (int j = i ; j > 0; j--) {
			if (ptr[j-1] > ptr[j]) {
				swap(ptr[j-1], ptr[j]);
			}
			else break;
		}
	}
}


int main()
{
   int arr[10] = {1,2,3,4,5,6,7,8,9,10}; //sum = 55
   cout<<arraySum(arr,10);

    return 0;

}
