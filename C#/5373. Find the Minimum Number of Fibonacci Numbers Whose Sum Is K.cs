/*
 * Link: https://leetcode.com/problems/find-the-minimum-number-of-fibonacci-numbers-whose-sum-is-k/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindMinFibonacciNumbers(int k) {
        if (k <= 1) return k;
        
        int count = 0;
        var fibs = CreateFibs(k);
        var index = fibs.Count - 1;
        
        while(k > 0) {
            count += (k / fibs[index]);
            k = k % fibs[index];
            
            index--;
        }
        
        return count;
    }
    
    public List<int> CreateFibs(int k) {
        if (k == 1) return new List<int>(new int[] {1});
        
        var res = new List<int>();
        int first = 0, second = 1;
        
        while(first + second <= k) {
            var next = first + second;
            
            res.Add(next);
            first = second;
            second = next;
        }
        
        return res;
    }
}