public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0, j = numbers.Length-1;
        int[] output = new int[2];
        while(i<j){
            if(i==numbers.Length-1){
                output[0] = i+1;
                output[1] = j+1;
            }
            if(numbers[i]+numbers[j] == target){
                output[0] = i+1;
                output[1] = j+1;
            }
            if(i-j != -1){
                j--;
            }
            else{
                i = j;
                j = numbers.Length-1;
            }
        }
        return output;
    }
}
