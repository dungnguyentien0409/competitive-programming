# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution(object):
    def buildTree(self, inorder, postorder):
        """
        :type inorder: List[int]
        :type postorder: List[int]
        :rtype: TreeNode
        """
        def construct(iS, iE, pS, pE):
            if pS > pE: return None
            index = inorder.index(postorder[pE])
            node = TreeNode(postorder[pE])
            node.left = construct(iS, index - 1, pS, pS + (index - iS - 1))
            node.right = construct(index + 1, iE, pS + (index - iS), pE - 1)
            return node
        return construct(0, len(inorder) - 1, 0, len(postorder) - 1)
                    