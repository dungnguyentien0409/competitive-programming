/*
 * Link: https://leetcode.com/problems/number-of-recent-calls/
 * Author: Dung Nguyen Tien (Chris)
*/

public class RecentCounter {
    Queue<int> counter;
    
    public RecentCounter() {
        counter = new Queue<int>();    
    }
    
    public int Ping(int t) {
        while(counter.Count > 0 && counter.Peek() < t - 3000) {
            counter.Dequeue();
        }
        
        counter.Enqueue(t);
        
        return counter.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */