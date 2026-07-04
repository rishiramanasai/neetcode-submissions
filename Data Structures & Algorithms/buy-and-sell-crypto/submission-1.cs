public class Solution {
    public int MaxProfit(int[] prices) {
        int len = prices.Length;
        int max = 0;
        int i = 0, j = 1;
        while(j<len){
            if(prices[j] < prices[i]){
                i=j;
            }
            if(prices[j]-prices[i]>max){
                max=prices[j]-prices[i];
            }
            j++;
        }
        return max;
    }
}
