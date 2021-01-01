/*
 * Link: https://leetcode.com/problems/check-array-formation-through-concatenation/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool CanFormArray(int[] arr, int[][] pieces) {
        var indexes = new List<IList<int>>();
        
        foreach(var p in pieces) {
            var current = new List<int>();
            
            foreach(var n in p) {
                var i = Array.IndexOf(arr, n);
                
                if (i < 0) return false;
                current.Add(i);
            }
            
            indexes.Add(current);
        }
        
        indexes.Sort(delegate(IList<int> a, IList<int> b) {
            return a[0] - b[0];
        });
        
        var currentIndex = 0;
        foreach(var item in indexes) {
            foreach(var i in item) {
                if (i == currentIndex) currentIndex++;
                else return false;
            }
        }
        
        return true;
    }
}