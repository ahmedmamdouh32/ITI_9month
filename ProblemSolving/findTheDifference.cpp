class Solution {
public:
    char findTheDifference(string s, string t) {
        char different_char = 0;
        for (unsigned short i = 0;i < s.length(); i++) {
            different_char += (t[i] - s[i]);
        }
        different_char += t[t.length() - 1];
        return different_char;    
    }
};