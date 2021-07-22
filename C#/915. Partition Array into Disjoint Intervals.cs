public class Solution {
    public int PartitionDisjoint(int[] nums) {
        int len = nums.Length;
        var maxLeft = new int[len];
        var minRight = new int[len];
        
        int max = nums[0];
        for (var i = 0; i < nums.Length; i++) {
            max = Math.Max(max, nums[i]);
            maxLeft[i]= max;
        }
        
        int min = Int32.MaxValue;
        for (var i = nums.Length - 1; i >= 0; i--) {
            minRight[i] = min;
            min = Math.Min(min, nums[i]);
        }
        
        for(var i = 0; i < len; i++) {
            if (maxLeft[i] <= minRight[i]) return i + 1;
        }
        
        return len;
    }
}