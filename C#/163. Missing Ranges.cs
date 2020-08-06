/*
 * Link: https://leetcode.com/problems/missing-ranges/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<string> FindMissingRanges(int[] nums, int lower, int upper) {
        var res = new List<string>();
        
        foreach(var n in nums) {
            if (n > lower) {
                res.Add(Format(lower, n - 1));
            }
            if (n == upper) return res;
            
            lower = n + 1;
        }
        
        if (lower <= upper) {
            res.Add(Format(lower, upper));
        }
        
        return res;
    }
    
    public string Format(int a, int b) {
        if (a == b) return a.ToString();
        
        return a.ToString() + "->" + b.ToString();
    }
}