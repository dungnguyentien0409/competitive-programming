/*
 * Link: https://leetcode.com/problems/can-place-flowers/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int count = 0;
        int len = flowerbed.Length;
        
        for (var i = 0; i < len; i++) {
            if (flowerbed[i] == 1
               || (i + 1 < len && flowerbed[i + 1] == 1)
               || (i - 1 >= 0 && flowerbed[i - 1] == 1)) continue;
   
            flowerbed[i] = 1;
            count++;
        }
        
        return count >= n;
    }
}