#include <iostream>

using namespace std;


int binarySearch(int arr[], int array_size, int target)
{
    int left = 0;
    int right = array_size - 1;
    while (left <= right) {
        int mid = left + (right - left) / 2;  //to prevent overflow
        if (arr[mid] == target) return mid;
        else if (arr[mid] < target)left = mid + 1;
        else right = mid - 1;
    }
    return -1; //element not found
}

int main()
{

    int arr[6]={1,2,3,4,5,6};
    cout<<binarySearch(arr,6,0);
    return 0;
}
