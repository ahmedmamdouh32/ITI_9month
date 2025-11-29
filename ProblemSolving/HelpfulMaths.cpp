#include <iostream>
#include<vector>
#include<algorithm>
 
using namespace std;
int main()
{
	string s;
	cin >> s;
	vector<int> numbers;
	for (char c : s) {
		if (isdigit(c)) {
			numbers.push_back(c - '0');
		}
	}
	sort(numbers.begin(), numbers.end());
	for (int i = 0;i < numbers.size() - 1;i++) {
		cout << numbers[i] << "+";
	}
	cout << numbers[numbers.size() - 1];
    return 0;
}