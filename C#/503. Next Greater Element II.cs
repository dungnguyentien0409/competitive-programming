/*
 * Link: https://leetcode.com/problems/next-greater-element-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        var st = new Stack<int>();
        var n = nums.Length;
        var result = new int[n];
        
        Array.Fill(result, -1);
        for(var i = 0; i < n * 2; i++) {
            var index = i % n;
            
            while(st.Count > 0 && nums[st.Peek()] < nums[index]) {
                result[st.Pop()] = nums[index];
            }
            
            st.Push(index);
        }
        
        return result;
    }
}