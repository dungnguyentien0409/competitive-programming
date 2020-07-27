/*
 * Link: https://leetcode.com/problems/add-digits/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int AddDigits(int num) {
        return 1 + (num - 1) % 9;
    }
}