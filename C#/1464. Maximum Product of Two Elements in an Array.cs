/*
 * Link: https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxProduct(int[] nums) {
        int max1 = Int32.MinValue, max2 = Int32.MinValue;
        
        foreach(var n in nums) {
            if (n > max1) {
                max2 = max1;
                max1 = n;
            }
            else if (n > max2) {
                max2 = n;
            }
        }
        
        return (max1 - 1) * (max2 - 1);
    }
}