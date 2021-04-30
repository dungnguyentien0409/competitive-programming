/*
 * Link: https://leetcode.com/problems/powerful-integers/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<int> PowerfulIntegers(int x, int y, int bound) {
        var set = new HashSet<int>();
        
        for (int xi = 1; xi < bound; xi *= x) {
            for (int yj = 1; xi + yj <= bound; yj *= y) {
                set.Add(xi + yj);
                
                if (y == 1) break;
            }
            
            if (x == 1) break;
        }
        
        return set.ToList();
    }
}