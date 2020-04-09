/*
 * Link: https://leetcode.com/problems/next-greater-element-i/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var map = new Dictionary<int, int>();
        var st = new Stack<int>();
        
        foreach(var n in nums2) {
            while(st.Count > 0 && st.Peek() < n) {
                map.Add(st.Pop(), n);
            }
            
            st.Push(n);
        }
        
        var result = new int[nums1.Length];
        for (var i = 0; i < nums1.Length; i++) {
            var number = nums1[i];
            result[i] = map.ContainsKey(number) ? map[number] : -1;
        }
        
        return result;
    }
}