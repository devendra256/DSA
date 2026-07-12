public class Solution {
    public int MajorityElement(int[] nums) {

        int majority = nums[0];
        int votes = 1;

        for(int i = 1; i < nums.Length; i++) {

            if(majority == nums[i]) {
                votes++;
            } else {
                votes--;
                if(votes == 0) {
                    votes = 1;
                    majority = nums[i];
                }
            }
        }
        return majority;

    }
}