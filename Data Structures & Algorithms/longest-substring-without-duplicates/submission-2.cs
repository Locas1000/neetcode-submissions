public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int right = 0;
        int left = 0;
        int answer = 0;
        HashSet<char> substring = new HashSet<char>();

        while (right < s.Length){

        while(right < s.Length && !substring.Contains(s[right])){
        substring.Add(s[left]);
            substring.Add(s[right]);
            right++;
        }
            answer = Math.Max(substring.Count, answer);

            left++;
            right = left+1;
            substring.Clear();
        }

        return answer;
    }
}
