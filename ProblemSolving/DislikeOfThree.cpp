#include <iostream>
#include <vector>
using namespace std;

int main() {

	int testCases = 0;
	int largestIndex = 0;
	cin >> testCases;
	vector <int> allTestCases;
	vector<int> vaildNumebrs;
	for (int i = 0; i < testCases; i++) {
		int n;
		cin >> n;
		if (n > largestIndex) largestIndex = n;
		allTestCases.push_back(n);
	}
	int counter = 1;

	while (vaildNumebrs.size() != largestIndex) {
		if (counter % 10 == 3 || counter % 3 == 0)
		{
			counter++;
			continue;
		}
		else
		{
			vaildNumebrs.push_back(counter);
			counter++;
		}
	}
	for (int i = 0; i < allTestCases.size();i++) {
		cout << vaildNumebrs[allTestCases[i] - 1] << endl;
	}
	return 0;
}