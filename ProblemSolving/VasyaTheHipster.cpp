#include <iostream>
using namespace std;
int absoulte(int a, int b) {
	if (a > b) return a - b;
	else return b - a;
}
int main()
{
	int a,b;
	cin >> a >> b;
	cout << min(a, b) << endl;
	cout << absoulte(a , b) / 2;
    return 0;
}