public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        int i = 0, count;
        if(s.Length < 2) return false;
        while (i < s.Length) {
            if(s[i] == '{' || s[i] == '(' || s[i] == '[' ){
                st.Push(s[i]);
            }
            else{
                count = st.Count;
                if(count == 0) return false;
                char curPeak = st.Pop();
                if ((s[i] == '}' && curPeak != '{') || (s[i] == ']' && curPeak != '[') ||
                    (s[i] == ')' && curPeak != '(')) {
                    return false;   
                }
            }
            i++;
        }
        count = st.Count;
        if(count == 0){
            return true;
        }else{
            return false;
        }
    }
}
