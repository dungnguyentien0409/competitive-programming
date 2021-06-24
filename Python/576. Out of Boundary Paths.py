class Solution(object):
    def findPaths(self, m, n, maxMove, startRow, startColumn):
        """
        :type m: int
        :type n: int
        :type maxMove: int
        :type startRow: int
        :type startColumn: int
        :rtype: int
        """
        cache = {}
        def dfs(m, n, x, y, maxMove):
            if (x, y, maxMove) in cache:
                return cache[(x, y, maxMove)]
            if x < 0 or y < 0 or x == m or y == n: 
                return 1
            if maxMove == 0:
                return 0
            res = 0
            for nx, ny in [(x - 1, y), (x + 1, y), (x, y - 1), (x, y + 1)]:
                res += dfs(m, n, nx, ny, maxMove - 1)
            cache[(x, y, maxMove)] = res
            return res
        return dfs(m, n, startRow, startColumn, maxMove) % (pow(10, 9) + 7)