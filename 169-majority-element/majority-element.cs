public class Solution {
    public int MajorityElement(int[] nums) {

        // due to Array.Sory(nums) method both 

        // Time = O(nlog n)
        // Space = O(log n)

        Array.Sort(nums);

        return nums[nums.Length / 2];

    }
}