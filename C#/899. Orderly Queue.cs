public class Solution {
    public string OrderlyQueue(string s, int k) {
        if (k > 1) {
            var arr = s.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }
        
        var res = s;
        var doubleS = s + s;
        for(var i = 0; i < s.Length; i++) {
            var rotate = doubleS.Substring(i, s.Length);
            
            if (res.CompareTo(rotate) > 0) {
                res = rotate;
            }
        }
        
        return res;
    }
}