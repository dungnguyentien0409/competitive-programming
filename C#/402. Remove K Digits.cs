/*
 * Link: https://leetcode.com/problems/remove-k-digits/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string RemoveKdigits(string num, int k) {
        var st = new Stack<int>();
        
        foreach(var c in num) {
            var n = Int32.Parse(c.ToString());
            
            while(st.Count > 0 && st.Peek() > n && k > 0) {
                st.Pop();
                k--;
            }
            
            st.Push(n);
        }
        
        while(st.Count > 0 && k > 0) {
            st.Pop();
            k--;
        }
        
        var res = new StringBuilder();
        while(st.Count > 0) {
            res.Insert(0, st.Pop().ToString());
        }
        
        var index = 0;
        while(index < res.Length && res[index] == '0') {
            index++;
        }
        
        return index == res.Length ? "0" : res.ToString().Substring(index);
    }
}