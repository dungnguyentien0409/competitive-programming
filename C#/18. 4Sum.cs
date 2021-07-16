public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        var res = new List<IList<int>>();
        Array.Sort(nums);
        
        for (var i = 0; i < nums.Length - 3; i++) {
            for (var j = i + 1; j < nums.Length - 2; j++) {
                int left = j + 1, right = nums.Length - 1;
                
                while(left < right) {
                    int val = nums[i] + nums[j] + nums[left] + nums[right];
                    if (val == target) {
                        res.Add(new List<int>(new int[] { nums[i], nums[j], nums[left], nums[right] }));

                        while(left < right && nums[left] == nums[left + 1]) left++;
                        while(left < right && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if (val > target) {
                        right--;
                    }
                    else {
                        left++;
                    }
                }
                
                while(j < nums.Length - 2 && nums[j] == nums[j + 1]) j++;
            }
            while (i < nums.Length - 3 && nums[i] == nums[i + 1]) i++;
        }
        
        return res;
    }
}