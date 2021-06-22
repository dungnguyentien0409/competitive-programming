class Solution(object):
    def numMatchingSubseq(self, S, words):
        def isMatch(w, i, i_d):
            if i == len(w):
                return True
            curList = dict[w[i]]
            if len(curList) == 0 or i_d > curList[-1]: 
                return False
            index = curList[bisect_left(curList, i_d)]
            return isMatch(w, i + 1, index + 1)
        
        sum, dict = 0, defaultdict(list)
        for i in range(len(S)):
            dict[S[i]].append(i)
        for w in words:
            if isMatch(w, 0, 0):
                sum += 1
        return sum
        