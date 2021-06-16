class Solution(object):
    def checkInclusion(self, s1, s2):
        """
        :type s1: str
        :type s2: str
        :rtype: bool
        """
        map, start, end, d = {}, 0, 0, len(s1)
        for c in s1:
                map[c] = 1 if c not in map else map[c] + 1
        while end < len(s2):
            if s2[end] in map:
                if map[s2[end]] > 0:
                    d -= 1
                map[s2[end]] -= 1
            end += 1
            while d == 0:
                if end - start == len(s1):
                    return True
                if s2[start] in map:
                    if map[s2[start]] == 0 :
                        d += 1
                    map[s2[start]] += 1
                start += 1
        return False
        