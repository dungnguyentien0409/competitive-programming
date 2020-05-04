/*
 * Link: https://leetcode.com/problems/number-complement/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindComplement(int num) {
        int i = 0, j = 0;
        
        while(i < num) {
            i += (int)Math.Pow(2, j);
            j++;
        }
        
        return i - num;
    }
}