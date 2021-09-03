public class Solution {
    public IList<int> DiffWaysToCompute(string expression) {
        var res = new List<int>();
        var operators = new HashSet<char>(new char[] { '+', '-', '*' });
        
        for(var i = 0; i < expression.Length; i++) {
            if (!operators.Contains(expression[i])) continue;
            
            var left = DiffWaysToCompute(expression.Substring(0, i));
            var right = DiffWaysToCompute(expression.Substring(i + 1));
            
            foreach(var vl in left) {
                foreach(var vr in right) {
                    switch(expression[i]) {
                        case '+':
                            res.Add(vl + vr);
                            break;
                        case '-':
                            res.Add(vl - vr);
                            break;
                        case '*':
                            res.Add(vl * vr);
                            break;
                    }
                }
            }
        }
        
        if (res.Count == 0) {
            res.Add(int.Parse(expression));
        }
        
        return res;
    }
}