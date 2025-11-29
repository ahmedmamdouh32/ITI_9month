#include <iostream>
#include<vector>
#include<algorithm>
 
using namespace std;
int main()
{
    int n;
    cin >> n;
    int gift_index;
    vector<pair<int,int>> friends;
 
    for (int i = 0; i < n; i++) {
        cin >> gift_index;
        friends.push_back({i,gift_index});
    }
    
    sort(friends.begin(), friends.end(),
        [](auto& a, auto& b) {return a.second < b.second;});
 
	for (int i = 0; i < n; i++) {
        cout << friends[i].first+1<<" ";
	}
 
    return 0;
}