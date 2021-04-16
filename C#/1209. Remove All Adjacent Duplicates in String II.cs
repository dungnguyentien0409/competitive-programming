/*
 * Link: https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string RemoveDuplicates(string s, int k) {
        var st = new Stack<KeyValuePair<char, int>>();
        
        foreach(var c in s) {
            if (st.Count == 0 || st.Peek().Key != c) {
                st.Push(new KeyValuePair<char, int>(c, 1));
            }
            else {
                var cur = st.Pop();
                
                if (cur.Value + 1 < k) {
                    st.Push(new KeyValuePair<char, int>(c, cur.Value + 1));
                }
            }
        }
        
        var sb = new StringBuilder();
        while(st.Count > 0) {
            var cur = st.Pop();
            
            for (var i = 0; i < cur.Value; i++) {
                sb.Insert(0, cur.Key);
            }
        }
        
        return sb.ToString();
    }
}