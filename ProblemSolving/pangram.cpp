#include <iostream>
using namespace std;
 
int main()
{
    int length;
    string word;
	int alphabet[26] = { 0 };
    cin >> length >> word;
    if (length < 26) {
        cout << "NO";
        return 0;
    }
 
    for (int i = 0; i < word.length();i++) {
       word[i] = tolower(word[i]);
    }
 
    for (int i = 0; i < word.length();i++) {
        alphabet[word[i] - 'a'] = 1;
    }
 
    for (int i = 0;i < 26;i++) {
        if (alphabet[i] != 1) {
            cout << "NO";
            return 0;
        }
    }
    cout << "YES";
 
    return 0;
}