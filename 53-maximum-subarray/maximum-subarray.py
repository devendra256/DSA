class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        currSum = best = nums[0]

        for n in nums[1:]:
            currSum = max(n, currSum + n)
            best = max(best, currSum)
        
        return best