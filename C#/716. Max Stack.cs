/*
 * Link: https://leetcode.com/problems/max-stack/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class MaxStack {
    Stack<int> st;
    Stack<int> max;
    /** initialize your data structure here. */
    public MaxStack() {
        st = new Stack<int>();
        max = new Stack<int>();
    }
    
    public void Push(int x) {
        st.Push(x);
        
        if (max.Count == 0) {
            max.Push(x);
        }
        else {
            max.Push(Math.Max(x, max.Peek()));
        }
    }
    
    public int Pop() {
        max.Pop();
        
        return st.Pop();
    }
    
    public int Top() {
        return st.Peek();
    }
    
    public int PeekMax() {
        return max.Peek();
    }
    
    public int PopMax() {
        var tmp = new Stack<int>();
        
        while(st.Peek() != max.Peek()) {
            max.Pop();
            tmp.Push(st.Pop());
        }
        
        st.Pop();
        var val = max.Pop();
        
        while(tmp.Count > 0) Push(tmp.Pop());
        
        return val;
    }
}

/**
 * Your MaxStack object will be instantiated and called as such:
 * MaxStack obj = new MaxStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.PeekMax();
 * int param_5 = obj.PopMax();
 */