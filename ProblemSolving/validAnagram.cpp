class Solution {
public:
	bool isAnagram(string s, string t) {

		if (s.length() != t.length()) return false;

		uint16_t map[26] = { 0 };

		for (uint16_t i = 0 ; i < s.length() ; i++) {
			map[s[i] - 'a']++;
			map[t[i] - 'a']--;
		}

		for (uint16_t i = 0 ; i < 26 ; i++) {
			if (map[i] != 0) {
				return false;
			}
		}
		return true;
	}
};