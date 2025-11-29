#include <iostream>
 
using namespace std;
int main()
{
    int testCases;
    cin >> testCases;
    bool addTwoFlag = false;
    bool addZeroFlag = false;
    int current, previous;
    int sum = 0;
    int n;
 
    for (int i = 0; i < testCases; i++) {
        cin >> n;
        cin >> previous;
        sum += previous;
 
        for (int i = 0; i < n - 1;i++) {
            cin >> current;
            sum += current;
            if (addTwoFlag) continue;
 
            if (current + previous == -2) {
                addTwoFlag = true;
            }
            else if (current + previous == 0) {
                addZeroFlag = true;
            }
            previous = current;
        }
        if (addTwoFlag == true) {
            cout << sum + 4 << endl;
        }
        else if (addZeroFlag == true) {
            cout << sum << endl;
        }
        else {
            cout << sum - 4 << endl;;
        }
        addTwoFlag = false;
        addZeroFlag = false;
        sum = 0;
    }
    return 0;
}