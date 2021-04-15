/*
 * Link: https://leetcode.com/problems/minimum-swaps-to-group-all-1s-together/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinSwaps(int[] data) {
        int ones = 0;
        foreach(var n in data) {
            if (n == 1) ones++;
        }
        
        int start = 0, end = 0;
        int curOnes = 0, maxOnes = 0;
        while(end < data.Length) {
            if (end - start < ones) {
                curOnes += data[end++];
                maxOnes = Math.Max(maxOnes, curOnes);
            }
            else {
                curOnes -= data[start++];
            }
        }
        
        return ones - maxOnes;
    }
}