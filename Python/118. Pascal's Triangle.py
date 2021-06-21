class Solution(object):
    def generate(self, numRows):
        """
        :type numRows: int
        :rtype: List[List[int]]
        """
        res = [[1]]
        cur, prev = [1], []
        if numRows == 1:
            return res
        for r in range(2, numRows + 1):
            prev = cur
            cur = []
            for c in range(r):
                leftVal = 0 if c == 0 else prev[c - 1]
                curVal = prev[c] if c < len(prev) else 0
                cur.append(leftVal + curVal)
            res.append(cur)
        return res