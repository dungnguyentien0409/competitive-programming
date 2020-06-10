/*
 * Link: https://leetcode.com/problems/bag-of-tokens/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int BagOfTokensScore(int[] tokens, int P) {
        Array.Sort(tokens, delegate(int a, int b) { return a - b; });
        
        int left = 0, right = tokens.Length - 1;
        int points = 0;
        int max = 0;
        
        while(left <= right) {
            if (P >= tokens[left]) {
                P -= tokens[left++];
                points++;
                max = Math.Max(max, points);
            }
            else if (points > 0) {
                points--;
                P += tokens[right--];
            }
            else {
                break;
            }
        }
        
        return max;
    }
}