public class Solution {
    public string BreakPalindrome(string palindrome) {
        var sb = new StringBuilder(palindrome);
        
        for(var i = 0; i < sb.Length / 2; i++) {
            if (sb[i] != 'a') {
                sb[i] = 'a';
                
                return sb.ToString();
            }
        }

        if (sb.Length == 1) return "";
        
        sb[sb.Length - 1] = 'b';
        return sb.ToString();
    }
}