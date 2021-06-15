class Solution(object):
    def makesquare(self, matchsticks):
        """
        :type matchsticks: List[int]
        :rtype: bool
        """
        if (not matchsticks or sum(matchsticks) % 4 != 0): return False

        matchsticks.sort(reverse=True)
        target = sum(matchsticks) / 4
    
        def dfs(cur, index, matchsticks):
            if index == len(matchsticks):
                return True
            if index > len(matchsticks):
                return False
            for i in range(4):
                if (cur[i] + matchsticks[index] > target): 
                    continue
                cur[i] += matchsticks[index]
                if dfs(cur, index + 1, matchsticks): 
                    return True
                cur[i] -= matchsticks[index]
            return False
        
        return dfs([0,0,0,0], 0, matchsticks)