#include <iostream>
using namespace std;

int main() {
		string s;
		cin>>s;
		if ((s.length()-1) % 2 == 0) {
			for (int i = s.length() - 1;i > 0; i--) {
				if (s[i] != '0') {
					cout << ((s.length() - 1) / 2) + 1;
					return 0;
				}
			}
			cout << (s.length() - 1) / 2;
		}
		else {
			cout << ((s.length() - 1) / 2) + 1;
		}
	return 0;
}