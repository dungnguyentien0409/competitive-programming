/*
 * Link: https://leetcode.com/problems/maximal-rectangle/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaximalRectangle(char[][] matrix) {
        if (matrix.Length == 0 || matrix[0].Length == 0) return 0;
        
        int rows = matrix.Length, cols = matrix[0].Length;
        int f_max = 0;
        int[] height = new int[cols];
        
        Array.Fill(height, 0);
        for (var r = 0; r < rows; r++) {
            var heights = GetHeight(height, matrix[r]);
            
            f_max = Math.Max(f_max, MaxRectangelInDiagram(heights));
        }
        
        return f_max;
    }
    
    public int MaxRectangelInDiagram(int[] heights) {
        var f_max = 0;
        var i = 0;
        var st = new Stack<int>();
        
        while(i < heights.Length) {
            if (st.Count == 0 || heights[st.Peek()] < heights[i]) {
                st.Push(i++);
            }
            else {
                var height = heights[st.Pop()];
                var width = st.Count > 0 ? i - st.Peek() - 1 : i;
                
                f_max = Math.Max(f_max, height * width);
            }
        }
        
        while(st.Count > 0) {
            var height = heights[st.Pop()];
            var width = st.Count > 0 ? i - st.Peek() - 1 : i;

            f_max = Math.Max(f_max, height * width);
        }
        
        return f_max;
    }
    
    public int[] GetHeight(int[] heights, char[] nextLine) {
        var len = heights.Length;
        
        for (var i = 0; i < len; i++) {
            if (nextLine[i] == '1') {
                heights[i] += 1;
            }
            else {
                heights[i] = 0;
            }
        }
        
        return heights;
    }
}