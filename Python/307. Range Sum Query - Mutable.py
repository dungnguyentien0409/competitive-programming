class Node:
    def __init__(self, start, end, val = 0):
        self.start = start
        self.end = end
        self.val = val
        self.left = None
        self.right = None
        
class NumArray(object):

    def __init__(self, nums):
        """
        :type nums: List[int]
        """
        def createNode(l, r):
            if l > r:  
                return None
            if l == r: 
                return Node(l, r, nums[l])
            else:
                mid = (l + r) // 2
                n = Node(l, r)
                n.left = createNode(l, mid)
                n.right = createNode(mid + 1, r)
                n.val = n.left.val + n.right.val
                return n
        self.root = createNode(0, len(nums) - 1)
    def update(self, index, val):
        """
        :type index: int
        :type val: int
        :rtype: None
        """
        def goUpdate(node, i, val):
            if i == node.start == node.end:
                node.val = val
            else:
                mid = (node.start + node.end) // 2
                if i <= mid:
                    goUpdate(node.left, i, val)
                else:
                    goUpdate(node.right, i, val)
                node.val = node.left.val + node.right.val
        goUpdate(self.root, index, val)
        

    def sumRange(self, left, right):
        """
        :type left: int
        :type right: int
        :rtype: int
        """
        def sum(node, l, r):
            if node.start == l and node.end == r:
                return node.val
            mid = (node.start + node.end) // 2
            if mid >= r:
                return sum(node.left, l, r)
            elif l > mid:
                return sum(node.right, l, r)
            return sum(node.left, l, mid) + sum(node.right, mid + 1, r)
        return sum(self.root, left, right)
        


# Your NumArray object will be instantiated and called as such:
# obj = NumArray(nums)
# obj.update(index,val)
# param_2 = obj.sumRange(left,right)