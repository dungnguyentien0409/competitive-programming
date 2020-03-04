// Problem: https://leetcode.com/problems/3sum/
// Author: Dung Nguyen Tien (Chris)

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();
        
        for (int i = 0; i < nums.Length - 2; i++) {
            int first = i;
            int left = i + 1;
            int right = nums.Length - 1;
            
            while(left < right) {
                var sum = nums[first] + nums[left] + nums[right];
                
                if (sum == 0) {
                    var array = new List<int>{ nums[first], nums[left], nums[right] };
                    result.Add(array);
                    
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;
                    left++;
                    right--;
                }
                else if (sum > 0) right--;
                else left++;
            }
            
            while (i < nums.Length - 2 && nums[i] == nums[i + 1]) i++;
        }
        
        return result;
    }
}