public class Solution {
    int[] _nums;
    int _target;
    public int FindTargetSumWays(int[] nums, int target) {
        _nums = nums;
        _target = target;
        
        return Helper(0, 0, 0, new Dictionary<(int, int), int>());
    }
    
    public int Helper(int pos, int cur, int count, Dictionary<(int, int), int> cache) {
        if (pos == _nums.Length) {
            return cur == _target ? 1 : 0;
        }
        
        if (cache.ContainsKey((pos, cur))) return cache[(pos, cur)];
        
        cache[(pos, cur)] = Helper(pos + 1, cur + _nums[pos], count++, cache)
                     + Helper(pos + 1, cur -_nums[pos], count++, cache);
        
        return cache[(pos, cur)];
    }
}