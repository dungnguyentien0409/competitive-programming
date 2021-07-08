class Solution(object):
    def reverseWords(self, s):
        """
        :type s: List[str]
        :rtype: None Do not return anything, modify s in-place instead.
        """
        def reverse(start, end):
            while start < end:
                s[start], s[end] = s[end], s[start]
                start += 1
                end -= 1
        begin, wLen = 0, len(s)
        reverse(0, wLen - 1)
        for i in range(wLen):
            if s[i] == ' ':
                reverse(begin, i - 1)
                begin = i + 1
            elif i == wLen - 1:
                reverse(begin, i)
        return s