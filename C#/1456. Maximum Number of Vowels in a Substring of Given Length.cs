/*
 * Link: https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxVowels(string s, int k) {
        var set = new HashSet<char>(new char[] { 'a', 'i', 'u', 'o', 'e' });
        var queue = new Queue<char>();
        var count = 0;
        var max = 0;
        
        foreach(var c in s) {
            queue.Enqueue(c);
            if (set.Contains(c)) count++;
            
            while(queue.Count > k) {
                var removeChar = queue.Dequeue();
                if (set.Contains(removeChar)) count--;
            }
            
            if (queue.Count == k) {
                 max = Math.Max(max, count);
            }
        }
        
        return max;
    }
}