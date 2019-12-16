/*
 * Problem: https://leetcode.com/problems/spiral-matrix-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[][] GenerateMatrix(int n) {
        if (n == 0)
            return CreateMatrix(0);
        
        var arr = CreateMatrix(n);
        
        int r1 = 0, r2 = n - 1;
        int c1 = 0, c2 = n - 1;
        int i = 1;
        
        while(c1 <= c2 && r1 <= r2) {
            for (var c = c1; c <= c2; c++) 
                arr[r1][c] = i++;
            
            for (var r = r1 + 1; r <= r2; r++)
                arr[r][c2] = i++;
            
            if (c1 < c2 && r1 < r2) {
                for (var c = c2 - 1; c >= c1; c--)
                    arr[r2][c] = i++;
                
                for (var r = r2 - 1; r > r1; r--)
                    arr[r][c1] = i++;
            }
            
            c1++;
            r1++;
            c2--;
            r2--;
        }
        
        return arr;
    }
    
    public int[][] CreateMatrix(int n) {
        var arr = new int[n][];
        
        for (var i = 0; i < n; i++) arr[i] = new int[n];
        
        return arr;
    }
}