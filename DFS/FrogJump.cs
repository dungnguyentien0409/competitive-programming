/*
 * Problem: https://leetcode.com/problems/frog-jump/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool CanCross(int[] stones) {
        var traces = new Dictionary<int, List<int>>();
        
        foreach(var stone in stones) {
            traces.Add(stone, new List<int>());
        }
        
        var canJump = Backtrack(stones, 0, 0, traces);
        
        return canJump;
    }
    
    public bool Backtrack(int[] stones, int current, int jump, Dictionary<int, List<int>> traces) {
        if (current == stones[stones.Length - 1]) 
            return true;
        
        var nextJumps = new int[] { jump - 1, jump, jump + 1 };
        foreach(var nextJump in nextJumps) {
            if (nextJump > 0 
                && nextJump + jump > 0 // the case both of them is zero 
                && stones.Any(stone => stone == current + nextJump) // can land on the next stone
                && current + nextJump <= stones[stones.Length - 1] // dont pass the last stone
                && !traces[current].Any(nJump => nJump == nextJump) // dont have the wrong jump
                && Backtrack(stones, current + nextJump, nextJump, traces))
                return true;
            
            // save the wrong pair stone - jump
            traces[current].Add(nextJump);
        }
        
        return false;
    }
}