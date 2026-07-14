public class Solution {
    public int FindMin(int[] nums) {
        int i = 0, min = nums[0];
        if(nums.Length == 1) return nums[0];
        while(i<nums.Length - 1){
            //if(min > nums[i]) min = nums[i];
            if(nums[i] > nums[i+1]){
                min = nums[i + 1];
                break;
            }
            i++;
        }
        return min;
    }
}
