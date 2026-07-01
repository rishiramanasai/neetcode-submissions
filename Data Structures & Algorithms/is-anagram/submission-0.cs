public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] sArr = new int[26];
        int[] tArr = new int[26];
        int sLen = s.Length;
        int tLen = t.Length;
        if(sLen != tLen) return false;
        for(int i=0;i<sLen;i++){
            sArr[s[i] - 97]++;
            tArr[t[i] - 97]++;
        }
        for(int i=0;i<26;i++){
            if(sArr[i]!=tArr[i]) return false;
        }
        return true;
    }
}
