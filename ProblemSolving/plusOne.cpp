class Solution {
public:
	vector<int> plusOne(vector<int>& digits){
		int vector_length = digits.size();
		for (int i = vector_length-1; i >= 0; i--){
			if (digits[i] == 9) {
				digits[i] = 0;
				if (i == 0) {
					digits.insert(digits.begin(), 1);
					return digits;
				}
			}
			else {
				digits[i] += 1;
				return digits;
			}
		}
		return digits;
	}
};