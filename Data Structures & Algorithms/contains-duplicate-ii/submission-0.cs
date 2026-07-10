public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        for( int i=0; i<nums.Length -1;i++){
            for(int j=i+1; j< nums.Length; j++){
                if(j-i<=k && nums[j]==nums[i]){
                    return true;
                }
            }
        }
        return false;
    }
}