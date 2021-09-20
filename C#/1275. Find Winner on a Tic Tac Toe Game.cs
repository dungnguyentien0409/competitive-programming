public class Solution {
    public string Tictactoe(int[][] moves) {
        int n = 3;
        var row = new int[n];
        var col = new int[n];
        int diag1 = 0, diag2 = 0;
        int player = 1;
        
        foreach(var m in moves) {
            row[m[0]] += player;
            col[m[1]] += player;
            
            if (m[0] == m[1]) diag1 += player;
            if (m[0] + m[1] == n - 1) diag2 += player;
            
            if (Math.Abs(row[m[0]]) == n || Math.Abs(col[m[1]]) == n
               || Math.Abs(diag1) == n || Math.Abs(diag2) == n) {
                return player == 1 ? "A" : "B";
            }
            
            player *= -1;
        }
        
        return moves.Length == n * n ? "Draw" : "Pending";
    }
}