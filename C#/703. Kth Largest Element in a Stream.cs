/*
 * Link: https://leetcode.com/problems/kth-largest-element-in-a-stream/
 * Author: Dung Nguyen Tien (Chris)
*/

public class KthLargest {
    MinHeap minHeap;
    
    public KthLargest(int k, int[] nums) {
        minHeap = new MinHeap(k, nums);
    }
    
    public int Add(int val) {
        var res = minHeap.Add(val);
        
        return res;
    }
}

public class MinHeap {
    public int[] heap;
    
    public MinHeap(int k, int[] nums) {
        heap = new int[k];
        Array.Fill(heap, Int32.MinValue);
        
        foreach(var n in nums) {
            var check = Add(n);
            Console.WriteLine(check);
        }
    }
    
    public int Add(int val) {
        if (val > heap[0]) {
            heap[0] = val;
            HeapifyFromTop(0);
        }
        
        return heap[0];
    }
    
    public void HeapifyFromTop(int pos) {
        var left = 2 * pos + 1;
        var right = 2 * pos + 2;
        var smallest = pos;
        
        if (left < heap.Length && heap[smallest] > heap[left]) {
            smallest = left;
        }
        if (right < heap.Length && heap[smallest] > heap[right]) {
            smallest = right;
        }
        
        if (smallest == left) {
            Swap(pos, left);
            HeapifyFromTop(left);
        }
        if (smallest == right) {
            Swap(pos, right);
            HeapifyFromTop(right);
        }
    }
    
    public void Swap(int x, int y) {
        if (x == y) return;
        
        var tmp = heap[x];
        heap[x] = heap[y];
        heap[y] = tmp;
    }
}
/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */