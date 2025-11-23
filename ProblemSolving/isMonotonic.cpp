class Solution {
public:
	bool isMonotonic(vector<int>& digits) {
		if (digits.size() <= 2) return true;
		int current_index = 0, monotonicType = 0;
		for (;current_index < digits.size() - 1; current_index++)
		{
			if (digits[current_index] == digits[current_index + 1]) continue;
			else if (digits[current_index] > digits[current_index + 1]) {
				monotonicType = 1; //decremental
				current_index++;
				break;
			}
			else {
				monotonicType = 2; //incremental 
				current_index++;
				break;
			}
		}

		if (current_index == digits.size() - 1) return true;

		switch (monotonicType) {
			case 1:
				for (; current_index < digits.size() - 1; current_index++)
				{
					if (digits[current_index] < digits[current_index + 1]) return false;
				}
				break;
			case 2:
				for (; current_index < digits.size() - 1; current_index++)
				{
					if (digits[current_index] > digits[current_index + 1]) return false;
				}
				break;
		}
		return true;
	}
};