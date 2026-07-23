public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        int len = nums.Length;
        if(len == 0 || len == 1)
            return len;

        int idx = 0;
        for(int i = 0; i < len - 1; i++) {
            if(nums[i] != nums[i + 1]) {
                nums[idx++] = nums[i];
            }
        }
        nums[idx++] = nums[len - 1];
        return idx;
    }
}