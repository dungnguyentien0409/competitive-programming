/*
 * Link: https://leetcode.com/problems/minimum-cost-to-connect-sticks/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int ConnectSticks(int[] sticks) {
        var heap = BuildHeap(sticks.ToList());
        // Build Heap
        
        
        var cost = 0;
        while(heap.Count > 1) {
            var min1 = GetMin(heap);
            var min2 = GetMin(heap);
            
            cost += (min1 + min2);
            Insert(heap, min1 + min2);
        }
        
        return cost;
    }
    
    public void Insert(List<int> heap, int item) {
        var index = heap.Count;
        heap.Add(item);
        
        while(index > 0) {
            var parent = (index - 1) / 2;
            
            if (heap[index] < heap[parent]) {
                Swap(heap, index, parent);
                index = parent;
            }
            else break;
        }
    }
    
    public int GetMin(List<int> heap) {
        var min = heap[0];
        
        Swap(heap, 0, heap.Count - 1);
        heap.RemoveAt(heap.Count - 1);
        Heapify(heap, 0);
        
        return min;
    }
    
    public List<int> BuildHeap(List<int> list) {
        for (var i = list.Count / 2 - 1; i >= 0; i--) Heapify(list, i);
        
        return list;
    }
    
    public void Heapify(List<int> list, int i) {
        var left = 2 * i + 1;
        var right = 2 * i + 2;
        var min = i;
        
        if (left < list.Count && list[left] < list[min]) min = left;
        if (right < list.Count && list[right] < list[min]) min = right;
        
        if (min != i) {
            Swap(list, i, min);
            Heapify(list, min);
        }
    }
    
    public void Swap(List<int> list, int x, int y) {
        if (x == y) return;
        
        var tmp = list[x];
        list[x] = list[y];
        list[y] = tmp;
    }
}