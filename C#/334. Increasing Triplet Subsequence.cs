/*
 * Link: https://leetcode.com/problems/increasing-triplet-subsequence/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int n1 = Int32.MaxValue, n2 = Int32.MaxValue;
        
        foreach(var n in nums) {
            if (n <= n1) {
                n1 = n;
            }
            else if (n <= n2) {
                n2 = n;
            }
            else {
                return true;
            }
        }
        
        return false;
    }
}