public class Solution {
    public bool CanConstruct(string s, int k) {
        if (s.Length < k) return false;
        var map = new Dictionary<char, int>();
        
        foreach(var c in s) {
            map[c] = map.ContainsKey(c) ? map[c] + 1 : 1;
        }
        
        int countOdd = 0;
        foreach(var item in map) {
            countOdd += item.Value % 2;
        }
        
        return countOdd <= k;
    }
}