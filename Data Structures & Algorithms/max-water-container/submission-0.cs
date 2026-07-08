public class Solution {
    public int MaxArea(int[] heights) {
        int i=0, j=heights.Length-1, final = 0, minHeight = 0;
        while(i<j){
            if(heights[j] > heights[i]) minHeight = heights[i];
            else minHeight = heights[j];
            if((minHeight * (j-i)) > final){
                final = minHeight * (j-i);
            }
            if(heights[j] > heights[i]) i++;
            else j--;
        }
        return final;
    }
}
