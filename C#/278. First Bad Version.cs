/*
 * Link: https://leetcode.com/problems/first-bad-version/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int left = 1, right = n;
        
        while(left < right) {
            int mid = left + (right - left) / 2;
            
            var check = IsBadVersion(mid);
            if (check) {
                right = mid;
            }
            else {
                left = mid + 1;
            }
        }
        
        return left;
    }
}