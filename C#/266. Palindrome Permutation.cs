/*
 * Link: https://leetcode.com/problems/palindrome-permutation/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool CanPermutePalindrome(string s) {
        var set = new HashSet<char>();
        
        foreach(var c in s) {
            if (set.Contains(c)) {
                set.Remove(c);
            }
            else {
                set.Add(c);
            }
        }
        
        return set.Count <= 1;
    }
}