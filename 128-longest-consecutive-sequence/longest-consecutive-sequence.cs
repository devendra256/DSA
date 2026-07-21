public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        Dictionary<int, bool> map = new Dictionary<int, bool>();
        int longestLength = 0;
        foreach(var num in nums) {
            map[num] = false;
        }

        foreach(var num in  nums) {
            int currentLength = 1;
            int nextNum = num + 1;

            while(map.ContainsKey(nextNum) && map[nextNum] == false) {
                currentLength++;
                map[nextNum] = true;
                nextNum++;
            }

            int prevNum = num - 1;

            while(map.ContainsKey(prevNum) && map[prevNum] == false) {
                currentLength++;
                map[prevNum] = true;
                prevNum--;
            }
            longestLength = Math.Max(longestLength, currentLength);
        }
        return longestLength;
    }
}