public class Solution {
    public int MajorityElement(int[] nums) {
        
        // Time = O(n)
        // Space = O(n)

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
            if(pair.Value > (nums.Length / 2))
                ans = pair.Key;
        }
        return ans;
    }
}