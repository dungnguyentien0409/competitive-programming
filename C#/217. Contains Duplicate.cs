/*
 * Link: https://leetcode.com/problems/contains-duplicate/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var set = new HashSet<int>();
        
        foreach(var n in nums) {
            if (set.Contains(n)) return true;
            
            set.Add(n);
        }
        
        return false;
    }
}