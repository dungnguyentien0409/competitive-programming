
/*
 * Link: https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters/
 * Author: Dung Nguyen Tien (Chris)
*/
public class Solution {
    public int MaxLength(IList<string> arr) {
        max = 0;
        
        arr = arr.Where(w => CheckWord(w)).ToList();
        
        Backtrack(arr, new HashSet<char>(), new StringBuilder(), 0);
        
        return max;
    }
    
    int max;
    public void Backtrack(IList<string> arr, HashSet<char> set, StringBuilder cur, int start) {    
        for (var i = start; i < arr.Count; i++) {
            var word = arr[i];
            
            if (Contains(set, word)) continue;
            
            foreach(var c in word) set.Add(c);
            cur.Append(word);

            Backtrack(arr, set, cur, i + 1);

            foreach(var c in word) set.Remove(c);
            cur.Length -= word.Length;
        }
        
        max = Math.Max(max, cur.Length);
    }
    
    public bool Contains(HashSet<char> set, string w) {
        foreach(var c in w) {
            if (set.Contains(c)) return true;
        }
        
        return false;
    }
    
    public bool CheckWord(string w) {
        var set = new HashSet<char>();
        
        foreach(var c in w) {
            if (set.Contains(c)) return false;
            
            set.Add(c);
        }
        
        return true;
    }
}