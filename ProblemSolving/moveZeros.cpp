class Solution {
public:
	void moveZeroes(vector<int>& nums) {
		int vector_length = nums.size();
		int zero_indexer = 0;
		for (int i = 0 ; i < vector_length ; i++) {
			if (nums[i] != 0) {
				swap(nums[i], nums[zero_indexer]);
				zero_indexer++;
			}
		}
	}
};