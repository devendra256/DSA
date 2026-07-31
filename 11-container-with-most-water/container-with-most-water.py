class Solution:
    def maxArea(self, height: List[int]) -> int:
        
        left, right, maxArea = 0, len(height) - 1, 0

        while left < right:
            minHeight = min(height[left], height[right])
            distance = right - left

            area = minHeight * distance
            maxArea = max(maxArea, area)

            if height[left] < height[right]:
                left += 1
            else:
                right -= 1

        return maxArea