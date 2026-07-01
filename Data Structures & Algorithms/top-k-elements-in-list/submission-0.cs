public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict =  new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(dict.ContainsKey(nums[i]))
                dict[nums[i]]++;
            else
                dict[nums[i]] = 1;
        }
        int j=0;
        int[] ans = new int[k];
        foreach(KeyValuePair<int,int> d in dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value)){
            Console.Write(d.Key);
            Console.Write(d.Value);
            Console.WriteLine();
            if(j<k)
                ans[j++]=d.Key;
            else
                return ans;
        }
        return ans;
    }
}
