class Solution(object):
    def longestOnes(self, nums, k):
        """
        :type nums: List[int]
        :type k: int
        :rtype: int
        """
        start, end, count, maxLen = 0, 0, 0, 0
        while end < len(nums):
            if nums[end] == 0:
                count += 1
            end += 1
            while(count > k):
                if nums[start] == 0:
                    count -= 1
                start += 1
            maxLen = max(maxLen, end - start)
        return maxLen