/*
 * Link: https://leetcode.com/problems/string-compression/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int Compress(char[] chars) {
        if (chars.Length == 0) return 0;
        
        int i = 0, index = 0;
        while(i < chars.Length) {
            var current = chars[i];
            int count = 0;
            
            while (i < chars.Length && current == chars[i]) {
                i++;
                count++;
            }
            
            chars[index++] = current;
            if (count > 1) {
                foreach(var c in count.ToString()) {
                    chars[index++] = c;
                }
            }
        }
        
        return index;
    }
}