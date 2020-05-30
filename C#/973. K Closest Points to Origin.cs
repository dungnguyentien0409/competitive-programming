/*
 * Link: https://leetcode.com/problems/k-closest-points-to-origin/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[][] KClosest(int[][] points, int K) {
        var list = new List<int[]>();
        
        foreach(var p in points) {
            var index = BinarySearch(list, p);
            
            list.Insert(index, p);
            
            while(list.Count > K) list.RemoveAt(list.Count - 1);
        }
        
        return list.ToArray();
    }
    
    public int BinarySearch(List<int[]> list, int[] p) {
        if (list.Count == 0) return 0;
        
        var d = GetDistance(p);
        
        int left = 0, right = list.Count - 1;
        
        while(left < right) {
            var mid = (left + right) / 2;
            var dMid = GetDistance(list[mid]);
            
            if (dMid < d) {
                left = mid + 1;
            }
            else right = mid;
        }
        
        if (GetDistance(list[left]) < d) return left + 1;
        return left;
    }
    
    public int GetDistance(int[] point) {
        int x = point[0];
        int y = point[1];
        
        return x * x + y * y;
    }
}