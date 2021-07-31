public class Solution {
    public int Trap(int[] height) {
        int res = 0;
        var st = new Stack<int>();
        int i = 0;
        
        while(i < height.Length) {
            if (st.Count == 0 || height[st.Peek()] >= height[i]) {
                st.Push(i++);
            }
            else {
                int right = height[i];
                int mid = height[st.Pop()];
                
                if(st.Count == 0) continue;
                
                int left = height[st.Peek()];
                
                int h = Math.Min(left, right) - mid;
                int w = i - st.Peek() - 1;
                
                res += h * w;
            }
        }
        
        return res;
    }
}