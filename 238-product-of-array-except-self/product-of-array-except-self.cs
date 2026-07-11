public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];

        left[0] = 1;
        for(int i = 1; i < nums.Length; i++) {
            left[i] = nums[i - 1] * left[i - 1];
        }

        right[nums.Length - 1] = 1;
        for(int j = nums.Length - 2; j > -1; j--) {
            right[j] = nums[j + 1] * right[j + 1];
        }

        int[] answer = new int[nums.Length];
        for(int k = 0; k < nums.Length; k++) {
            answer[k] = left[k] * right[k];
        }
        return answer;
    }
}