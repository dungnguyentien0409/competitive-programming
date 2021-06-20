class Solution(object):
    def swimInWater(self, grid):
        """
        :type grid: List[List[int]]
        :rtype: int
        """
        pq = [(grid[0][0], 0, 0)]
        visited, leng, res = set([(0, 0)]), len(grid), 0
        while len(pq) > 0:
            height, x, y = heapq.heappop(pq)
            res = max(res, height)
            if x == y == leng - 1:
                return res
            else:
                for i, j in [(x - 1, y), (x + 1, y), (x, y - 1), (x, y + 1)]:
                    if 0 <= i < leng and 0 <= j < leng and (i, j) not in visited:
                        visited.add((i, j))
                        heapq.heappush(pq, (grid[i][j], i, j))
            
        return -1
        