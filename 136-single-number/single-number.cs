public class Solution {
    public int SingleNumber(int[] nums) {

        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach(int num in nums) {
            if(dict.ContainsKey(num)) {
                dict[num]++;
            } else {
                dict[num] = 1;
            }
        }

        foreach(var keyVal in dict) {
            if(keyVal.Value == 1) {
                return keyVal.Key;
            }
        }
        return -1;
    }
}