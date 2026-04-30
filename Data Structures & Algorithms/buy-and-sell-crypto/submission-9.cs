public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length < 2) return 0;
        int left =0;
        int right=1;
        int maxProfit = 0;
        int buy = prices[0];
        while (right < prices.Length){
            if (prices[left] < prices[right]){
                int currentProfit = prices[right] - buy;
                maxProfit = Math.Max(maxProfit, currentProfit);
            }
            if (prices[right] < buy) {
                buy = prices[right];
            }
            left = right;
            right ++;
        }
        return maxProfit;
    }
}