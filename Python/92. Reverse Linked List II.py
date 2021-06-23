# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution(object):
    def reverseBetween(self, head, left, right):
        """
        :type head: ListNode
        :type left: int
        :type right: int
        :rtype: ListNode
        """
        dummy = ListNode(0)
        dummy.next = head
        prev = dummy
        for i in range(left - 1): 
            prev = prev.next 
        cur, next = prev.next, prev.next.next
        for i in range(right - left):
            cur.next = next.next
            next.next = prev.next
            prev.next = next
            next = cur.next
        return dummy.next
        
        