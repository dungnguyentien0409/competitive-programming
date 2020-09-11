/*
 * Link: https://leetcode.com/problems/bulls-and-cows/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string GetHint(string secret, string guess) {
        var arr = new int[10];
        int A = 0, B = 0;
        
        for (var i = 0; i < secret.Length; i++) {
            var s = secret[i] - '0';
            var g = guess[i] - '0';
            
            if (s == g) A++;
            else {
                arr[s]++;
                arr[g]--;
                
                if (arr[s] <= 0) B++;
                if (arr[g] >= 0) B++;
            }
        }
        
        return A + "A" + B + "B";
    }
}