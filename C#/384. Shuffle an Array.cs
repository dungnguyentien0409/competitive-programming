/*
 * Link: https://leetcode.com/problems/shuffle-an-array/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    int[] nums;
    Random random = new Random();
    
    public Solution(int[] nums) {
        this.nums = nums;    
    }
    
    /** Resets the array to its original configuration and return it. */
    public int[] Reset() {
        return this.nums;
    }
    
    /** Returns a random shuffling of the array. */
    public int[] Shuffle() {
        var shuffle = new int[this.nums.Length];
        Array.Copy(this.nums, shuffle, this.nums.Length);
        
        for (var i = 0; i < nums.Length; i++) {
            var j = random.Next(i + 1);
            swap(shuffle, i, j);
        }
        
        return shuffle;
    }
    
    public void swap(int[] nums, int x, int y) {
        if (x == y) return;
        
        var tmp = nums[x];
        nums[x] = nums[y];
        nums[y] = tmp;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */