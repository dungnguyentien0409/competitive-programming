class Solution(object):
    def maximalRectangle(self, matrix):
        """
        :type matrix: List[List[str]]
        :rtype: int
        """
        if len(matrix) == 0 or len(matrix[0]) == 0: return 0
        heights = [0] * len(matrix[0])
        res = 0
        for i in range(len(matrix)):
            heights = self.getHeights(heights, matrix, i)
            res = max(res, self.maximalCurrentRectangle(heights))
        return res
    def getHeights(self, heights, matrix, i):
        for j in range(len(heights)):
            if matrix[i][j] == "0":
                heights[j] = 0
            else:
                heights[j] += int(matrix[i][j])
        return heights
    def maximalCurrentRectangle(self, heights):
        res, i, st = 0, 0, []
        while i < len(heights):
            if len(st) == 0 or heights[st[-1]] < heights[i]:
                st.append(i)
                i += 1
            else:
                h = heights[st.pop()]
                w = i if len(st) == 0 else i - st[-1] - 1
                res = max(res, h * w)
        while len(st) > 0:
            h = heights[st.pop()]
            w = i if len(st) == 0 else i - st[-1] - 1
            res = max(res, h * w)
        return res
        