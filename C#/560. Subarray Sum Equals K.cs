/*
 * Link: https://leetcode.com/problems/subarray-sum-equals-k/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        var count = 0;
        var sum = 0;
        
        map.Add(0, 1);
        foreach(var n in nums) {
            sum += n;
            
            Console.WriteLine(sum);
            if (map.ContainsKey(sum - k)) count += map[sum - k];
            
            if (!map.ContainsKey(sum)) map.Add(sum, 0);
            map[sum]++;
        }
        
        return count;
    }
}