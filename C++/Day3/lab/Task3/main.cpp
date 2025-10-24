/*3-search on array and return index
 *|1|2|3|4|1|5|6|2|1|9|10|
 */

#include <iostream>
#define number_search 2
using namespace std;

int main()
{

    int arr[] = {1,2,3,4,1,5,6,2,1,9,10};



    for(int i=0; i<sizeof(arr)/sizeof(arr[0]); i++)
    {
        if(number_search == arr[i])
        {
            cout<<"done at index "<<i;
            return 0; //end of program
        }
    }

    cout<<"Not found";

    return 0;
}
