#include <iostream>
#include<vector>
#include<algorithm>
 
using namespace std;
int main()
{
    int n;
    cin >> n;
    int gift_index;
    int friends_gifts[n];
 
    for (int i = 0; i < n; i++) {
        cin >> gift_index;
        friends_gifts[gift_index-1] = i;
    }
 
	for (int i = 0; i < n; i++) {
        cout << friends_gifts[i]+1<<" ";
	}
 
    return 0;
}