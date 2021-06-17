class Solution(object):
    def numSubarrayBoundedMax(self, nums, left, right):
        """
        :type nums: List[int]
        :type left: int
        :type right: int
        :rtype: int
        """
        start, dp = -1, [0] * len(nums)
        for i in range(len(nums)):
            n = nums[i]           
            if left <= n <= right:
                dp[i] = i - start
            elif n > right:
                start = i
            elif n < left and i > 0:
                dp[i] = dp[i - 1]
        return sum(dp)
    