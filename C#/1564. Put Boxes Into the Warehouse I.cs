/*
 * Link: https://leetcode.com/problems/put-boxes-into-the-warehouse-i/
 * Author: Dung Nguyen Tien (Chris)
*/
public class Solution {
    public int MaxBoxesInWarehouse(int[] boxes, int[] warehouse) {
        Array.Sort(boxes, delegate(int a, int b) {
            return b - a;
        });
        int res = 0;
        
        for (var i = 0; i < boxes.Length && res < warehouse.Length; i++) {
            if (boxes[i] <= warehouse[res]) {
                res++;
            }
        }
        
        return res;
    }
}