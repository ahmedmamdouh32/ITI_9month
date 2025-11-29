#include <iostream>
#include <queue>
using namespace std;

int main()
{
	priority_queue<int> maxHeap;

    int testCases;
	cin >> testCases;
    int logSize;
    int playersCounter = 0;
    for (int i = 0; i < testCases; i++)
    {
        int n;
        cin >> n;
        for (int j = 0; j < n;j++) {
            cin >> logSize;
			maxHeap.push(logSize);
        }

        while (maxHeap.top() != 1) {
			maxHeap.push(maxHeap.top() / 2);
            maxHeap.push(maxHeap.top() / 2 + maxHeap.top() % 2);
            maxHeap.pop();
            playersCounter++;
        }
        playersCounter++;
		if (playersCounter % 2 == 0) cout << "errorgorn" << endl;
		else cout << "maomao90" << endl;
        playersCounter = 0;
        maxHeap.empty();
    }
    return 0;
}