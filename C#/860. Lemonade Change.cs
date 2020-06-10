/*
 * Link: https://leetcode.com/problems/lemonade-change/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool LemonadeChange(int[] bills) {
        int c5 = 0, c10 = 0;
        
        foreach(var b in bills) {
            if (b == 5) {
                c5++;
            }
            else if (b == 10) {
                if (c5 >= 1) {
                    c5--;
                }
                else {
                    return false;
                }
                
                c10++;
            }
            else {
                if (c10 > 0 && c5 > 0) {
                    c10--;
                    c5--;
                }
                else if (c5 >= 3) {
                    c5 -= 3;
                }
                else {
                    return false;
                }
            }
        }
        
        return true;
    }
}