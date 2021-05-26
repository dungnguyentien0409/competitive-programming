/*
 * Link: https://leetcode.com/problems/evaluate-reverse-polish-notation/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int EvalRPN(string[] tokens) {
        var list = new List<string>();
        
        for (var i = 0; i < tokens.Length; i++) {
            var c = tokens[i];
            
            if (Int32.TryParse(c, out int n)) {
                list.Add(c);
            }
            else {
                var first = Int32.Parse(list[list.Count - 2]);
                var second = Int32.Parse(list[list.Count - 1]);
                list.RemoveAt(list.Count - 1);
                list.RemoveAt(list.Count - 1);
                
                int res = 0;
                
                if (c == "+") {
                    res = first + second;
                }
                else if (c == "-") {
                    res = first - second;
                }
                else if (c == "*") {
                    res = first * second;
                }
                else if (c == "/") {
                    res = first / second;
                }
                
                list.Add(res.ToString());
            }
        }
        
        return Int32.Parse(list[0]);
    }
}