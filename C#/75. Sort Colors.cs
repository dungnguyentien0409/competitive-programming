/*
 * Link: https://leetcode.com/problems/sort-colors/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public void SortColors(int[] nums) {
        int red = 0, white = 0, blue = nums.Length - 1;
        
        while(white <= blue) {
            if (nums[white] == 0) {
                Swap(nums, red++, white++);
            }
            else if (nums[white] == 1) {
                white += 1;
            }
            else {
                Swap(nums, white, blue);
                blue -= 1;
            }
        }
    }
    
    public void Swap(int[] nums, int x, int y) {
        if (x == y) return;
        
        var tmp = nums[x];
        nums[x] = nums[y];
        nums[y] = tmp;
    }
}