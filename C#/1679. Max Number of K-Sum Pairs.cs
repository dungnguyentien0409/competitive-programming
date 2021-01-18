/*
 * Link: https://leetcode.com/problems/max-number-of-k-sum-pairs/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxOperations(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        int res = 0;
        
        foreach(var n in nums) {
            if (map.ContainsKey(k - n)) {
                res++;
                
                map[k - n]--;
                if (map[k - n] == 0) {
                    map.Remove(k - n);
                }
            }
            else {
                if (!map.ContainsKey(n)) map.Add(n, 0);
                
                map[n]++;
            }
        }
        
        return res;
    }
}