/*
 * Link: https://leetcode.com/problems/rectangle-area/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
        var area1 = GetArea(A, B, C, D);
        var area2 = GetArea(E, F, G, H);
        var cover = GetCoverRectangle(A, B, C, D, E, F, G, H);
        
        return area1 + area2 - cover;
    }
    
    public int GetCoverRectangle(int A, int B, int C, int D, int E, int F, int G, int H) {
        var xL = Math.Max(A, E);
        var yL = Math.Max(B, F);
        var xR = Math.Min(C, G);
        var yR = Math.Min(D, H);
        
        return (xL < xR && yL < yR) ? GetArea(xL, yL, xR, yR) : 0;
    }
    
    public int GetArea(int xL, int yL, int xR, int yR) {
        var h = Math.Abs(yL - yR);
        var w = Math.Abs(xL - xR);
        
        return (int) h * w;
    }
}