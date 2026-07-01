public class Solution {

    public string Encode(IList<string> strs) {
        int strsCount = strs.Count;
        StringBuilder payLoad = new StringBuilder();
        //payLoad.Append(strsCount);
        for(int i = 0;i<strsCount;i++){
            payLoad.Append(strs[i].Length);
            payLoad.Append("#");
            payLoad.Append(strs[i]);
        }
        Console.WriteLine(payLoad);
        return payLoad.ToString();
    }

    public List<string> Decode(string s) {
        List<string> sol = new List<string>();
        StringBuilder num = new StringBuilder();
        for(int i=0;i<s.Length;i++){
            if(s[i]=='#'){
                Console.WriteLine(s.Substring(i+1,int.Parse(num.ToString())));
                sol.Add(s.Substring(i+1,int.Parse(num.ToString())));
                i = i+int.Parse(num.ToString());
                num.Clear();
            }
            else{
                num.Append(s[i]);
            }
        }
        return sol;
   }
}
