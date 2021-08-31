public class Solution {
    public int ScoreOfParentheses(string s) {
        int score = 0;
        var st = new Stack<int>();
        
        for(var i = 0; i < s.Length; i++) {
            if (s[i] == '(') {
                st.Push(score);
                score = 0;
            }
            else if (s[i] == ')') {
                score = st.Pop() + Math.Max(score * 2, 1);
            }
        }
        
        
        return score;
    }
}