# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution(object):
    def findLeaves(self, root):
        """
        :type root: TreeNode
        :rtype: List[List[int]]
        """
        def Traversal(node):
            if node is None:
                return 0
            height = 1 + max(Traversal(node.left), Traversal(node.right))
            
            map[height].append(node.val)
            return height
        map = defaultdict(list)
        Traversal(root)
        return map.values()
        