from sortedcontainers import SortedList
class Solution(object):
    def maxSumSubmatrix(self, matrix, k):
        """
        :type matrix: List[List[int]]
        :type k: int
        :rtype: int
        """
        res , row, col = -sys.maxsize - 1, len(matrix), len(matrix[0])
        for r in range(row):
            arr = [0] * col
            for r1 in range(r, row):
                for c in range(col):
                    arr[c] += matrix[r1][c]
                res = max(res, self.findMax(arr, k))
        return res
    def findMax(self, arr, k):
        res, sum, sorted = -sys.maxsize - 1, 0, SortedList([0])
        for n in arr:
            sum += n
            left = self.findLeft(sorted, sum - k)
            if left != None:
                res = max(res, sum - left)
            sorted.add(sum)
        return res
    def findLeft(self, sorted, val):
        index = sorted.bisect_left(val)
        return sorted[index] if index < len(sorted) else None