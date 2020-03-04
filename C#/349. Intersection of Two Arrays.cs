/*
 * Link: https://leetcode.com/problems/intersection-of-two-arrays/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var s1 = new HashSet<int>();
        var s2 = new HashSet<int>();
        
        foreach(var n in nums1) {
            if (!s1.Contains(n)) s1.Add(n);
        }
        
        foreach(var n in nums2) {
            if (s1.Contains(n) && !s2.Contains(n)) s2.Add(n);
        }
        
        return s2.ToArray();
    }
}