#include <iostream>
using namespace std;
int main()
{
	string s;
	cin >> s;
	if (s[0] > 'Z')
	{
		s[0] -= 32;
	}
	for (int i = 1; i < s.length();i++) {
		if (s[i - 1] == ' ')
			s[i] -= 32;
	}
	cout << s;
    return 0;
}