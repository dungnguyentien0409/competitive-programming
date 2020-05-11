/*
 * Link: https://leetcode.com/problems/permutations/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var res = new List<IList<int>>();
        
        backtrack(res, new List<int>(), nums, new HashSet<int>());
        
        return res;
    }
    
    public void backtrack(List<IList<int>> res, List<int> current, int[] nums, HashSet<int> visited) {
        if (current.Count == nums.Length) {
            res.Add(new List<int>(current));
            
            return;
        }
        
        for (var i = 0; i < nums.Length; i++) {
            if (!visited.Contains(i)) {
                visited.Add(i);
                current.Add(nums[i]);
                
                backtrack(res, current, nums, visited);
                
                current.RemoveAt(current.Count - 1);
                visited.Remove(i);
            }
        }
    }
}