class Solution:
    def largestRectangleArea(self, heights: List[int]) -> int:
        i, res, st = 0, 0, []
        while i < len(heights):
            if len(st) == 0 or heights[st[-1]] < heights[i]:
                st.append(i)
                i += 1 
            else:
                h = heights[st.pop()]
                w = i if len(st) == 0 else i - 1 - st[-1]
                res = max(res, h * w)
        while len(st) > 0:
            h = heights[st.pop()]
            w = i if len(st) == 0 else i - 1 - st[-1]
            res = max(res, h * w)
        return res