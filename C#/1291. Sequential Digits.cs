/*
 * Link: https://leetcode.com/problems/sequential-digits/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<int> SequentialDigits(int low, int high) {
        var queue = new Queue<int>();
        var res = new List<int>();
        
        for (var i = 1; i <= 9; i++) queue.Enqueue(i);
        
        while(queue.Count > 0) {
            var n = queue.Dequeue();
            
            if (n >= low && n <= high) res.Add(n);
            
            var lastDigit = n % 10;
            var newNumber = n * 10 + lastDigit + 1;
            
            if (lastDigit < 9 && newNumber <= high) queue.Enqueue(newNumber);
        }
        
        return res;
    }
}