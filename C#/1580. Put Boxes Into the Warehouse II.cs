/*
 * Link: https://leetcode.com/problems/put-boxes-into-the-warehouse-ii/
 * Author: Dung Nguyen Tien (Chris)
*/
public class Solution {
    public int MaxBoxesInWarehouse(int[] boxes, int[] warehouse) {
        Array.Sort(boxes, delegate(int a, int b) {
            return b - a;
        });
        int res = 0;
        
        int left = 0, right = warehouse.Length - 1;
        for(var i = 0; i < boxes.Length && left <= right; i++) {
            if (boxes[i] <= warehouse[left]) {
                left++;
                res++;
            }
            else if (boxes[i] <= warehouse[right]) {
                right--;
                res++;
            }
        }
        
        return res;
    }
}