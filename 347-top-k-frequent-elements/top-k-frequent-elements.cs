public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] ans = new int[k];

        foreach(var num in nums) {
            
            if(dict.ContainsKey(num)) {
                dict[num]++;
            } else {
                dict.Add(num, 1);
            }
        }
        var sortedDict = dict.OrderByDescending(x => x.Value);

        int i = 0;
        foreach(var item in sortedDict){
            if(i == k) break;
            ans[i] = item.Key;
            i++;
        }
        return ans;
    }
}