/*
 * Link: https://leetcode.com/problems/combination-sum/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var res = new List<IList<int>>();
        
        backtrack(res, new List<int>(), candidates, target, 0, 0);
        
        return res;
    }
    
    public void backtrack(List<IList<int>> res, List<int> current, int[] candidates, int target, int sum, int start) {
        if (sum > target) return;
        if (sum == target) {
            res.Add(new List<int>(current));
            
            return;
        }
        
        for (var i = start; i < candidates.Length; i++) {
            var n = candidates[i];
            
            current.Add(n);
            backtrack(res, current, candidates, target, sum + n, i);
            current.RemoveAt(current.Count - 1);
        }
    }
}