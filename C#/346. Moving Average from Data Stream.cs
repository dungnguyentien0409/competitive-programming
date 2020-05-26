/*
 * Link: https://leetcode.com/problems/moving-average-from-data-stream/
 * Author: Dung Nguyen Tien (Chris)
*/

public class MovingAverage {

    /** Initialize your data structure here. */
    int size, sum;
    Queue<int> window;
    
    public MovingAverage(int size) {
        this.size = size;
        sum = 0;
        window = new Queue<int>();
    }
    
    public double Next(int val) {
        int prev = 0;
        
        if (window.Count == size) {
            prev = window.Dequeue();    
        }
        
        sum -= prev;
        window.Enqueue(val);
        sum += val;
        
        return sum * 1.0 / (window.Count);
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */