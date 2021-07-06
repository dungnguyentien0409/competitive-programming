class Solution(object):
    def minSetSize(self, arr):
        """
        :type arr: List[int]
        :rtype: int
        """
        map = defaultdict()
        for c in arr:
            map[c] = 1 if c not in map else map[c] + 1
        pq, count, res = [], len(arr), 0
        for c in map:
            heapq.heappush(pq, -map[c])
        while count > len(arr) / 2:
            count += heapq.heappop(pq)
            res += 1
        return res
            