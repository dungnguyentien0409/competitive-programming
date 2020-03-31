/*
 * Link: https://leetcode.com/problems/find-lucky-integer-in-an-array/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindLucky(int[] arr) {
        var map = new Dictionary<int, int>();
        var luckyNumber = -1;
        
        foreach(var n in arr) {
            if (!map.ContainsKey(n)) {
                map.Add(n, 0);
            }
            
            map[n]++;
        }
        
        var numbers = map.Keys.ToList();
        foreach(var n in numbers) {
            if (map[n] == n) {
                luckyNumber = Math.Max(luckyNumber, n);
            }
        }
        
        return luckyNumber;
    }
}