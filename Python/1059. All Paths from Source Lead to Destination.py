class Solution(object):
    def leadsToDestination(self, n, edges, source, destination):
        """
        :type n: int
        :type edges: List[List[int]]
        :type source: int
        :type destination: int
        :rtype: bool
        """
        def dfs(cur, des, visited):
            if cur == des:
                return True
            check = False
            for n in map[cur]:
                if n in visited: return False
                check = True
                visited.add(n)
                if dfs(n, des, visited) == False:
                    return False
                visited.remove(n)
            return check
        
        map, visited = defaultdict(list), set()
        for e in edges:
            map[e[0]].append(e[1])
        visited.add(source)
        if destination in map and len(map[destination]) > 0:
            return False
        return dfs(source, destination, visited)
        
        