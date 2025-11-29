#include <iostream>
#include<vector>
#include<algorithm>
 
using namespace std;
int main()
{
    int testCases;
    cin >> testCases;
    string a, b;
 
    for (int i = 0; i < testCases; i++) {
        cin >> a >> b;
 
        if (a[a.length() - 1] > b[b.length() - 1]) cout << "<" << endl;
 
        else if (a[a.length() - 1] < b[b.length() - 1]) cout << ">" << endl;
 
        else
        {
            if (a[a.length() - 1] == 'S') {
                if (a.length() > b.length()) cout << "<" << endl;
                else if (a.length() < b.length()) cout << ">" << endl;
				else cout << "=" << endl;
			}
			else if (a[a.length() - 1] == 'L') {
				if (a.length() > b.length()) cout << ">" << endl;
				else if (a.length() < b.length()) cout << "<" << endl;
				else cout << "=" << endl;
			}
            else cout << "=" << endl;
        }
    }
    return 0;
}