class Solution(object):
    def kthSmallest(self, matrix, k):
        """
        :type matrix: List[List[int]]
        :type k: int
        :rtype: int
        """
        rows, cols = len(matrix), len(matrix[0])
        low, high = matrix[0][0], matrix[-1][-1] + 1
        while low < high:
            mid = low + (high - low) // 2
            count, j = 0, cols - 1
            for i in range(rows):
                while j >= 0 and matrix[i][j] > mid:
                    j -= 1
                count += (j + 1)
            if count < k:
                low = mid + 1
            else:
                high = mid
        return low
        