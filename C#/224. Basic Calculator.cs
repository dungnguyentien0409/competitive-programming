public class Solution {
    public int Calculate(string s) {
        var res = Helper(s);
        
        return res.Item1;
    }
    
    public (int, int) Helper(string s) {
        var st = new Stack<int>();
        char sign = '+';
        int res = 0, i = 0, num = 0;
        
        while(i < s.Length) {
            if (IsNumber(s[i])) {
                num = num * 10 + int.Parse(s[i].ToString());
            }
            else if (s[i] == '+' || s[i] == '-' || s[i] == '*' || s[i] == '/') {
                Update(st, sign, num);
                num = 0;
                sign = s[i];
            }
            else if (s[i] == '(') {
                var calc = Helper(s.Substring(i + 1));
                
                num = calc.Item1;
                i += calc.Item2;
            }
            else if (s[i] == ')') {
                Update(st, sign, num);
                return (st.Sum(), i + 1);
            }
            
            i++;
        }
        
        Update(st, sign, num);
        return (st.Sum(), i);
    }
    
    public void Update(Stack<int> st, char sign, int num) {
        if (sign == '+') {
            st.Push(num);
        }
        else if (sign == '-') {
            st.Push(-num);
        }
        else if (sign == '*') {
            st.Push(st.Pop() * num);
        }
        else if (sign == '/') {
            st.Push(st.Pop() / num);
        }
    }
    
    public bool IsNumber(char c) {
        var s = c.ToString();
        
        return int.TryParse(s, out int n);
    }
}