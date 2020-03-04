/*
 * Link: https://leetcode.com/problems/number-of-ways-to-stay-in-the-same-place-after-some-steps/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public static int MAX = (int)Math.Pow(10, 9) + 7;
    public int NumWays(int steps, int arrLen) {
        if (arrLen <= 1) return arrLen;
        
        var arr = new int[arrLen];
        // take the first step: stay at 0, or right to 1
        arr[0] = 1;
        arr[1] = 1;
        
        // take the second to the last step
        for (var step = 1; step < steps; step++) {
            var tmp = new int[arrLen];
            
            for (var pos = 0; pos < Math.Min(arrLen, steps - step); pos++) {
                var ans = arr[pos];
                
                if (pos > 0) ans = (ans + arr[pos - 1]) % MAX;
                if (pos < arrLen - 1) ans = (ans + arr[pos + 1]) % MAX;
                tmp[pos] = ans;
            }
            
            //arr = tmp;
        }
        
        return arr[0];
    }
}