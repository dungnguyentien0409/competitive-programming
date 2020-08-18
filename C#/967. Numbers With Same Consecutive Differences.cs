/*
 * Link: https://leetcode.com/problems/numbers-with-same-consecutive-differences/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] NumsSameConsecDiff(int N, int K) {
        var res = new List<int>() { 0,1,2,3,4,5,6,7,8,9 };
        
        for (var i = 2; i <= N; i++) {
            var tmp = new List<int>();
            
            foreach(var r in res) {
                int lastDigit = r % 10;
                
                if (r > 0 && lastDigit + K < 10) {
                    tmp.Add(r * 10 + (lastDigit + K));
                }
                if (r > 0 && K > 0 && lastDigit - K >= 0) {
                    tmp.Add(r * 10 + (lastDigit - K));
                }
            }
            
            res = tmp;
        }
        
        return res.ToArray();
    }
}