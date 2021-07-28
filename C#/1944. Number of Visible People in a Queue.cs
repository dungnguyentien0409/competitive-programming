public class Solution {
    public int[] CanSeePersonsCount(int[] heights) {
        int len = heights.Length;
        var st = new Stack<int>();
        var res = new int[len];
        
        for(var i = 0; i < len; i++) {
            while(st.Count > 0 && heights[st.Peek()] <= heights[i]) {
                res[st.Pop()]++;
            }
            
            if (st.Count > 0) {
                res[st.Peek()]++;
            }
            
            st.Push(i);
        }
        
        return res;
    }
}