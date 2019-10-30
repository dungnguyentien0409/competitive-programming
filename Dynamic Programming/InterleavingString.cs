public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        if (s1.Length + s2.Length != s3.Length) return false;
        
        var dp = createDP(s1, s2);
        Console.WriteLine(dp.Length);
        dp[0][0] = true;
        
        int i3 = 0;
        for (var i = 1; i <= s1.Length; i++) {
            if (s1[i - 1] == s3[i3]) {
                dp[i][0] = dp[i - 1][0];
                i3++;
            }
            else dp[i][0] = false;
        }
        
        i3 = 0;
        for (var i = 1; i <= s2.Length; i++) {
            if (s2[i - 1] == s3[i3]) {
                dp[0][i] = dp[0][i - 1];
                i3++;
            }
            else dp[0][i] = false;
        }
        
        i3 = 0;
        for (int i = 1; i <= s1.Length; i++) {
            i3 = i;
            for (int j = 1; j <= s2.Length; j++) {
                if (s1[i - 1] != s3[i3] && s2[j - 1] != s3[i3]) {
                    dp[i][j] = false;
                }
                else {
                    if (s1[i - 1] == s3[i3]) {
                        dp[i][j] = dp[i - 1][j] || dp[i][j];
                    }
                    
                    if (s2[j - 1] == s3[i3]) {
                        dp[i][j] = dp[i][j - 1] || dp[i][j];
                    }
                }
                i3++;
            }
        }
        
        return dp[s1.Length][s2.Length];
    }
    
    bool[][] createDP(string s1, string s2) {
        int n1 = s1.Length, n2 = s2.Length;
        
        var dp = new bool[n1 + 1][];
        
        for(int i = 0; i <= n1; i++) {
            dp[i] = new bool[n2 + 1];
            for (int j = 0; j <= n2; j++) {
                dp[i][j] = false;
            }
        }
        
        return dp;
    }
}