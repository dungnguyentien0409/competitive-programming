/*
 * Link: https://leetcode.com/problems/smallest-subsequence-of-distinct-characters/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string SmallestSubsequence(string s) {
        var map = new Dictionary<char, int>();
        var IsInStack = new Dictionary<char, bool>();
        var st = new Stack<char>();
        
        foreach(var c in s) {
            if (!map.ContainsKey(c)) {
                map.Add(c, 0);
                IsInStack.Add(c, false);
            }
            
            map[c]++;
        }
        
        foreach(var c in s) {
            map[c]--;
            if (IsInStack[c]) continue;
            
            while (st.Count > 0 && c < st.Peek() && map[st.Peek()] > 0) {
                IsInStack[st.Pop()] = false;
            }
            
            st.Push(c);
            IsInStack[c] = true;
        }
        
        var arr = st.ToArray();
        Array.Reverse(arr);
        var res = string.Join("", arr);
        return res;
    }
}