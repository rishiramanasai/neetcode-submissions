public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            int temp = 1;
            for(int j=0;j<nums.Length;j++){
                if(i!=j){
                    temp*=nums[j]; 
                }
            }
            output[i]=temp;
        }
        return output;
    }
}
