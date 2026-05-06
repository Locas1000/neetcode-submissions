public class Solution {
    public bool IsValid(string s) {
        Stack<char> valid = new Stack<char>();
        foreach (char c in s){
            if (c == '(' || c == '[' || c == '{'){
                valid.Push(c);
            }
            else {
                if (valid.Count == 0) return false;

                char top = valid.Pop();
                if (c == ')' && top != '('){
                    return false; 
                }
                if (c == ']' && top != '['){
                    return false; 
                }
                if (c == '}' && top != '{'){
                    return false; 
                }
            }
        }
        return valid.Count == 0;

    }
}
