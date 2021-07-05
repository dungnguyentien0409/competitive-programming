class Solution(object):
    def matrixReshape(self, mat, r, c):
        """
        :type mat: List[List[int]]
        :type r: int
        :type c: int
        :rtype: List[List[int]]
        """
        rows, cols = len(mat), len(mat[0])
        res = [[0] * c for i in range(r)]
        
        if r * c != rows * cols:
            return mat
        for i in range(r * c):
            res[i // c][i % c] = mat[i // cols][i % cols]
        return res
        