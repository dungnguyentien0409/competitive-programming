/*
 * Link: https://leetcode.com/problems/simplify-path/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string SimplifyPath(string path) {
        var st = new Stack<string>();
        var paths = path.Split(new char[] { '/' });
        
        foreach(var p in paths) {
            if (st.Count > 0 && p == "..") {
                st.Pop();
            }
            else if (p != "." && p != "" && p != "..") {
                st.Push(p);
            }
        }
        
        var arr = st.ToArray();
        Array.Reverse(arr);
        var res = String.Join("/", arr);
        return "/" + res;
    }
}