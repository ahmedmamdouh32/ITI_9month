class Solution {
public:
	int arraySign(vector<int>& digits) {
		int sign = 1;
		for (auto i = digits.begin(); i != digits.end();i++){
			if (*i == 0) return 0;
			else sign *= (*i > 0) ? 1 : -1;
		}
		return sign;
	}
};