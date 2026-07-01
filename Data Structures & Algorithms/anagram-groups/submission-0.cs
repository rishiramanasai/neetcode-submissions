public class Solution {
    public List<List<string>> GroupAnagrams(string[] strsIn) {
        List<string> strs = new List<string>(strsIn);
        List<List<string>> ans = new List<List<string>>();
        for(int i=0; i< strs.Count; i++){
            List<string> temp = new List<string>();
            temp.Add(strs[i]);
            for(int j = i + 1; j<strs.Count; j++){
                if(this.checkAnagrams(strs[i],strs[j])){
                    temp.Add(strs[j]);
                    strs.RemoveAt(j);
                    j--;
                }
            }
            ans.Add(temp);
        }
        return ans;
    }

    bool checkAnagrams(string a, string b){
        int aLen = a.Length;
        int bLen = b.Length;
        int[] arr = new int[26];
        int[] brr = new int[26];
        if(aLen!=bLen) return false;

        for(int i = 0; i < aLen ; i++){
            arr[a[i]-97]++;
            brr[b[i]-97]++;
        }
        for(int i=0;i<26;i++){
            if(arr[i]!=brr[i])return false;
        }
        return true;
    }
}
