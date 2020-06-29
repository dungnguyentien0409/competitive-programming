/*
 * Link: https://leetcode.com/problems/majority-element-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int n1 = 0, n2 = 0, c1 = 0, c2 = 0;
        
        foreach(var n in nums) {
            if (c1 > 0 && c2 > 0) {
                if (n != n1 && n != n2) {
                    c1--;
                    c2--;
                }
                else {
                    c1 = (n == n1) ? c1++ : c1;
                    c2 = (n == n2) ? c2++ : c2;
                }
            }
            else if (c1 > 0) {
                if (n == n1) c1++;
                else {
                    n2 = n;
                    c2++;
                }
            }
            else if (c2 > 0) {
                if (n == n2) c2++;
                else {
                    n1 = n;
                    c1++;
                }
            }
            else {
                n1 = n;
                c1++;
            }
        }
        
        var res = new List<int>();
        c1 = 0; c2 = 0;
        
        foreach(var n in nums) {
            if (n == n1) c1++;
            else if (n == n2) c2++;
        }
        
        if (c1 > nums.Length / 3) res.Add(n1);
        if (c2 > nums.Length / 3) res.Add(n2);
        
        return res.ToArray();
    }
}