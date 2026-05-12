public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary <int,int> values = new Dictionary<int,int>();

        for (int i=0 ; i<nums.Length;i++){
            int compliment = target - nums[i];
            
            if(values.ContainsKey(compliment)) {
            return new int[]{values[compliment],i};
            }
            values[nums[i]]=i;
        }
        return new int[0];
    }
}
