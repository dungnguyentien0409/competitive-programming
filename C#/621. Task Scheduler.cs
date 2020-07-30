/*
 * Link: https://leetcode.com/problems/task-scheduler/submissions/
 * Idea: jinzhou
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int max = 0, countMax = 0;
        int[] count = new int[26];
        
        foreach(var t in tasks) {
            count[t - 'A']++;
            
            if (max < count[t - 'A']) {
                max = count[t - 'A'];
                countMax = 1;
            }
            else if (max == count[t - 'A']) {
                countMax++;
            }
        }
        
        int partCount = max - 1;
        int partLength = n - (countMax - 1);
        int emptySlots = partCount * partLength;
        int availableTasks = tasks.Length - countMax * max;
        int idles = Math.Max(0, emptySlots - availableTasks);
        
        return tasks.Length + idles;
    }
}