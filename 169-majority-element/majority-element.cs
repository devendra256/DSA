public class Solution {
    public int MajorityElement(int[] nums) {
        
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach(var num in nums) {
            if(map.ContainsKey(num)) {
                map[num]++;
            } else {
                map.Add(num, 1);
            }
        }
        int ans = -1;
        foreach(var pair in map) {
            if(map[pair.Key] > (nums.Length / 2))
                ans = pair.Key;
        }
        return ans;
    }
}