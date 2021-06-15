class Solution(object):
    def maximumUnits(self, boxTypes, truckSize):
        """
        :type boxTypes: List[List[int]]
        :type truckSize: int
        :rtype: int
        """
        def sortSecond(val): return val[1]
        boxTypes.sort(key = sortSecond, reverse = True)
        
        cur, val = 0, 0;
        for item in boxTypes:
            n = truckSize - cur if truckSize - cur <= item[0] else item[0]
                
            cur += n
            val += (n * item[1])
            
        return val
        