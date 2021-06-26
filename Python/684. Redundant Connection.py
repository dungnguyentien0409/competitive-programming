class Solution(object):
    def findRedundantConnection(self, edges):
        """
        :type edges: List[List[int]]
        :rtype: List[int]
        """
        def getParent(x):
            if x not in parent:
                return x
            return getParent(parent[x])
        
        def union(x, y):
            parentX = getParent(x)
            parentY = getParent(y)
            if parentX == parentY: 
                return False
            parent[parentY] = parentX
            return True
        
        parent = {}
        for s, d in edges:
            if not union(s, d):
                return [s, d]
        