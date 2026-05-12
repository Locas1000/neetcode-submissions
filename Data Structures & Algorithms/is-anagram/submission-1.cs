public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int[] freq = new int[26];
        foreach (char a in s){
            freq[a-'a']++;
        }
        foreach (char b in t){
            freq[b-'a']--;
        }
    
        foreach (int f in freq){
            if (f != 0) return false;
        }
        return true;
}}

