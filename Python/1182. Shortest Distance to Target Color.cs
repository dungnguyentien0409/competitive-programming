class Solution(object):
    def shortestDistanceColor(self, colors, queries):
        """
        :type colors: List[int]
        :type queries: List[List[int]]
        :rtype: List[int]
        """
        map1 = self.nearest(colors, 1)
        map2 = self.nearest(colors, 2)
        map3 = self.nearest(colors, 3)
        res = []
        
        for q in queries:
            if q[1] == 1:
                res.append(map1[q[0]])
            elif q[1] == 2:
                res.append(map2[q[0]])
            else:
                res.append(map3[q[0]])
        
        return res
        
    def nearest(self, colors, number):
        size = len(colors)
        res = [size] * size
        
        curMin = size
        for i in range(size):
            if colors[i] == number: 
                curMin = 0;
                
            res[i] = curMin
            
            if curMin != size: curMin += 1
        
        curMin = len(colors)
        for i in range(size - 1, -1, -1):
            if colors[i] == number: 
                curMin = 0;
                
            res[i] = min(curMin, res[i])
            
            if res[i] == size: res[i] = -1
            if curMin != size: curMin += 1
            
        
        return res
        