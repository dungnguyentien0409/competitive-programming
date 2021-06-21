import sys

class Solution(object):
    def findMedianSortedArrays(self, nums1, nums2):
        """
        :type nums1: List[int]
        :type nums2: List[int]
        :rtype: float
        """
        a, b = sorted((nums1, nums2), key=len)
        len1, len2 = len(a), len(b)
        low, high = 0, len1
        while(low <= high):
            x = (low + high) // 2
            y = (len1 + len2 + 1) // 2 - x
            xmaxLeft = a[x - 1] if x > 0 else -sys.maxint - 1
            xminRight = a[x] if x < len1 else sys.maxint
            ymaxLeft = b[y - 1] if y > 0 else -sys.maxint - 1
            yminRight = b[y] if y < len2 else sys.maxint
            if (xmaxLeft <= yminRight and ymaxLeft <= xminRight):
                if (len1 + len2) % 2 == 0:
                    print("{} {}".format(xmaxLeft, xminRight))
                    print("{} {}".format(ymaxLeft, yminRight))
                    return (max(xmaxLeft, ymaxLeft) + min(xminRight, yminRight)) / 2.0
                else:
                    return max(xmaxLeft, ymaxLeft)
            elif xmaxLeft > yminRight:
                high = x - 1
            else:
                low = x + 1
        