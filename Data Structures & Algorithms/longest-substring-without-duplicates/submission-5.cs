public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int right = 0;
        int left = 0;
        int answer = 0;
        HashSet<char> substring = new HashSet<char>();

        while (right < s.Length) {
            if (!substring.Contains(s[right])) {
                substring.Add(s[right]);
                answer = Math.Max(substring.Count, answer);

                right++;
            } else {
                substring.Remove(s[left]);
                left++;
            }
        }

        return answer;
    }
}
