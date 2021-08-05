public class Solution {
    public bool StoneGame(int[] piles) {
        int len = piles.Length;
        var dp = CreateDP(len);
        
        for (var i = 0; i < len; i++) {
            dp[i][i] = new Node(piles[i], 0);
        }
        
        for (var i = 0; i < len; i++) {
            for (var j = 0; j < len; j++) {
                if (i == j || i + 1 > j && j - 1 < i) continue;
                
                if (piles[i] + dp[i + 1][j].second >= piles[j] + dp[i][j - 1].second) {
                    dp[i][j].first = piles[i] + dp[i + 1][j].second;
                    dp[i][j].second = dp[i + 1][j].first;
                }
                else {
                    dp[i][j].first = piles[j] + dp[i][j - 1].second;
                    dp[i][j].second = dp[i][j - 1].first;
                }
            }
        }
        
        var res = dp[len - 1][len - 1];
        return res.first > res.second;
    }
    
    public Node[][] CreateDP(int len) {
        var dp = new Node[len][];
        
        for (var i = 0; i < len; i++) {
            dp[i] = new Node[len];
            
            for (var j = 0; j < len; j++) dp[i][j] = new Node();
        }
        
        return dp;
    }
}

public class Node {
    public int first;
    public int second;
    
    public Node() {}
    public Node(int f, int s) {
        first = f;
        second = s;
    }
}