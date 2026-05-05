public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right=0;
        
        for (int i=0; i<piles.Length;i++){
            if (right<piles[i]) right = piles[i];
        }

        int? minHours=null; 

        while (left <= right){
            int mid = left + (right-left)/2;
            long totalHours = 0;
            foreach(int bananas in piles){
                totalHours += (bananas + mid - 1) / mid;
            }
            if (totalHours<= h){
                right = mid-1;
            }
            else{
                left= mid+1;
            }
            
        }
        return left;
    }
}


