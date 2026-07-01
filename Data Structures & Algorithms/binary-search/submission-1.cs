public class Solution {
    public int Search(int[] nums, int target) {
        int i = 0, j = nums.Length-1;
        while(i<=j){
            int mid = i+(j-i)/2;
            if(nums[mid] ==  target){
                return mid;
            }
            if(nums[mid]<=target){
                i=mid+1;
            }
            else{
                j=mid-1;
            }
        }
        return -1;
    }
}
