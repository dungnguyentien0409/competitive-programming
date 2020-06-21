/*
 * Link: https://leetcode.com/problems/permutation-sequence/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string GetPermutation(int n, int k) {
        var numbers = GenerateSet(n);
        var factorials = GetFactorial(n);
        var res = string.Empty;
        var n2 = n;
        
        while(k > 0 && n2 > 0) {
            var noItems = factorials[n2 - 1];
            var index = (int)Math.Ceiling((double)k / noItems) - 1;
            
            res += numbers[index];
            numbers.RemoveAt(index);
            
            k = k - (noItems * index);
            n2--;
        }
        
        return res;
    }
    
    public List<int> GenerateSet(int n) {
        var l = new List<int>();
        
        for (var i = 1; i <= n; i++) l.Add(i);
        
        return l;
    }
    
    public int[] GetFactorial(int n) {
        var dp = new int[n + 1];
        
        dp[0] = 1;
        for (var i = 1; i <= n; i++) {
            dp[i] = dp[i - 1] * i;
        }
        
        return dp;
    }
}