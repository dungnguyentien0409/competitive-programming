/*
 * Link: https://leetcode.com/problems/largest-number/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string LargestNumber(int[] nums) {
        if (EqualToZero(nums)) return "0";
        
        var convert = ConvertArray(nums);
        Array.Sort(convert, delegate(string a, string b) {
            return (b + a).CompareTo(a + b);
        });
            
        return string.Join("", convert);
    }
    
    public string[] ConvertArray(int [] nums) {
        var convert = new string[nums.Length];
        
        for(var i = 0; i < nums.Length; i++) {
            convert[i] = nums[i].ToString();
        }
        
        return convert;
    }
    
    public bool EqualToZero(int[] nums) {
        foreach(var n in nums) {
            if (n != 0) return false;
        }
        
        return true;
    }
}