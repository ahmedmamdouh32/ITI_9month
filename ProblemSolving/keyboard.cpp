#include <iostream>
using namespace std;
 
int main()
{
    char direction;
    string moleInput;
    string keyboardButtonsOrder = "qwertyuiopasdfghjkl;zxcvbnm,./";
 
	cin >> direction >> moleInput;
 
    for (int i = 0; i < moleInput.length();i++) {
        if (direction == 'R') {
            moleInput[i] = keyboardButtonsOrder[keyboardButtonsOrder.find(moleInput[i]) - 1];
		}
        else {
            moleInput[i] = keyboardButtonsOrder[keyboardButtonsOrder.find(moleInput[i]) + 1];
        }
    }
    cout << moleInput;
    return 0;
}