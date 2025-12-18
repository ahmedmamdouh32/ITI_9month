#include <iostream>
#include <vector>
#include<algorithm>
using namespace std;

int main() {

	int n = 0;
	cin >> n;
	int inputValue = 0;
	int k;
	cin >> k;
	vector <int> values;
	for (int i = 0; i < n;i++) {
		cin >> inputValue;
		values.push_back(inputValue);
	}

	sort(values.begin(), values.end());

	if (k == 0) {
		if (values[0] > 1) {
			cout << values[0] - 1 << endl;
		}
		else {
			cout << -1 << endl;
		}
	}
	else if (k == n)
	{
		cout << values[n - 1] << endl;
	}
	else
	{
		if (values[k - 1] < values[k]) {
			cout << values[k - 1] << endl;
		}
		else {
			cout << -1 << endl;
		}

		return 0;
	}
}