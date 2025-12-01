#include <iostream>
using namespace std;

int main()
{
	int numberOfParticipants;
	cin >> numberOfParticipants;
	string username;
	string progressAnswer = "NO";
	int scoreBefore, scoreAfter = 0;
	for (int i = 0; i < numberOfParticipants;i++) {
		cin >> username;
		cin >> scoreBefore >> scoreAfter;
		if (scoreBefore >= 2400) {
			if (scoreAfter > scoreBefore) {
				progressAnswer = "YES";
				break;
			}
		}
	}
	cout << progressAnswer << endl;

    return 0;
}
