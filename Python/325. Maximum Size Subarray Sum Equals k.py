class Solution(object):
    def maxSubArrayLen(self, nums, k):
        """
        :type nums: List[int]
        :type k: int
        :rtype: int
        """
        res, sum = 0, 0
        map = defaultdict(list)
        map[0] = -1
        for i in range(len(nums)):
            n = nums[i]
            sum += n
            if sum - k in map:
                res = max(res, i - map[sum - k])
            if sum not in map:
                map[sum] = i
        return res