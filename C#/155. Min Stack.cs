/*
 * Link: https://leetcode.com/problems/min-stack/
 * Author: Dung Nguyen Tien (Chris)
*/

public class MinStack {

    /** initialize your data structure here. */
    Stack<Element> st;
    public MinStack() {
        st = new Stack<Element>();
    }
    
    public void Push(int x) {
        var min = x;
        
        if (st.Count > 0) {
            Console.WriteLine(min + " " + st.Peek().GetMinValue());
            min = Math.Min(min, st.Peek().GetMinValue());
        }
        
        st.Push(new Element(x, min));
    }
    
    public void Pop() {
        st.Pop();
    }
    
    public int Top() {
        return st.Peek().GetValue();
    }
    
    public int GetMin() {
        return st.Peek().GetMinValue();
    }
}

public class Element {
    int val;
    int min;
    
    public Element(int v, int m) {
        this.val = v;
        this.min = m;
    }
    
    public int GetValue() {
        return this.val;
    }
    
    public int GetMinValue() {
        return this.min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */