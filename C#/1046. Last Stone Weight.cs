/*
 * Link: https://leetcode.com/problems/last-stone-weight/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LastStoneWeight(int[] stones) {
        var heap = new Heap(stones);
        
        while(heap.Count() > 1) {
            var max1 = heap.GetMax();
            var max2 = heap.GetMax();
            
            heap.Insert(max1 - max2);
        }
        
        
        // the last only one item
        return heap.GetMax();
    }
}

public class Heap {
    List<int> heap;
    
    public Heap(int[] arr) {
        this.heap = new List<int>(arr);
        BuildHeap();    
    }
    
    public int GetMax() {
        if (this.heap.Count > 0) {
            var item = this.heap[0];
            
            swap(0, Count() - 1);
            this.heap.RemoveAt(Count() - 1);
            
            heapify(0);
            
            return item;
        }
        
        return Int32.MinValue;
    }
    
    public void Insert(int x) {
        this.heap.Add(x);
        
        heapify_btm(Count() - 1);
    }
    
    public void BuildHeap() {
        var len = Count();
        
        for (var i = len / 2 - 1; i >= 0; i--) {
            heapify(i);
        }
    }
    
    // top-down
    public void heapify(int pos) {
        int len = Count();
        int left = GetLeft(pos), right = GetRight(pos);
        int largest = pos;
        
        if (left < len && this.heap[left] > this.heap[largest]) largest = left;
        if (right < len && this.heap[right] > this.heap[largest]) largest = right;
        
        if (largest != pos) {
            swap(pos, largest);
            heapify(largest);
        }
    }
    
    //bottom-up
    public void heapify_btm(int pos) {
        int parent = GetParent(pos);
        
        if (parent >= 0) {
            if (this.heap[pos] > this.heap[parent]) {
                swap(parent, pos);
                
                heapify_btm(parent);
            }
        }
    }
    
    public void swap(int x, int y) {
        if (x == y) return;
        
        var tmp = this.heap[x];
        this.heap[x] = this.heap[y];
        this.heap[y] = tmp;
    }
    
    public int GetLeft(int pos) {
        return 2 * pos + 1;
    }
    
    public int GetRight(int pos) {
        return 2 * pos + 2;
    }
    
    public int GetParent(int pos) {
        return (pos - 1) / 2;
    }
    
    public int Count() {
        return this.heap.Count();
    }
}