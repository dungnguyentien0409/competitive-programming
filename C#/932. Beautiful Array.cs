/*
 * Link: https://leetcode.com/problems/beautiful-array/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: lee215
*/

public class Solution {
    public int[] BeautifulArray(int N) {
        // if A is a beautiful array then A1 = A * 2 - 1 is a beautiful array
        // if A is a beautiful array then A2 = A * 2 is a beautiful array
        // if A1, A2 are beautiful arrays then B = A1 + A2 is a beautiful array
        var res = new List<int>();
        
        res.Add(1);
        while(res.Count < N) {
            var tmp = new List<int>();
            
            foreach(var i in res) if (i * 2 - 1 <= N) tmp.Add(i * 2 - 1);
            foreach(var i in res) if (i * 2 <= N) tmp.Add(i * 2);
            
            res = tmp;
        }
        
        return res.ToArray();
    }
}