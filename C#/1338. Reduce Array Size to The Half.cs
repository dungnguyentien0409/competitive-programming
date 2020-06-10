/*
 * Link: https://leetcode.com/problems/reduce-array-size-to-the-half/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinSetSize(int[] arr) {
        var len = arr.Length;
        var map = new Dictionary<int, int>();
        
        foreach(var n in arr) {
            if (!map.ContainsKey(n)) map.Add(n, 0);
            
            map[n]++;
        }
        
        var heap = new Heap(map);
        
        int sub = 0, count = 0;
        while(sub < len / 2 && heap.heap.Count > 0) {
            var max = heap.GetMax();
            
            sub += max[1];
            count++;
        }
        
        return count;
    }
}

public class Heap {
    public List<int[]> heap;
    
    public Heap(Dictionary<int, int> map) {
        heap = new List<int[]>();
        
        foreach(var item in map) {
            heap.Add(new int[2] { item.Key, item.Value });
        }
        
        BuildHeap();
    }
    
    public void BuildHeap() {
        for (var i = (heap.Count - 1) / 2; i >= 0; i --) {
            Heapify(i);
        }
    }
    
    public int[] GetMax() {
        var res = heap[0];
        
        Swap(0, heap.Count - 1);
        heap.RemoveAt(heap.Count - 1);
        Heapify(0);
        
        return res;
    }
    
    public void Heapify(int pos) {
        var left = pos * 2 + 1;
        var right = pos * 2 + 2;
        var max = pos;
        
        if (left < heap.Count && heap[left][1] > heap[max][1]) {
            max = left;
        }
        if (right < heap.Count && heap[right][1] > heap[max][1]) {
            max = right;
        }
        
        if (max != pos) {
            Swap(pos, max);
            Heapify(max);
        }
    }
    
    public void Swap(int x, int y) {
        if (x == y) return;
        
        var tmp = heap[x];
        heap[x] = heap[y];
        heap[y] = tmp;
    }
}