#include <iostream>
using namespace std;

class Solution {
public:
	int strStr(string haystack, string needle) {
		if (haystack.length() < needle.length()) {
			return -1;
		}

		int needle_iterator = 0;
		for (int i = 0; i <= (haystack.length() - needle.length() + 1); i++) {
			if (haystack[i] == needle[0]) {
				for (int j = i; j < i + needle.length(); j++) {
					if (haystack[j] == needle[needle_iterator]) {
						needle_iterator++;
					}
					else {
						needle_iterator = 0;
						break;
					}
				}
				if (needle_iterator == needle.length()) {
					return i;
					break;
				}
			}
		}
		return -1;
	}
};