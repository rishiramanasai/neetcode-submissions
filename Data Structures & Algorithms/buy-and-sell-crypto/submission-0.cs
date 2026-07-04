public class Solution {
    public int MaxProfit(int[] prices) {
        int len = prices.Length;
        int max = 0;
        for(int i=0;i<len -1;i++){
            for(int j = len-1 ;j > i; j--){
                if(prices[j] - prices[i] > max){
                    max = prices[j] - prices[i] ;
                }
            }
        }
        return max;
    }
}
