public class Solution {
    public int ArrayNesting(int[] nums) {
        int len = nums.Length, res = 0;
        
        for(var i = 0; i < len; i++) {
            int x = nums[i];
            if (x == -1) continue;
            
            int count = 0;
            while(nums[x] != -1) {
                count++;
                int pre = x;
                x = nums[pre];
                nums[pre] = -1;
                
            }
            
            res = Math.Max(res, count);
        }
        
        return res;
    }
}