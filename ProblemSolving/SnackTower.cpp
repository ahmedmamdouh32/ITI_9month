#include <iostream>
#include<vector>
#include<algorithm>
using namespace std;
 
int main()
{
	vector<int> availableSnacksSize;
	int n;
	cin >> n;
	int currentMaxSize = n;
	int dailySnackSize;
	for (int i = 0; i < n; i++) {
		cin >> dailySnackSize;
		if (dailySnackSize == currentMaxSize){
			cout << dailySnackSize << " ";
			currentMaxSize--;
			while (currentMaxSize != 0) {
				auto it = find(availableSnacksSize.begin(), availableSnacksSize.end(), currentMaxSize);
				if (it != availableSnacksSize.end()) {
					cout << currentMaxSize << " ";
					currentMaxSize--;
				}
				else
				{
					break;
				}
			}
			cout << endl;
		}
		else{
			cout << endl;
			availableSnacksSize.push_back(dailySnackSize);
		}
	}
    return 0;
}