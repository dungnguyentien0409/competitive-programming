public class Solution {
    public int MinDeletions(string s) {
        var arr = new int[26];
        
        foreach(var c in s) arr[c - 'a']++;
        
        Array.Sort(arr);
        
        int keep = arr[25], prev = arr[25];
        
        for (var i = 24; i >= 0; i--) {
            if (arr[i] == 0 || prev == 0) continue;
            
            prev = Math.Min(arr[i], prev - 1);
            keep += prev; 
        }
        
        return s.Length - keep;
    }
}