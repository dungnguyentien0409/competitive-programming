public class Solution {
    int[,,] cache;
    public int RemoveBoxes(int[] boxes) {
        int n = boxes.Length;
        cache = new int[n, n, n];
        
        return dp(boxes, 0, n - 1, 0);
    }
    
    public int dp(int[] boxes, int l, int r, int k) {
        if (l > r) return 0;
        if (cache[l, r, k] > 0) return cache[l, r, k];
        
        int curLeft = l, curK = k;
        while(curLeft < r && boxes[curLeft] == boxes[curLeft + 1]) {
            curLeft++;
            curK++;
        }
        
        var res = (curK + 1) * (curK + 1) + dp(boxes, curLeft + 1, r, 0);
        
        for (var m = curLeft + 1; m <= r; m++) {
            if (boxes[m] == boxes[curLeft]) {
                res = Math.Max(res, 
                              dp(boxes, m, r, curK + 1) + dp(boxes, curLeft + 1, m - 1, 0));
            }
        }
        
        return cache[l, r, k] = res;
    }
}