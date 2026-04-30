public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary <string , List<string>> anagramMap = new Dictionary <string,List<string>>();

        foreach (string word in strs){
            char[] chars= word.ToCharArray();

            Array.Sort(chars);

            string sortedword = new string(chars);    
            if (!anagramMap.ContainsKey(sortedword)){
                anagramMap[sortedword] = new List<string>();
            }
            anagramMap[sortedword].Add(word);
        }    
        return new List<List<string>>(anagramMap.Values);
    }
}
