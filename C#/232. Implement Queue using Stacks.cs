// Link: https://leetcode.com/problems/implement-queue-using-stacks/submissions/
// Author: Dung Nguyen Tien (Chris)

public class MyQueue {
    Stack<int> back;
    Stack<int> front;
    /** Initialize your data structure here. */
    public MyQueue() {
        back = new Stack<int>();
        front = new Stack<int>();
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        back.Push(x);
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        while(back.Count() > 0) front.Push(back.Pop());
        
        var item = front.Pop();
        
        while(front.Count() > 0) back.Push(front.Pop());
        
        return item;
    }
    
    /** Get the front element. */
    public int Peek() {
        while(back.Count() > 0) front.Push(back.Pop());
        
        var item = front.Peek();
        
        while(front.Count() > 0) back.Push(front.Pop());
        
        return item;
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return back.Count() == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */