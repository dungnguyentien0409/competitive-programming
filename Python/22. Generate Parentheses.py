class Solution(object):
    def generateParenthesis(self, n):
        """
        :type n: int
        :rtype: List[str]
        """
        def backtrack(res, cur, op, cp):
            if op == cp == 0: 
                if len(cur) > 0: res.append(cur)
                return
            if op == 0:
                backtrack(res, cur + ")", op, cp - 1)
            elif op == cp:
                backtrack(res, cur + "(", op - 1, cp)
            else:
                backtrack(res, cur + "(", op - 1, cp)
                backtrack(res, cur + ")", op, cp - 1)
        res = []
        backtrack(res, "", n, n)
        return res
        