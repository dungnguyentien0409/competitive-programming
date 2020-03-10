/*
 * Link: https://leetcode.com/problems/flatten-2d-vector/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Vector2D {
    int lastX;
    int x, y;
    int[][] v;
    
    public Vector2D(int[][] v) {
        this.v = v;
        
        lastX = v.Length - 1;
        x = 0;
        y = 0;
    }
    
    public int Next() {
        var result = v[x][y];
        
        y++;
        MoveToNextX();
        
        return result;
    }
    
    public bool HasNext() {
        MoveToNextX();
        
        if (x == v.Length) return false;
        
        return true;
    }
    
    private void MoveToNextX() {
        while(x < v.Length && y == v[x].Length) {
            x++;
            y = 0;
        }
    }
}

/**
 * Your Vector2D object will be instantiated and called as such:
 * Vector2D obj = new Vector2D(v);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */