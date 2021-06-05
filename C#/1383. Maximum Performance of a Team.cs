/*
 * Link: https://leetcode.com/problems/maximum-performance-of-a-team/
 * Author: Dung Nguyen Tien (Chris)
*/
public class Solution {
    public int MaxPerformance(int n, int[] speed, int[] efficiency, int k) {
        var list = new List<int[]>();
        var MAX = (long)Math.Pow(10, 9) + 7;
        for (var i = 0; i < n; i++) {
            list.Add(new int[2] { speed[i], efficiency[i] });
        }
        list.Sort(delegate(int[] e1, int[] e2){
            return e2[1] - e1[1];
        });
        
        var order = new Heap();
        long sum = 0;
        long res = 0;
        for(var i = 0; i < list.Count; i++) {
            var e = list[i];
            
            sum += e[0];
            order.Insert(e);
            
            if (order.Count() > k) {
                sum -= order.Pop()[0];
            }
            
            res = Math.Max(res, sum * e[1]);
        }
        
        return (int)(res % MAX);
    }
    
}

public class Heap {
    List<int[]> heap;
    
    public Heap() {
        heap = new List<int[]>();
    }
    
    public int Count() {
        return heap.Count;
    }
    
    public void Insert(int[] e) {
        heap.Add(e);
        Heapify(heap.Count - 1);
    }
    
    public int[] Pop() {
        var res = heap[0];
        
        Swap(0, heap.Count - 1);
        heap.RemoveAt(heap.Count - 1);
        Heapify(heap.Count, 0);        
        
        return res;
    }
    
    public void Heapify(int index) {
        int parent = (index - 1) / 2;
        
        if (parent < 0) return;
        
        if (heap[parent][0] > heap[index][0]) {
            Swap(parent, index);
            
            Heapify(parent);
        }
    }
    
    public void Heapify(int len, int index) {
        int left = 2 * index + 1;
        int right = 2 * index + 2;
        int imin = index;
        
        if (left < len && heap[left][0] < heap[imin][0]) {
            imin = left;
        }
        if (right < len && heap[right][0] < heap[imin][0]) {
            imin = right;
        }
        
        if (imin != index) {
            Swap(imin, index);
            Heapify(len, imin);
        }
    }
    
    public void Swap(int x, int y) {
        var tmp = heap[x];
        heap[x] = heap[y];
        heap[y] = tmp;
    }
}