/*
 * Link: https://leetcode.com/problems/partition-array-into-three-parts-with-equal-sum/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool CanThreePartsEqualSum(int[] A) {
        var sum = Sum(A);
        
        if (sum % 3 != 0) return false;
        
        var partSum = 0;
        var count = 0;
        int i;
        for(i = 0; i < A.Length; i++) {
            var n = A[i];
            partSum += n;
            
            if (partSum == sum / 3) {
                count++;
                
                if (count == 2) break;
                partSum = 0;
            }
        }
        
        return sum - partSum * 2 == sum / 3 && i < A.Length - 1;
    }
    
    public int Sum(int[] A) {
        int sum = 0;
        
        foreach(var n in A) sum += n;
        
        return sum;
    }
}