public class Solution {
    public int[] DiStringMatch(string s) {
        int len = s.Length, min = 0, max = len;
        var res = new int[len + 1];
        
        for(var i = 0; i < len; i++) {
            res[i] = s[i] == 'I' ? min++ : max--;
        }
        res[len] = max;
        
        return res;
    }
}