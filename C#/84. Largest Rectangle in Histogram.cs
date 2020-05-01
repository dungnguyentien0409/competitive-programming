/*
 * Link: https://leetcode.com/problems/largest-rectangle-in-histogram/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var st = new Stack<int>();
        var f_area = 0;
        var i = 0;
        
        while(i < heights.Length) {
            if (st.Count == 0 || heights[st.Peek()] < heights[i]) {
                st.Push(i++);
            }
            else {
                var height = heights[st.Pop()];
                var width = st.Count > 0 ? i - st.Peek() - 1 : i;
                
                f_area = Math.Max(f_area, height * width);
            }
        }
        
        while(st.Count > 0) {
            var height = heights[st.Pop()];
            var width = st.Count > 0 ? i - st.Peek() - 1: i;

            f_area = Math.Max(f_area, height * width);
        }
        
        return f_area;
    }
}