class Solution(object):
    def lengthOfLIS(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        def binarySearch(arr, n):
            if len(arr) == 0: return 0
            
            left, right = 0, len(arr) - 1
            while(left < right):
                mid = (left + right) / 2
                if arr[mid] < n: 
                    left = mid + 1
                else: 
                    right = mid
            if arr[left] < n: 
                return left + 1
            return left
        res, ends = 0, []
        for n in nums:
            index = binarySearch(ends, n)
            res = max(res, index + 1)
            if index >= len(ends): 
                ends.append(n)
            else:
                ends[index] = n
        return res
            
            
        