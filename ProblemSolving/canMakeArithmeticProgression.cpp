class Solution {
public:
	bool canMakeArithmeticProgression(vector<int>& digits) {
		if (digits.size() == 1) return true;
		sort(digits.begin(), digits.end());
		int values_difference = digits[1] - digits[0];
		for (int i = 1;i < digits.size()-1;i++) {
			if(digits[i+1] - digits[i] != values_difference){
				return false;
			}
		}
		return true;
	}
};
