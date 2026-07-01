public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int aLen = nums.Length;
        for(int i = 0;i<aLen-1;i++){
            for(int j = i+1;j<aLen;j++){
                if(nums[i]+nums[j]==target){
                    return [i,j];
                }
            }
        }
        return [];
    }
}
