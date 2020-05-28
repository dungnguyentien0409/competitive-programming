/*
 * Link: https://leetcode.com/problems/maximum-number-of-events-that-can-be-attended/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxEvents(int[][] events) {
        Array.Sort(events, delegate(int[] a, int[] b) {
            if (a[0] == b[0]) return a[1] - b[1];
            
            return a[0] - b[0];
        });
        var heap = new MinHeap();
        int i = 0, count = 0;
        
        for (var d = 1; d <= 100000; d++) {
            while(!heap.IsEmpty() && heap.Peek() < d) {
                heap.RemoveMin();
            }
            
            while (i < events.Length && events[i][0] == d) {
                heap.insert(events[i][1]);
                i++;
            }
            
            if (!heap.IsEmpty()) {
                heap.RemoveMin();
                count++;
            }
        }
        
        return count;
    }
}

public class MinHeap {
    public List<int> heap;
    public MinHeap() {
        heap = new List<int>();
    }
    
    public bool IsEmpty() {
        return heap.Count == 0;
    }
    
    public int Peek() {
        return heap[0];
    }
    
    public void RemoveMin() {
        int first = 0, last = heap.Count - 1;
        
        swap(first, last);
        heap.RemoveAt(last);
        
        heapify(first);
    }
    
    public void buildHeap() {
        for(var i = heap.Count / 2; i >= 0; i--){
            heapify(i);
        }
    }
    
    public void heapify(int pos) {
        var left = 2 * pos + 1;
        var right = 2 * pos + 2;
        var min = pos;
        
        if (left < heap.Count && heap[left] < heap[min]) min = left;
        if (right < heap.Count && heap[right] < heap[min]) min = right;
        
        if (min != pos) {
            swap(pos, min);
            heapify(min);
        }
    }
    
    public void heapifyBtm(int pos) {
        if (pos <= 0) return;
        
        var parent = (pos - 1) / 2;

        if (heap[pos] < heap[parent]) {
            swap(pos, parent);
        }
        
        heapifyBtm(parent);
    }
    
    public void insert(int val) {
        heap.Add(val);
        
        heapifyBtm(heap.Count - 1);
    }
    
    public void swap(int x, int y) {
        if (x == y) return;
        
        var tmp = heap[x];
        heap[x] = heap[y];
        heap[y] = tmp;
    }
}