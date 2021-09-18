public class Solution {
    string _num;
    int _target;
    public IList<string> AddOperators(string num, int target) {
        var res = new List<string>();
        _num = num;
        _target = target;
        
        Helper(res, 0, "", 0, 0);
        
        return res;
    }
    
    public void Helper(List<string> res, int pos, string cur, long val, long multiple) {
        if (pos == _num.Length && val == _target) {
            res.Add(cur);
        } 
        
        for(var i = pos; i < _num.Length; i++) {
            if (i > pos && _num[pos] == '0') break;
            
            var numberString = _num.Substring(pos, i - pos + 1);
            var numberVal = long.Parse(numberString);
            
            if (pos == 0) {
                Helper(res, i + 1, numberString, numberVal, numberVal);
            }
            else {
                // +
                Helper(res, i + 1, cur + "+" + numberString, val + numberVal, numberVal);
                
                // - 
                Helper(res, i + 1, cur + "-" + numberString, val - numberVal, -numberVal);
                
                // *
                Helper(res, i + 1, cur + "*" + numberString, val - multiple + multiple * numberVal, multiple * numberVal);
            }
        }
    }
}