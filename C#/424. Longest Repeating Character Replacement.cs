public class Solution {
    public int CharacterReplacement(string s, int k) {
        int len = s.Length, start = 0, end = 0, maxCount = 0, maxLen = 0;
        var count = new int[26];
        
        while(end < len) {
            maxCount = Math.Max(maxCount, ++count[s[end++] - 'A']);
            
            while(end - start - maxCount > k) {
                count[s[start++] - 'A']--;
            }
            
            maxLen = Math.Max(maxLen, end - start);
        }
        
        return maxLen;
    }
}