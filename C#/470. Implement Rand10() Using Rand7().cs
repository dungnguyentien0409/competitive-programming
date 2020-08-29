/**
 * Link: https://leetcode.com/problems/implement-rand10-using-rand7/
 * Author: Dung Nguyen Tien (Chris)
 * The Rand7() API is already defined in the parent class SolBase.
 * public int Rand7();
 * @return a random integer in the range 1 to 7
 */
public class Solution : SolBase {
    public int Rand10() {
        int row = Rand7(), col = Rand7();
        
        var n = col + (row - 1) * 7;
        
        if (n > 40) return Rand10();
        return n % 10 == 0 ? 10 : n % 10;
    }
}