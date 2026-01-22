#include <iostream>
#include<vector>
#include<algorithm>
using namespace std;

class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target){
        for(int i=0 ; i <nums.size();i++){
            cout<<nums[i]<<" ";
        }
        sort(nums.begin(),nums.end());
        for(int i=0 ; i <nums.size();i++){
            cout<<nums[i]<<" ";
        }
        vector<int> result;
        int startIndex = 0;
        int endIndex = nums.size()-1;
        while(true){
            int sum = nums[startIndex] + nums[endIndex];
            if(sum > target) endIndex--;
            else if(sum < target) startIndex++;
            else {
                result.push_back(startIndex);
                result.push_back(endIndex);
                return result;
            }
        }
        return result;
    }
};

int main()
{
    vector<int> v = {4,3,2,1};
    Solution s;
   s.twoSum(v,12);

    return 0;

}
