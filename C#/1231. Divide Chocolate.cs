/*
 * Link: https://leetcode.com/problems/divide-chocolate/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaximizeSweetness(int[] sweetness, int K) {
        var min = GetMinValue(sweetness);
        var max = GetMaxValue(sweetness);
        
        while(min < max) {
            var mid = (min + max + 1) / 2;
            
            //Console.WriteLine(min + " " + max + " " + mid);
            if (CheckResult(sweetness, K, mid)) {
                min = mid;
            }
            else {
                max = mid - 1;
            }
        }
        
        return min;
    }
    
    public bool CheckResult(int[] sweetness, int cuts, int result) {
        var sum = 0;
        var count = 0;
        
        for (var i = 0; i < sweetness.Length; i++) {
            sum += sweetness[i];
            
            if (sum >= result) {
                sum = 0;
                count++;
                
                if (count > cuts) {
                    return true;
                }
            }
        }
        
        //Console.WriteLine(count + " " + cuts + " " result);
        Console.WriteLine(count + " " + cuts);
        return false;
    }
    
    public int GetMinValue(int[] sweetness) {
        var min = sweetness[0];
        
        foreach(var s in sweetness) min = Math.Min(min, s);
        
        return min;
    }
    
    public int GetMaxValue(int [] sweetness) {
        var max = 0;
        
        foreach(var s in sweetness) max += s;
        
        return max;
    }
}