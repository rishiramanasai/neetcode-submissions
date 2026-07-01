public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> temp = new HashSet<int>();
        for(int i = 0; i<nums.Length; i++){
            if(temp.Contains(nums[i])) return true;
            temp.Add(nums[i]);
        }
        return false;
    }
}