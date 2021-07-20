public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = Create();
        var cols = Create();
        var blocks = CreateBlocks();
        
        for (var i = 0; i < 9; i++) {
            for (var j = 0; j < 9; j++) {
                var c = board[i][j];
                if (c == '.') continue;
                
                var blockKey = (i / 3) + "" + (j / 3);
                if (rows[i].Contains(c) || cols[j].Contains(c) || blocks[blockKey].Contains(c))
                    return false;
                rows[i].Add(c);
                cols[j].Add(c);
                blocks[blockKey].Add(c);
            }
        }
        
        return true;
    }
    
    public Dictionary<int, HashSet<char>> Create() {
        var res = new Dictionary<int, HashSet<char>>();
        
        for (var i = 0; i < 9; i++) {
            res.Add(i, new HashSet<char>());
        }
        
        return res;
    }
    
    public Dictionary<string, HashSet<char>> CreateBlocks() {
        var res = new Dictionary<string, HashSet<char>>();
        var key = new string[] { "00", "01", "02", "10", "11", "12", "20", "21", "22" };
        
        foreach(var k in key) {
            res.Add(k, new HashSet<char>());
        }
        
        return res;
    }
}