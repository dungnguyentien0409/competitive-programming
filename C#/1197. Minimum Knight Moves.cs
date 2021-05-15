
/*
 * Link: https://leetcode.com/problems/minimum-knight-moves/
 * Author: Dung Nguyen Tien (Chris)
*/
public class Solution {
    public int MinKnightMoves(int x, int y) {
        return Helper(x, y, new Dictionary<string, int>());
    }
    
    public int Helper(int x, int y, Dictionary<string, int> memory) {
        x = Math.Abs(x);
        y = Math.Abs(y);
        
        var key = x + "*" + y;
        
        if (memory.ContainsKey(key)) return memory[key];
        
        if (x + y == 0) return 0;
        else if (x + y == 2) return 2;
        
        var min = Math.Min(Helper(x - 2, y - 1, memory),
                           Helper(x - 1, y - 2, memory)) + 1;
        
        memory.Add(key, min);
        
        return min;
    }
}