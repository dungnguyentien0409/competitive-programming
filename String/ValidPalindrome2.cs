/*
 * Problem: https://leetcode.com/problems/valid-palindrome-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool ValidPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;
        var arr = s.ToCharArray();
        
        while(left < right) {
            if (arr[left] != arr[right]) {
                var removeLeft = new string(arr.Where((val, idx) => idx != left).ToArray());
                var removeRight = new string(arr.Where((val, idx) => idx != right).ToArray());
                Console.WriteLine("removeLeft: " + removeLeft);
                Console.WriteLine("removeRight: " + removeRight);
                
                return (isPalindrome(removeLeft) || isPalindrome(removeRight));
            }
            
            left++;
            right--;
        }
        return true;
    }
    
    public bool isPalindrome(string s) {
        var tmp = s.ToCharArray();
        Array.Reverse(tmp);
        
        return s == new string(tmp);
    }
}