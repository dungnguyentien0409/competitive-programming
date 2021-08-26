public class Solution {
    public bool IsValidSerialization(string preorder) {
        var arr = preorder.Split(",");
        int diff = 1;
        
        foreach(var item in arr) {
            if (--diff < 0) return false;
            if (item != "#") diff += 2;
        }
        
        return diff == 0;
    }
}