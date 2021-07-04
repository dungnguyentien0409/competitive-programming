class Solution(object):
    def countVowelPermutation(self, n):
        """
        :type n: int
        :rtype: int
        """
        map, res = {'a': 1, 'e': 1, 'i': 1, 'o': 1, 'u': 1}, 5
        for i in range(n - 1):
            cur = { 'a': 0, 'e': 0, 'i': 0, 'o': 0, 'u': 0 }
            cur['a'] = map['e']
            cur['e'] = map['a'] + map['i']
            cur['i'] = map['a'] + map['e'] + map['o'] + map['u']
            cur['o'] = map['i'] + map['u']
            cur['u'] = map['a']
            res = cur['a'] + cur['e'] + cur['i'] + cur['o'] + cur['u']
            map = cur
        return res % (pow(10, 9) + 7)
            
        