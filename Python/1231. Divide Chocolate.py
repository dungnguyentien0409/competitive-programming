class Solution(object):
    def maximizeSweetness(self, sweetness, k):
        """
        :type sweetness: List[int]
        :type k: int
        :rtype: int
        """
        def check(cur_sweetness):
            count, sum = 0, 0
            for s in sweetness:
                sum += s
                if sum >= cur_sweetness:
                    sum = 0
                    count += 1
            return count > k
        low, high = min(sweetness), sum(sweetness)
        while low < high:
            mid = low + (high - low + 1) // 2
            if check(mid):
                low = mid
            else:
                high = mid - 1
        return low

            
                