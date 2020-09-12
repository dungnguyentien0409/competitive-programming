/*
 * Link: https://leetcode.com/problems/combination-sum-iii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var res = new List<IList<int>>();
        
        backtrack(res, new List<int>(), 0, k, n, 1);
        
        return res;
    }
    
    public void backtrack(List<IList<int>> res, List<int> current, int c_sum, int k, int n, int start) {
        if (current.Count == k) {
            if (c_sum == n) {
                res.Add(new List<int>(current));
            }
            
            return;
        }
        
        for (var i = start; i <= 9; i++) {
            c_sum += i;
            current.Add(i);
            
            backtrack(res, current, c_sum, k, n, i + 1);
            
            c_sum -= i;
            current.RemoveAt(current.Count - 1);
        }
    }
}