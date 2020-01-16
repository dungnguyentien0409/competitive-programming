/*
 * Link: https://leetcode.com/problems/minimum-size-subarray-sum/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {       
        var queue = new Queue<int>();
        var sum = 0;
        var minLen = Int32.MaxValue;
        
        foreach(var n in nums) {
            sum += n;
            queue.Enqueue(n);
            
            while(sum >= s) {
                minLen = Math.Min(minLen, queue.Count);
                
                var pop = queue.Dequeue();
                sum -= pop;
            }
        }
        
        return minLen == Int32.MaxValue ? 0 : minLen;
    }
}