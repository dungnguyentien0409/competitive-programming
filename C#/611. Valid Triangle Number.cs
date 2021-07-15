public class Solution {
    public int TriangleNumber(int[] nums) {
        Array.Sort(nums);
        
        var res = 0;
        
        for(var i = 2; i < nums.Length; i++) {
            int left = 0, right = i - 1;
            while(left < right) {
                if (nums[left] + nums[right] > nums[i]) {
                    res += right - left;
                    right--;
                }
                else {
                    left++;
                }
            }
        }
        
        return res;
    }
}