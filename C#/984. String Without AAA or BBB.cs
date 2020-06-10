/*
 * Link: https://leetcode.com/problems/string-without-aaa-or-bbb/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string StrWithout3a3b(int A, int B) {
        int count = A + B, countA = 0, countB = 0;
        var res = new StringBuilder();
        
        while(count > 0) {
            if (countA < 2 && countB < 2) {
                if (A > B) {
                    res.Append("a");
                    A--;
                    countA++;
                    countB = 0;
                }
                else {
                    res.Append("b");
                    B--;
                    countB++;
                    countA = 0;
                }
            }
            else if (countA >= 2) {
                res.Append("b");
                countB++;
                countA = 0;
                B--;
            }
            else {
                res.Append("a");
                countA++;
                countB = 0;
                A--;
            }
            
            count--;
        }
        
        return res.ToString();
    }
}