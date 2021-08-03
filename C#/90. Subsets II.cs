public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        
        var res = new List<IList<int>>();
        
        Backtrack(res, new List<int>(), nums, 0);
        
        return res;
    }
    
    public void Backtrack(List<IList<int>> res, List<int> cur, int[] nums, int index) {
        res.Add(new List<int>(cur));
        
        for (var i = index; i < nums.Length; i++) {
            if (i > index && nums[i] == nums[i - 1]) continue;
            
            cur.Add(nums[i]);
            Backtrack(res, cur, nums, i + 1);
            cur.RemoveAt(cur.Count - 1);
        }
    }
}