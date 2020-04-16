/*
 * Link: https://leetcode.com/problems/kth-largest-element-in-an-array/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var heap = new MaxHeap(nums);
        var ith = 1;
        
        while(ith < k) {
            ith++;
            var item = heap.Poll();
        }
        
        return heap.Peek();
    }
}

public class MaxHeap {
    public List<int> heap;
    
    public MaxHeap(int[] nums) {
        heap = new List<int>(nums);
        BuildHeap();
    }
    
    public int Count() { return heap.Count; }
    
    public int Peek() {
        return heap[0];
    }
    
    public int Poll() {
        var item = heap[0];
        
        swap(0, heap.Count - 1);
        heap.RemoveAt(heap.Count - 1);
        heapify(0);
        
        return item;
    }
    
    public void BuildHeap() {
        for(var i = heap.Count / 2 - 1; i >= 0; i--) {
            heapify(i);
        }
    }
    
    public void heapify(int pos) {
        var left = 2 * pos + 1;
        var right = 2 * pos + 2;
        var max = pos;
        
        if (left < heap.Count && heap[max] < heap[left]) max = left;
        if (right < heap.Count && heap[max] < heap[right]) max = right;
        
        if (max != pos) {
            swap(max, pos);
            heapify(max);
        }
    }
    
    public void swap(int x, int y) {
        if (x == y) return;
        
        var tmp = heap[x];
        heap[x] = heap[y];
        heap[y] = tmp;
    }
}